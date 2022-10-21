namespace ScraperAndChecker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnScrape = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.rTxtChecking = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rTxtProxies = new System.Windows.Forms.RichTextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtValid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblValid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRawProxy = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScrape
            // 
            this.btnScrape.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnScrape.Location = new System.Drawing.Point(5, 5);
            this.btnScrape.Name = "btnScrape";
            this.btnScrape.Size = new System.Drawing.Size(171, 59);
            this.btnScrape.TabIndex = 0;
            this.btnScrape.Text = "Scrape";
            this.btnScrape.UseVisualStyleBackColor = true;
            this.btnScrape.Click += new System.EventHandler(this.btnScrape_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.btnScrape);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1156, 69);
            this.panel1.TabIndex = 2;
            // 
            // lblInfo
            // 
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.Location = new System.Drawing.Point(518, 5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(633, 59);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "info";
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(347, 5);
            this.btnStop.Margin = new System.Windows.Forms.Padding(0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(171, 59);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(176, 5);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(0);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(171, 59);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // rTxtChecking
            // 
            this.rTxtChecking.BackColor = System.Drawing.Color.Black;
            this.rTxtChecking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTxtChecking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rTxtChecking.Location = new System.Drawing.Point(292, 39);
            this.rTxtChecking.Name = "rTxtChecking";
            this.rTxtChecking.ReadOnly = true;
            this.rTxtChecking.Size = new System.Drawing.Size(348, 556);
            this.rTxtChecking.TabIndex = 3;
            this.rTxtChecking.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.62284F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.79931F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.57785F));
            this.tableLayoutPanel1.Controls.Add(this.rTxtProxies, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCountry, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtValid, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblValid, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rTxtChecking, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRawProxy, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.168831F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.83117F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1156, 598);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // rTxtProxies
            // 
            this.rTxtProxies.BackColor = System.Drawing.Color.White;
            this.rTxtProxies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTxtProxies.ForeColor = System.Drawing.Color.Black;
            this.rTxtProxies.Location = new System.Drawing.Point(3, 39);
            this.rTxtProxies.Name = "rTxtProxies";
            this.rTxtProxies.ReadOnly = true;
            this.rTxtProxies.Size = new System.Drawing.Size(283, 556);
            this.rTxtProxies.TabIndex = 10;
            this.rTxtProxies.Text = "";
            // 
            // txtCountry
            // 
            this.txtCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCountry.Location = new System.Drawing.Point(898, 39);
            this.txtCountry.Multiline = true;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCountry.Size = new System.Drawing.Size(255, 556);
            this.txtCountry.TabIndex = 9;
            // 
            // txtValid
            // 
            this.txtValid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtValid.Location = new System.Drawing.Point(646, 39);
            this.txtValid.Multiline = true;
            this.txtValid.Name = "txtValid";
            this.txtValid.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtValid.Size = new System.Drawing.Size(246, 556);
            this.txtValid.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(898, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Country";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValid
            // 
            this.lblValid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValid.Location = new System.Drawing.Point(646, 0);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(246, 36);
            this.lblValid.TabIndex = 6;
            this.lblValid.Text = "Valid";
            this.lblValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(292, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Checking";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRawProxy
            // 
            this.lblRawProxy.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRawProxy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRawProxy.Location = new System.Drawing.Point(3, 0);
            this.lblRawProxy.Name = "lblRawProxy";
            this.lblRawProxy.Size = new System.Drawing.Size(283, 36);
            this.lblRawProxy.TabIndex = 4;
            this.lblRawProxy.Text = "Proxies";
            this.lblRawProxy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 667);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scrape and Check";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnScrape;
        private Panel panel1;
        private RichTextBox rTxtChecking;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtCountry;
        private TextBox txtValid;
        private Label label4;
        private Label lblValid;
        private Label label2;
        private Label lblRawProxy;
        private RichTextBox rTxtProxies;
        private Label lblInfo;
        private Button btnCheck;
        private Button btnStop;
    }
}