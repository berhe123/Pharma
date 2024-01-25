namespace Pharma.Code_UI.Report_Designers
{
    /// <summary>
    /// Summary description for NewActiveReport1.
    /// </summary>
    partial class NewActiveReport1
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(NewActiveReport1));
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            this.groupHeader1 = new DataDynamics.ActiveReports.GroupHeader();
            this.groupFooter1 = new DataDynamics.ActiveReports.GroupFooter();
            this.label1 = new DataDynamics.ActiveReports.Label();
            this.label2 = new DataDynamics.ActiveReports.Label();
            this.label3 = new DataDynamics.ActiveReports.Label();
            this.textBox1 = new DataDynamics.ActiveReports.TextBox();
            this.line1 = new DataDynamics.ActiveReports.Line();
            this.groupHeader2 = new DataDynamics.ActiveReports.GroupHeader();
            this.groupFooter2 = new DataDynamics.ActiveReports.GroupFooter();
            this.textBox2 = new DataDynamics.ActiveReports.TextBox();
            this.line2 = new DataDynamics.ActiveReports.Line();
            this.textBox3 = new DataDynamics.ActiveReports.TextBox();
            this.line3 = new DataDynamics.ActiveReports.Line();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Height = 0.6354167F;
            this.pageHeader.Name = "pageHeader";
            // 
            // detail
            // 
            this.detail.ColumnSpacing = 0F;
            this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.textBox1,
            this.line1,
            this.textBox2,
            this.line2,
            this.textBox3});
            this.detail.Height = 0.3645833F;
            this.detail.Name = "detail";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = 0.25F;
            this.pageFooter.Name = "pageFooter";
            // 
            // groupHeader1
            // 
            this.groupHeader1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.label1,
            this.label2,
            this.label3});
            this.groupHeader1.Height = 0.5F;
            this.groupHeader1.Name = "groupHeader1";
            this.groupHeader1.Format += new System.EventHandler(this.groupHeader1_Format);
            // 
            // groupFooter1
            // 
            this.groupFooter1.Height = 0.25F;
            this.groupFooter1.Name = "groupFooter1";
            // 
            // label1
            // 
            this.label1.Border.BottomColor = System.Drawing.Color.Black;
            this.label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label1.Border.LeftColor = System.Drawing.Color.Black;
            this.label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label1.Border.RightColor = System.Drawing.Color.Black;
            this.label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label1.Border.TopColor = System.Drawing.Color.Black;
            this.label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label1.Height = 0.1875F;
            this.label1.HyperLink = null;
            this.label1.Left = 0.125F;
            this.label1.Name = "label1";
            this.label1.Style = "background-color: LightGrey; ";
            this.label1.Text = "S.No";
            this.label1.Top = 0.3125F;
            this.label1.Width = 0.5625F;
            // 
            // label2
            // 
            this.label2.Border.BottomColor = System.Drawing.Color.Black;
            this.label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label2.Border.LeftColor = System.Drawing.Color.Black;
            this.label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label2.Border.RightColor = System.Drawing.Color.Black;
            this.label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label2.Border.TopColor = System.Drawing.Color.Black;
            this.label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label2.Height = 0.1875F;
            this.label2.HyperLink = "";
            this.label2.Left = 0.6875F;
            this.label2.Name = "label2";
            this.label2.Style = "background-color: LightGrey; ";
            this.label2.Text = "label1";
            this.label2.Top = 0.3125F;
            this.label2.Width = 1.375F;
            // 
            // label3
            // 
            this.label3.Border.BottomColor = System.Drawing.Color.Black;
            this.label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label3.Border.LeftColor = System.Drawing.Color.Black;
            this.label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label3.Border.RightColor = System.Drawing.Color.Black;
            this.label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label3.Border.TopColor = System.Drawing.Color.Black;
            this.label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label3.Height = 0.1979167F;
            this.label3.HyperLink = "";
            this.label3.Left = 2.0625F;
            this.label3.Name = "label3";
            this.label3.Style = "background-color: LightGrey; ";
            this.label3.Text = "label1";
            this.label3.Top = 0.3125F;
            this.label3.Width = 1F;
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
            this.textBox1.Left = 0.125F;
            this.textBox1.Name = "textBox1";
            this.textBox1.Style = "";
            this.textBox1.Text = "textBox1";
            this.textBox1.Top = 0.125F;
            this.textBox1.Width = 0.5F;
            // 
            // line1
            // 
            this.line1.Border.BottomColor = System.Drawing.Color.Black;
            this.line1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line1.Border.LeftColor = System.Drawing.Color.Black;
            this.line1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line1.Border.RightColor = System.Drawing.Color.Black;
            this.line1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line1.Border.TopColor = System.Drawing.Color.Black;
            this.line1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line1.Height = 0.3125F;
            this.line1.Left = 0.6875F;
            this.line1.LineWeight = 1F;
            this.line1.Name = "line1";
            this.line1.Top = 0F;
            this.line1.Width = 0F;
            this.line1.X1 = 0.6875F;
            this.line1.X2 = 0.6875F;
            this.line1.Y1 = 0.3125F;
            this.line1.Y2 = 0F;
            // 
            // groupHeader2
            // 
            this.groupHeader2.Height = 0F;
            this.groupHeader2.Name = "groupHeader2";
            // 
            // groupFooter2
            // 
            this.groupFooter2.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.line3});
            this.groupFooter2.Height = 0.28125F;
            this.groupFooter2.Name = "groupFooter2";
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
            this.textBox2.Left = 0.75F;
            this.textBox2.Name = "textBox2";
            this.textBox2.Style = "";
            this.textBox2.Text = "textBox1";
            this.textBox2.Top = 0F;
            this.textBox2.Width = 1.25F;
            // 
            // line2
            // 
            this.line2.Border.BottomColor = System.Drawing.Color.Black;
            this.line2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line2.Border.LeftColor = System.Drawing.Color.Black;
            this.line2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line2.Border.RightColor = System.Drawing.Color.Black;
            this.line2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line2.Border.TopColor = System.Drawing.Color.Black;
            this.line2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line2.Height = 0.3125F;
            this.line2.Left = 2.0625F;
            this.line2.LineWeight = 1F;
            this.line2.Name = "line2";
            this.line2.Top = 0F;
            this.line2.Width = 0F;
            this.line2.X1 = 2.0625F;
            this.line2.X2 = 2.0625F;
            this.line2.Y1 = 0.3125F;
            this.line2.Y2 = 0F;
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
            this.textBox3.Left = 2.125F;
            this.textBox3.Name = "textBox3";
            this.textBox3.Style = "";
            this.textBox3.Text = "textBox1";
            this.textBox3.Top = 0F;
            this.textBox3.Width = 1F;
            // 
            // line3
            // 
            this.line3.Border.BottomColor = System.Drawing.Color.Black;
            this.line3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line3.Border.LeftColor = System.Drawing.Color.Black;
            this.line3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line3.Border.RightColor = System.Drawing.Color.Black;
            this.line3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line3.Border.TopColor = System.Drawing.Color.Black;
            this.line3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line3.Height = 0F;
            this.line3.Left = 0.125F;
            this.line3.LineWeight = 1F;
            this.line3.Name = "line3";
            this.line3.Top = 0.0625F;
            this.line3.Width = 3F;
            this.line3.X1 = 0.125F;
            this.line3.X2 = 3.125F;
            this.line3.Y1 = 0.0625F;
            this.line3.Y2 = 0.0625F;
            // 
            // NewActiveReport1
            // 
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.groupHeader1);
            this.Sections.Add(this.groupHeader2);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.groupFooter2);
            this.Sections.Add(this.groupFooter1);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
                        "l; font-size: 10pt; color: Black; ", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
                        "lic; ", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.TextBox textBox1;
        private DataDynamics.ActiveReports.GroupHeader groupHeader1;
        private DataDynamics.ActiveReports.Label label1;
        private DataDynamics.ActiveReports.Label label2;
        private DataDynamics.ActiveReports.Label label3;
        private DataDynamics.ActiveReports.GroupFooter groupFooter1;
        private DataDynamics.ActiveReports.Line line1;
        private DataDynamics.ActiveReports.GroupHeader groupHeader2;
        private DataDynamics.ActiveReports.GroupFooter groupFooter2;
        private DataDynamics.ActiveReports.TextBox textBox2;
        private DataDynamics.ActiveReports.Line line2;
        private DataDynamics.ActiveReports.TextBox textBox3;
        private DataDynamics.ActiveReports.Line line3;
    }
}
