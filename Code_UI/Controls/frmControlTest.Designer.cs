namespace Pharma
{
    partial class frmControlTest   
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectItem1 = new Pharma.Code_UI.Controls.SelectItem.SelectItem();
            this.SuspendLayout();
            // 
            // selectItem1
            // 
            this.selectItem1.FormToPopup = null;
            this.selectItem1.Location = new System.Drawing.Point(18, 70);
            this.selectItem1.Name = "selectItem1";
            this.selectItem1.Size = new System.Drawing.Size(320, 24);
            this.selectItem1.TabIndex = 0;
            this.selectItem1.Load += new System.EventHandler(this.selectItem1_Load);
            this.selectItem1.BeforePopup += new System.EventHandler(this.selectItem1_BeforePopup);
            // 
            // frmControlTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 355);
            this.Controls.Add(this.selectItem1);
            this.Name = "frmControlTest";
            this.Text = "frmControlTest";
            this.Load += new System.EventHandler(this.frmControlTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Pharma.Code_UI.Controls.SelectItem.SelectItem selectItem1;


    }
}