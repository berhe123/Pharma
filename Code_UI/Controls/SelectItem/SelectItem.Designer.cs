namespace Pharma.Code_UI.Controls.SelectItem
{
    partial class SelectItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpSelectItem = new System.Windows.Forms.TableLayoutPanel();
            this.txtSelectedItem = new System.Windows.Forms.TextBox();
            this.btnPopupSelectionDialog = new System.Windows.Forms.Button();
            this.tlpSelectItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpSelectItem
            // 
            this.tlpSelectItem.BackColor = System.Drawing.Color.White;
            this.tlpSelectItem.ColumnCount = 2;
            this.tlpSelectItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSelectItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpSelectItem.Controls.Add(this.txtSelectedItem, 0, 0);
            this.tlpSelectItem.Controls.Add(this.btnPopupSelectionDialog, 1, 0);
            this.tlpSelectItem.Location = new System.Drawing.Point(1, 1);
            this.tlpSelectItem.Name = "tlpSelectItem";
            this.tlpSelectItem.RowCount = 1;
            this.tlpSelectItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSelectItem.Size = new System.Drawing.Size(188, 23);
            this.tlpSelectItem.TabIndex = 0;
            // 
            // txtSelectedItem
            // 
            this.txtSelectedItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSelectedItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSelectedItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedItem.Location = new System.Drawing.Point(3, 4);
            this.txtSelectedItem.Margin = new System.Windows.Forms.Padding(3, 4, 0, 0);
            this.txtSelectedItem.MaxLength = 0;
            this.txtSelectedItem.Name = "txtSelectedItem";
            this.txtSelectedItem.Size = new System.Drawing.Size(154, 16);
            this.txtSelectedItem.TabIndex = 4;
            this.txtSelectedItem.TabStop = false;
            this.txtSelectedItem.Text = "2009";
            // 
            // btnPopupSelectionDialog
            // 
            this.btnPopupSelectionDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPopupSelectionDialog.BackColor = System.Drawing.Color.White;
            this.btnPopupSelectionDialog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPopupSelectionDialog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.btnPopupSelectionDialog.FlatAppearance.BorderSize = 0;
            this.btnPopupSelectionDialog.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPopupSelectionDialog.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPopupSelectionDialog.Location = new System.Drawing.Point(159, 2);
            this.btnPopupSelectionDialog.Margin = new System.Windows.Forms.Padding(0, 2, 1, 0);
            this.btnPopupSelectionDialog.Name = "btnPopupSelectionDialog";
            this.btnPopupSelectionDialog.Size = new System.Drawing.Size(28, 20);
            this.btnPopupSelectionDialog.TabIndex = 2;
            this.btnPopupSelectionDialog.TabStop = false;
            this.btnPopupSelectionDialog.Text = "...";
            this.btnPopupSelectionDialog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPopupSelectionDialog.UseVisualStyleBackColor = true;
            this.btnPopupSelectionDialog.Click += new System.EventHandler(this.btnPopupSelectionDialog_Click);
            // 
            // SelectItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpSelectItem);
            this.Name = "SelectItem";
            this.Size = new System.Drawing.Size(188, 23);
            this.Resize += new System.EventHandler(this.SelectItem_Resize);
            this.tlpSelectItem.ResumeLayout(false);
            this.tlpSelectItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSelectItem;
        private System.Windows.Forms.Button btnPopupSelectionDialog;
        private System.Windows.Forms.TextBox txtSelectedItem;
    }
}
