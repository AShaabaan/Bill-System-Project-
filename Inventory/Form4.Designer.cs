namespace Inventory
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.SuccedLabel = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCategory = new System.Windows.Forms.Button();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SuccedLabel
            // 
            this.SuccedLabel.AutoSize = true;
            this.SuccedLabel.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SuccedLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccedLabel.ForeColor = System.Drawing.Color.Lime;
            this.SuccedLabel.Location = new System.Drawing.Point(387, 471);
            this.SuccedLabel.Name = "SuccedLabel";
            this.SuccedLabel.Size = new System.Drawing.Size(216, 22);
            this.SuccedLabel.TabIndex = 26;
            this.SuccedLabel.Text = "Customer has been added";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(803, 51);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(161, 47);
            this.BtnAdd.TabIndex = 25;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtCustomerName.Location = new System.Drawing.Point(552, 153);
            this.txtCustomerName.MaxLength = 50;
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(230, 47);
            this.txtCustomerName.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(221, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 47);
            this.label1.TabIndex = 23;
            this.label1.Text = "Customer Name ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCategory
            // 
            this.BtnCategory.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCategory.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCategory.Location = new System.Drawing.Point(31, 49);
            this.BtnCategory.Name = "BtnCategory";
            this.BtnCategory.Size = new System.Drawing.Size(161, 47);
            this.BtnCategory.TabIndex = 22;
            this.BtnCategory.Text = "Main";
            this.BtnCategory.UseVisualStyleBackColor = false;
            this.BtnCategory.Click += new System.EventHandler(this.BtnCategory_Click);
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtCustomerPhone.Location = new System.Drawing.Point(552, 229);
            this.txtCustomerPhone.MaxLength = 11;
            this.txtCustomerPhone.Multiline = true;
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(230, 47);
            this.txtCustomerPhone.TabIndex = 28;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtCustomerAddress.Location = new System.Drawing.Point(552, 299);
            this.txtCustomerAddress.MaxLength = 150;
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(230, 47);
            this.txtCustomerAddress.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(221, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 47);
            this.label3.TabIndex = 31;
            this.label3.Text = "Customer Phone";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(221, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 47);
            this.label4.TabIndex = 32;
            this.label4.Text = "Address";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 532);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.SuccedLabel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCategory);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SuccedLabel;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCategory;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}