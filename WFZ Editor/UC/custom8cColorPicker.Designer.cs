namespace WFZ_Editor.UC
{
    partial class custom8cColorPicker
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
            this.txtColor = new System.Windows.Forms.Label();
            this.btColor = new System.Windows.Forms.Button();
            this.dialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // txtColor
            // 
            this.txtColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtColor.Location = new System.Drawing.Point(25, 1);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(54, 17);
            this.txtColor.TabIndex = 0;
            this.txtColor.Text = "#000000";
            this.txtColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btColor
            // 
            this.btColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btColor.BackColor = System.Drawing.Color.Black;
            this.btColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btColor.ForeColor = System.Drawing.Color.Black;
            this.btColor.Location = new System.Drawing.Point(0, 0);
            this.btColor.Name = "btColor";
            this.btColor.Size = new System.Drawing.Size(24, 18);
            this.btColor.TabIndex = 2;
            this.btColor.Text = "...";
            this.btColor.UseVisualStyleBackColor = false;
            this.btColor.Click += new System.EventHandler(this.btColor_Click);
            // 
            // dialog
            // 
            this.dialog.FullOpen = true;
            this.dialog.SolidColorOnly = true;
            // 
            // customColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btColor);
            this.Controls.Add(this.txtColor);
            this.Name = "customColorPicker";
            this.Size = new System.Drawing.Size(82, 18);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtColor;
        private System.Windows.Forms.Button btColor;
        private System.Windows.Forms.ColorDialog dialog;
    }
}
