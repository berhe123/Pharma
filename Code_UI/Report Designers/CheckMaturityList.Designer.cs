namespace Pharma.Code_UI.Report_Designers
{
    /// <summary>
    /// Summary description for CheckMaturityList.
    /// </summary>
    partial class CheckMaturityList
    {
        private DataDynamics.ActiveReports.PageHeader pageHeader;
        private DataDynamics.ActiveReports.Detail detail;
        private DataDynamics.ActiveReports.PageFooter pageFooter;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }

        #region ActiveReport Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CheckMaturityList));
            DataDynamics.ActiveReports.DataSources.OleDBDataSource oleDBDataSource1 = new DataDynamics.ActiveReports.DataSources.OleDBDataSource();
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            this.label1 = new DataDynamics.ActiveReports.Label();
            this.label2 = new DataDynamics.ActiveReports.Label();
            this.textBox1 = new DataDynamics.ActiveReports.TextBox();
            this.textBox2 = new DataDynamics.ActiveReports.TextBox();
            this.label3 = new DataDynamics.ActiveReports.Label();
            this.label4 = new DataDynamics.ActiveReports.Label();
            this.label5 = new DataDynamics.ActiveReports.Label();
            this.textBox3 = new DataDynamics.ActiveReports.TextBox();
            this.textBox4 = new DataDynamics.ActiveReports.TextBox();
            this.label6 = new DataDynamics.ActiveReports.Label();
            this.label7 = new DataDynamics.ActiveReports.Label();
            this.textBox5 = new DataDynamics.ActiveReports.TextBox();
            this.label8 = new DataDynamics.ActiveReports.Label();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.label1,
            this.label2,
            this.textBox1,
            this.textBox2,
            this.label3,
            this.label4,
            this.label5,
            this.textBox3});
            this.pageHeader.Height = 1.541667F;
            this.pageHeader.Name = "pageHeader";
            // 
            // detail
            // 
            this.detail.ColumnSpacing = 0F;
            this.detail.Height = 0.4479167F;
            this.detail.Name = "detail";
            this.detail.Format += new System.EventHandler(this.detail_Format);
            // 
            // pageFooter
            // 
            this.pageFooter.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.textBox4,
            this.label6,
            this.label7,
            this.textBox5,
            this.label8});
            this.pageFooter.Height = 0.1875F;
            this.pageFooter.Name = "pageFooter";
            // 
            // label1
            // 
            this.label1.Border.BottomColor = System.Drawing.Color.Black;
            this.label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label1.Border.LeftColor = System.Drawing.Color.Black;
            this.label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label1.Border.RightColor = System.Drawing.Color.Black;
            this.label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label1.Border.TopColor = System.Drawing.Color.Black;
            this.label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label1.Height = 0.3125F;
            this.label1.HyperLink = "";
            this.label1.Left = 0F;
            this.label1.Name = "label1";
            this.label1.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 15.75pt; font-" +
                "family: Tahoma; ";
            this.label1.Text = "Bisrate Gebriel Phamacy";
            this.label1.Top = 0F;
            this.label1.Width = 7.4375F;
            // 
            // label2
            // 
            this.label2.Border.BottomColor = System.Drawing.Color.Black;
            this.label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label2.Border.LeftColor = System.Drawing.Color.Black;
            this.label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label2.Border.RightColor = System.Drawing.Color.Black;
            this.label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label2.Border.TopColor = System.Drawing.Color.Black;
            this.label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label2.Height = 0.3125F;
            this.label2.HyperLink = "";
            this.label2.Left = 0F;
            this.label2.Name = "label2";
            this.label2.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 15.75pt; font-" +
                "family: Tahoma; ";
            this.label2.Text = "Pharmaceutical Section";
            this.label2.Top = 0.3125F;
            this.label2.Width = 7.4375F;
            // 
            // textBox1
            // 
            this.textBox1.Border.BottomColor = System.Drawing.Color.Black;
            this.textBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox1.Border.LeftColor = System.Drawing.Color.Black;
            this.textBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox1.Border.RightColor = System.Drawing.Color.Black;
            this.textBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox1.Border.TopColor = System.Drawing.Color.Black;
            this.textBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox1.Height = 0.1875F;
            this.textBox1.Left = 4.4375F;
            this.textBox1.Name = "textBox1";
            this.textBox1.Style = "ddo-char-set: 0; font-size: 9.75pt; font-family: Tahoma; ";
            this.textBox1.Text = "571964";
            this.textBox1.Top = 0.8125F;
            this.textBox1.Width = 1.375F;
            // 
            // textBox2
            // 
            this.textBox2.Border.BottomColor = System.Drawing.Color.Black;
            this.textBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox2.Border.LeftColor = System.Drawing.Color.Black;
            this.textBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox2.Border.RightColor = System.Drawing.Color.Black;
            this.textBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox2.Border.TopColor = System.Drawing.Color.Black;
            this.textBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox2.Height = 0.1875F;
            this.textBox2.Left = 0.625F;
            this.textBox2.Name = "textBox2";
            this.textBox2.Style = "ddo-char-set: 0; font-size: 9.75pt; font-family: Tahoma; ";
            this.textBox2.Text = "+251911568205, +251911117103, +251911573918";
            this.textBox2.Top = 0.8125F;
            this.textBox2.Width = 3.1875F;
            // 
            // label3
            // 
            this.label3.Border.BottomColor = System.Drawing.Color.Black;
            this.label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label3.Border.LeftColor = System.Drawing.Color.Black;
            this.label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label3.Border.RightColor = System.Drawing.Color.Black;
            this.label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label3.Border.TopColor = System.Drawing.Color.Black;
            this.label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label3.Height = 0.1875F;
            this.label3.HyperLink = "";
            this.label3.Left = 0.1875F;
            this.label3.Name = "label3";
            this.label3.Style = "ddo-char-set: 0; text-decoration: none; text-align: right; font-weight: bold; fon" +
                "t-size: 9.75pt; font-family: Tahoma; ";
            this.label3.Text = "Tel:";
            this.label3.Top = 0.8125F;
            this.label3.Width = 0.375F;
            // 
            // label4
            // 
            this.label4.Border.BottomColor = System.Drawing.Color.Black;
            this.label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label4.Border.LeftColor = System.Drawing.Color.Black;
            this.label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label4.Border.RightColor = System.Drawing.Color.Black;
            this.label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label4.Border.TopColor = System.Drawing.Color.Black;
            this.label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label4.Height = 0.1875F;
            this.label4.HyperLink = "";
            this.label4.Left = 4F;
            this.label4.Name = "label4";
            this.label4.Style = "ddo-char-set: 0; text-decoration: none; text-align: right; font-weight: bold; fon" +
                "t-size: 9.75pt; font-family: Tahoma; ";
            this.label4.Text = "Fax:";
            this.label4.Top = 0.8125F;
            this.label4.Width = 0.375F;
            // 
            // label5
            // 
            this.label5.Border.BottomColor = System.Drawing.Color.Black;
            this.label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label5.Border.LeftColor = System.Drawing.Color.Black;
            this.label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label5.Border.RightColor = System.Drawing.Color.Black;
            this.label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label5.Border.TopColor = System.Drawing.Color.Black;
            this.label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label5.Height = 0.1875F;
            this.label5.HyperLink = "";
            this.label5.Left = 6.125F;
            this.label5.Name = "label5";
            this.label5.Style = "text-decoration: none; ddo-char-set: 0; text-align: right; font-weight: bold; fon" +
                "t-size: 9.75pt; font-family: Tahoma; ";
            this.label5.Text = "P.O.Box:";
            this.label5.Top = 0.8125F;
            this.label5.Width = 0.6875F;
            // 
            // textBox3
            // 
            this.textBox3.Border.BottomColor = System.Drawing.Color.Black;
            this.textBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox3.Border.LeftColor = System.Drawing.Color.Black;
            this.textBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox3.Border.RightColor = System.Drawing.Color.Black;
            this.textBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox3.Border.TopColor = System.Drawing.Color.Black;
            this.textBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox3.Height = 0.1875F;
            this.textBox3.Left = 6.875F;
            this.textBox3.Name = "textBox3";
            this.textBox3.Style = "ddo-char-set: 0; font-size: 9.75pt; font-family: Tahoma; ";
            this.textBox3.Text = "521";
            this.textBox3.Top = 0.8125F;
            this.textBox3.Width = 0.75F;
            // 
            // textBox4
            // 
            this.textBox4.Border.BottomColor = System.Drawing.Color.Black;
            this.textBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox4.Border.LeftColor = System.Drawing.Color.Black;
            this.textBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox4.Border.RightColor = System.Drawing.Color.Black;
            this.textBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox4.Border.TopColor = System.Drawing.Color.Black;
            this.textBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox4.DataField = "RequestedByFromLicense";
            this.textBox4.Height = 0.1875F;
            this.textBox4.Left = 1.229167F;
            this.textBox4.Name = "textBox4";
            this.textBox4.Style = "ddo-char-set: 0; text-decoration: none; text-align: center; font-size: 9.75pt; fo" +
                "nt-family: Tahoma; ";
            this.textBox4.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount;
            this.textBox4.Text = "##";
            this.textBox4.Top = 0F;
            this.textBox4.Width = 0.4375F;
            // 
            // label6
            // 
            this.label6.Border.BottomColor = System.Drawing.Color.Black;
            this.label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label6.Border.LeftColor = System.Drawing.Color.Black;
            this.label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label6.Border.RightColor = System.Drawing.Color.Black;
            this.label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label6.Border.TopColor = System.Drawing.Color.Black;
            this.label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label6.Height = 0.1875F;
            this.label6.HyperLink = "";
            this.label6.Left = 5.833333F;
            this.label6.Name = "label6";
            this.label6.Style = "ddo-char-set: 0; text-decoration: none; text-align: right; font-weight: bold; fon" +
                "t-size: 9.75pt; font-family: Tahoma; ";
            this.label6.Text = "Print Date:";
            this.label6.Top = 0F;
            this.label6.Width = 0.875F;
            // 
            // label7
            // 
            this.label7.Border.BottomColor = System.Drawing.Color.Black;
            this.label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label7.Border.LeftColor = System.Drawing.Color.Black;
            this.label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label7.Border.RightColor = System.Drawing.Color.Black;
            this.label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label7.Border.TopColor = System.Drawing.Color.Black;
            this.label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label7.Height = 0.1875F;
            this.label7.HyperLink = "";
            this.label7.Left = 0.9791666F;
            this.label7.Name = "label7";
            this.label7.Style = "text-decoration: none; ddo-char-set: 0; text-align: center; font-weight: normal; " +
                "font-size: 9.75pt; font-family: Tahoma; ";
            this.label7.Text = "of";
            this.label7.Top = 0F;
            this.label7.Width = 0.1875F;
            // 
            // textBox5
            // 
            this.textBox5.Border.BottomColor = System.Drawing.Color.Black;
            this.textBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox5.Border.LeftColor = System.Drawing.Color.Black;
            this.textBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox5.Border.RightColor = System.Drawing.Color.Black;
            this.textBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox5.Border.TopColor = System.Drawing.Color.Black;
            this.textBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox5.DataField = "RequestedByFromLicense";
            this.textBox5.Height = 0.1875F;
            this.textBox5.Left = 0.4895833F;
            this.textBox5.Name = "textBox5";
            this.textBox5.Style = "text-decoration: none; ddo-char-set: 0; text-align: center; font-size: 9.75pt; fo" +
                "nt-family: Tahoma; ";
            this.textBox5.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All;
            this.textBox5.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount;
            this.textBox5.Text = "#";
            this.textBox5.Top = 0F;
            this.textBox5.Width = 0.4375F;
            // 
            // label8
            // 
            this.label8.Border.BottomColor = System.Drawing.Color.Black;
            this.label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label8.Border.LeftColor = System.Drawing.Color.Black;
            this.label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label8.Border.RightColor = System.Drawing.Color.Black;
            this.label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label8.Border.TopColor = System.Drawing.Color.Black;
            this.label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label8.Height = 0.1875F;
            this.label8.HyperLink = "";
            this.label8.Left = 0F;
            this.label8.Name = "label8";
            this.label8.Style = "ddo-char-set: 0; text-decoration: none; text-align: right; font-weight: bold; fon" +
                "t-size: 9.75pt; font-family: Tahoma; ";
            this.label8.Text = "Page";
            this.label8.Top = 0F;
            this.label8.Width = 0.4375F;
            // 
            // CheckMaturityList
            // 
            oleDBDataSource1.ConnectionString = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial " +
                "Catalog=Spareparts;Data Source=(Local)";
            oleDBDataSource1.SQL = "Select * from tblYear";
            this.DataSource = oleDBDataSource1;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 8.895833F;
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
                        "l; font-size: 10pt; color: Black; ", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
                        "lic; ", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.Label label1;
        private DataDynamics.ActiveReports.Label label2;
        private DataDynamics.ActiveReports.TextBox textBox1;
        private DataDynamics.ActiveReports.TextBox textBox2;
        private DataDynamics.ActiveReports.Label label3;
        private DataDynamics.ActiveReports.Label label4;
        private DataDynamics.ActiveReports.Label label5;
        private DataDynamics.ActiveReports.TextBox textBox3;
        private DataDynamics.ActiveReports.TextBox textBox4;
        private DataDynamics.ActiveReports.Label label6;
        private DataDynamics.ActiveReports.Label label7;
        private DataDynamics.ActiveReports.TextBox textBox5;
        private DataDynamics.ActiveReports.Label label8;
    }
}
