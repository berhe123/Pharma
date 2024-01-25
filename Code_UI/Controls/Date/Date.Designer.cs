namespace Pharma
{
    partial class Date
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
            this.tlpDate = new System.Windows.Forms.TableLayoutPanel();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.lblMonthYearSeparator = new System.Windows.Forms.Label();
            this.lblDayMonthSeparator = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.UpDownDate = new System.Windows.Forms.NumericUpDown();
            this.btnPopupCalendar = new System.Windows.Forms.Button();
            this.tlpDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDate)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpDate
            // 
            this.tlpDate.BackColor = System.Drawing.Color.White;
            this.tlpDate.ColumnCount = 7;
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpDate.Controls.Add(this.txtDay, 0, 0);
            this.tlpDate.Controls.Add(this.txtMonth, 2, 0);
            this.tlpDate.Controls.Add(this.lblMonthYearSeparator, 3, 0);
            this.tlpDate.Controls.Add(this.lblDayMonthSeparator, 1, 0);
            this.tlpDate.Controls.Add(this.txtYear, 4, 0);
            this.tlpDate.Controls.Add(this.UpDownDate, 5, 0);
            this.tlpDate.Controls.Add(this.btnPopupCalendar, 6, 0);
            this.tlpDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpDate.Location = new System.Drawing.Point(1, 1);
            this.tlpDate.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDate.Name = "tlpDate";
            this.tlpDate.RowCount = 1;
            this.tlpDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDate.Size = new System.Drawing.Size(155, 21);
            this.tlpDate.TabIndex = 0;
            this.tlpDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tlpDate_MouseClick);
            // 
            // txtDay
            // 
            this.txtDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDay.Location = new System.Drawing.Point(0, 2);
            this.txtDay.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.txtDay.MaxLength = 2;
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(22, 16);
            this.txtDay.TabIndex = 1;
            this.txtDay.Text = "1";
            this.txtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDay.TextChanged += new System.EventHandler(this.txtDay_TextChanged);
            // 
            // txtMonth
            // 
            this.txtMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonth.Location = new System.Drawing.Point(32, 2);
            this.txtMonth.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.txtMonth.MaxLength = 2;
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(22, 16);
            this.txtMonth.TabIndex = 6;
            this.txtMonth.TabStop = false;
            this.txtMonth.Text = "1";
            this.txtMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMonth.TextChanged += new System.EventHandler(this.txtMonth_TextChanged);
            // 
            // lblMonthYearSeparator
            // 
            this.lblMonthYearSeparator.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthYearSeparator.Location = new System.Drawing.Point(54, 2);
            this.lblMonthYearSeparator.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lblMonthYearSeparator.Name = "lblMonthYearSeparator";
            this.lblMonthYearSeparator.Size = new System.Drawing.Size(10, 16);
            this.lblMonthYearSeparator.TabIndex = 8;
            this.lblMonthYearSeparator.Text = "/";
            // 
            // lblDayMonthSeparator
            // 
            this.lblDayMonthSeparator.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayMonthSeparator.Location = new System.Drawing.Point(22, 2);
            this.lblDayMonthSeparator.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lblDayMonthSeparator.Name = "lblDayMonthSeparator";
            this.lblDayMonthSeparator.Size = new System.Drawing.Size(10, 16);
            this.lblDayMonthSeparator.TabIndex = 7;
            this.lblDayMonthSeparator.Text = "/";
            // 
            // txtYear
            // 
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYear.Location = new System.Drawing.Point(64, 2);
            this.txtYear.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(44, 16);
            this.txtYear.TabIndex = 3;
            this.txtYear.TabStop = false;
            this.txtYear.Text = "2009";
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // UpDownDate
            // 
            this.UpDownDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UpDownDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.UpDownDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDownDate.Location = new System.Drawing.Point(108, 1);
            this.UpDownDate.Margin = new System.Windows.Forms.Padding(0, 1, 1, 0);
            this.UpDownDate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownDate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.UpDownDate.Name = "UpDownDate";
            this.UpDownDate.Size = new System.Drawing.Size(15, 18);
            this.UpDownDate.TabIndex = 1;
            this.UpDownDate.TabStop = false;
            this.UpDownDate.BackColorChanged += new System.EventHandler(this.UpDownDate_BackColorChanged);
            this.UpDownDate.ValueChanged += new System.EventHandler(this.UpDownDate_ValueChanged);
            // 
            // btnPopupCalendar
            // 
            this.btnPopupCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPopupCalendar.BackColor = System.Drawing.Color.White;
            this.btnPopupCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPopupCalendar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.btnPopupCalendar.FlatAppearance.BorderSize = 0;
            this.btnPopupCalendar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPopupCalendar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPopupCalendar.Location = new System.Drawing.Point(126, 0);
            this.btnPopupCalendar.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btnPopupCalendar.Name = "btnPopupCalendar";
            this.btnPopupCalendar.Size = new System.Drawing.Size(28, 20);
            this.btnPopupCalendar.TabIndex = 1;
            this.btnPopupCalendar.TabStop = false;
            this.btnPopupCalendar.Text = "...";
            this.btnPopupCalendar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPopupCalendar.UseVisualStyleBackColor = true;
            this.btnPopupCalendar.Click += new System.EventHandler(this.btnPopupCalendar_Click);
            // 
            // Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.tlpDate);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Date";
            this.Size = new System.Drawing.Size(157, 23);
            this.Load += new System.EventHandler(this.Date_Load);
            this.FontChanged += new System.EventHandler(this.Date_FontChanged);
            this.Resize += new System.EventHandler(this.Date_Resize);
            this.Enter += new System.EventHandler(this.Date_Enter);
            this.tlpDate.ResumeLayout(false);
            this.tlpDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDate;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label lblDayMonthSeparator;
        private System.Windows.Forms.Label lblMonthYearSeparator;
        private System.Windows.Forms.Button btnPopupCalendar;
        private System.Windows.Forms.NumericUpDown UpDownDate;
    }
}
