namespace Inventory
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.SuccedLabel = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.txtSuppllierName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCategory = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpplierAddress = new System.Windows.Forms.TextBox();
            this.txtSuppllierPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SuccedLabel
            // 
            this.SuccedLabel.AutoSize = true;
            this.SuccedLabel.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SuccedLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccedLabel.ForeColor = System.Drawing.Color.Lime;
            this.SuccedLabel.Location = new System.Drawing.Point(383, 475);
            this.SuccedLabel.Name = "SuccedLabel";
            this.SuccedLabel.Size = new System.Drawing.Size(204, 22);
            this.SuccedLabel.TabIndex = 21;
            this.SuccedLabel.Text = "Supplier has been added";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(829, 25);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(135, 50);
            this.BtnAdd.TabIndex = 20;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtSuppllierName
            // 
            this.txtSuppllierName.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtSuppllierName.Location = new System.Drawing.Point(545, 152);
            this.txtSuppllierName.MaxLength = 50;
            this.txtSuppllierName.Multiline = true;
            this.txtSuppllierName.Name = "txtSuppllierName";
            this.txtSuppllierName.Size = new System.Drawing.Size(230, 47);
            this.txtSuppllierName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(221, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 47);
            this.label1.TabIndex = 18;
            this.label1.Text = "Supplier Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCategory
            // 
            this.BtnCategory.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCategory.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCategory.Location = new System.Drawing.Point(43, 28);
            this.BtnCategory.Name = "BtnCategory";
            this.BtnCategory.Size = new System.Drawing.Size(161, 47);
            this.BtnCategory.TabIndex = 17;
            this.BtnCategory.Text = "Main";
            this.BtnCategory.UseVisualStyleBackColor = false;
            this.BtnCategory.Click += new System.EventHandler(this.BtnCategory_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(214, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 47);
            this.label4.TabIndex = 36;
            this.label4.Text = "Address";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(214, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 47);
            this.label3.TabIndex = 35;
            this.label3.Text = "Supplier Phone";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSpplierAddress
            // 
            this.txtSpplierAddress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtSpplierAddress.Location = new System.Drawing.Point(545, 298);
            this.txtSpplierAddress.MaxLength = 150;
            this.txtSpplierAddress.Multiline = true;
            this.txtSpplierAddress.Name = "txtSpplierAddress";
            this.txtSpplierAddress.Size = new System.Drawing.Size(230, 47);
            this.txtSpplierAddress.TabIndex = 34;
            // 
            // txtSuppllierPhone
            // 
            this.txtSuppllierPhone.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtSuppllierPhone.Location = new System.Drawing.Point(545, 228);
            this.txtSuppllierPhone.MaxLength = 11;
            this.txtSuppllierPhone.Multiline = true;
            this.txtSuppllierPhone.Name = "txtSuppllierPhone";
            this.txtSuppllierPhone.Size = new System.Drawing.Size(230, 47);
            this.txtSuppllierPhone.TabIndex = 33;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 532);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSpplierAddress);
            this.Controls.Add(this.txtSuppllierPhone);
            this.Controls.Add(this.SuccedLabel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.txtSuppllierName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCategory);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SuccedLabel;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox txtSuppllierName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpplierAddress;
        private System.Windows.Forms.TextBox txtSuppllierPhone;
    }
}