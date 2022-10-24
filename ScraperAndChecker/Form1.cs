using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using System.Net.NetworkInformation;

namespace ScraperAndChecker
{
    public partial class Form1 : Form
    {
        
        List<string> sources;
        bool scrapeOnLoad; //set to true if you want to start scrapping on load
        bool stopChecking;

        public Form1()
        {
            InitializeComponent();
            setSources();
            rTxtChecking.HideSelection = false; //allows [move to end] when add a new line
        }

        private void setSources()
        {
            sources = new List<string>();
            sources.AddRange(new string[] {
                "https://raw.githubusercontent.com/ShiftyTR/Proxy-List/master/http.txt",
                "https://raw.githubusercontent.com/ShiftyTR/Proxy-List/master/https.txt",
                "https://raw.githubusercontent.com/TheSpeedX/PROXY-List/master/http.txt"

            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (scrapeOnLoad) scrapeLinks();
            lblInfo.Text = "";
        }

        #region "scrape"
        private void btnScrape_Click(object sender, EventArgs e)
        {
            scrapeLinks();

            btnCheck.Enabled = true;
        }
        private void scrapeLinks()
        {
            rTxtProxies.Text = "";
            foreach (string line in sources)
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage response = client.GetAsync(new Uri(line)).Result)
                    {
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            lblInfo.Text = line;
                            Application.DoEvents();

                            using (HttpContent content = response.Content)
                            {
                                rTxtProxies.Text += response.Content.ReadAsStringAsync().Result;
                            }
                        }
                    }
                }
            }
            
            rTxtProxies.Text = Regex.Unescape(rTxtProxies.Text); //lines separators (\n \r \r\n)

            rTxtProxies.Text = string.Join(Environment.NewLine, rTxtProxies.Lines.Distinct()); //remove duplicated
                               
            lblInfo.Text = "Total: " + rTxtProxies.Lines.Count();

        }
        #endregion

        #region "check"
        private void btnCheck_Click(object sender, EventArgs e)
        {
            reset();

            var totalChecked = 0;
            foreach (string proxy in rTxtProxies.Lines)
            {
                if (stopChecking) break;

                var ip = proxy.Split(':')[0];
                var port = proxy.Split(':')[1];

                string info = getIP_Info(ip);

                Application.DoEvents();

                if (info == "dead")
                {
                    appendLine(rTxtChecking, proxy + " | " + info + "\r\n", Color.Red);
                }
                else
                {
                    appendLine(rTxtChecking, proxy + "\r\n", Color.Lime);
                    decodeInfo(info, proxy);
                }

                totalChecked++;
                lblInfo.Text = totalChecked.ToString() + "/" + rTxtProxies.Lines.Count().ToString();

            }
        }

        private void reset()
        {
            stopChecking = false;
            btnStop.Enabled = true;
            txtValid.Text = "";
            txtCountry.Text = "";
            rTxtChecking.Text="";
        }

        private void decodeInfo(string info, string proxy)
        {
            try
            {
                JObject jasonList = JObject.Parse(info);
                string country = (string)jasonList["country"];
                string region = (string)jasonList["regionName"];

                lblValid.Text = "Valid " + txtValid.Lines.Count().ToString();
                txtValid.AppendText(proxy + "\r\n");

                txtCountry.AppendText(country + " - " + region + "\r\n");

                Application.DoEvents();
            }
            catch { }
        }

        string getIP_Info(string ip)
        {
            
            string url = "http://ip-api.com/json/" + ip;

            var ping = new Ping();
            var reply = ping.Send(ip, 100);

            if (reply.Status == IPStatus.Success)
            {
                using (HttpResponseMessage response = new HttpClient().GetAsync(url).Result)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
            }
            else
            {
                return "dead";
            }

        }

        private void appendLine(RichTextBox RTB, string line, Color color, bool bold = false, 
            bool underline = false, bool italic = false, bool strikeout = false)
        {

            FontStyle fStyle = FontStyle.Regular;

            if (bold)
                fStyle = fStyle | FontStyle.Bold;
            if (italic)
                fStyle = fStyle | FontStyle.Italic;
            if (strikeout)
                fStyle = fStyle | FontStyle.Strikeout;
            if (underline)
                fStyle = fStyle | FontStyle.Underline;

            RTB.SelectionStart = RTB.TextLength;
            RTB.SelectionColor = color;
            RTB.SelectionFont = new Font(RTB.Font, fStyle);
            RTB.SelectedText = line;
        }


        #endregion

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopChecking = true;
        }
    }
}
