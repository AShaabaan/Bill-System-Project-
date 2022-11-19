namespace Inventory
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.SuccedLabel = new System.Windows.Forms.Label();
            this.BtnCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox1.Location = new System.Drawing.Point(495, 397);
            this.textBox1.MaxLength = 50;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 47);
            this.textBox1.TabIndex = 13;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(818, 31);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(134, 50);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // SuccedLabel
            // 
            this.SuccedLabel.AutoSize = true;
            this.SuccedLabel.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SuccedLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccedLabel.ForeColor = System.Drawing.Color.Lime;
            this.SuccedLabel.Location = new System.Drawing.Point(419, 490);
            this.SuccedLabel.Name = "SuccedLabel";
            this.SuccedLabel.Size = new System.Drawing.Size(208, 22);
            this.SuccedLabel.TabIndex = 16;
            this.SuccedLabel.Text = "category has been added";
            // 
            // BtnCategory
            // 
            this.BtnCategory.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCategory.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCategory.Location = new System.Drawing.Point(31, 29);
            this.BtnCategory.Name = "BtnCategory";
            this.BtnCategory.Size = new System.Drawing.Size(161, 47);
            this.BtnCategory.TabIndex = 6;
            this.BtnCategory.Text = "Main";
            this.BtnCategory.UseVisualStyleBackColor = false;
            this.BtnCategory.Click += new System.EventHandler(this.BtnCategory_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(203, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 47);
            this.label1.TabIndex = 12;
            this.label1.Text = "Category Name ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 532);
            this.ControlBox = false;
            this.Controls.Add(this.SuccedLabel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCategory);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label SuccedLabel;
        private System.Windows.Forms.Button BtnCategory;
        private System.Windows.Forms.Label label1;
    }
}