namespace Inventory
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.SuccedLabel = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCategory = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.N_U_D_ProductCount = new System.Windows.Forms.NumericUpDown();
            this.N_U_D_ProductPrice = new System.Windows.Forms.NumericUpDown();
            this.categoryCombox = new System.Windows.Forms.ComboBox();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.C_Box_Upt_Product = new System.Windows.Forms.ComboBox();
            this.Update_Label = new System.Windows.Forms.Label();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Delete_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.N_U_D_ProductCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_U_D_ProductPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // SuccedLabel
            // 
            this.SuccedLabel.AutoSize = true;
            this.SuccedLabel.BackColor = System.Drawing.Color.SandyBrown;
            this.SuccedLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccedLabel.ForeColor = System.Drawing.Color.Lime;
            this.SuccedLabel.Location = new System.Drawing.Point(522, 465);
            this.SuccedLabel.Name = "SuccedLabel";
            this.SuccedLabel.Size = new System.Drawing.Size(201, 22);
            this.SuccedLabel.TabIndex = 31;
            this.SuccedLabel.Text = "Product has been added";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(279, 42);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(161, 47);
            this.BtnAdd.TabIndex = 30;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtProductName.Location = new System.Drawing.Point(208, 290);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(232, 41);
            this.txtProductName.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(522, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 41);
            this.label1.TabIndex = 28;
            this.label1.Text = "Product Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCategory
            // 
            this.BtnCategory.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCategory.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCategory.Location = new System.Drawing.Point(41, 40);
            this.BtnCategory.Name = "BtnCategory";
            this.BtnCategory.Size = new System.Drawing.Size(161, 47);
            this.BtnCategory.TabIndex = 27;
            this.BtnCategory.Text = "Main";
            this.BtnCategory.UseVisualStyleBackColor = false;
            this.BtnCategory.Click += new System.EventHandler(this.BtnCategory_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(522, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 44);
            this.label4.TabIndex = 44;
            this.label4.Text = "Category";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(522, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 40);
            this.label3.TabIndex = 43;
            this.label3.Text = "Price";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(522, 389);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 40);
            this.label2.TabIndex = 42;
            this.label2.Text = "Count";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // N_U_D_ProductCount
            // 
            this.N_U_D_ProductCount.BackColor = System.Drawing.SystemColors.MenuBar;
            this.N_U_D_ProductCount.Location = new System.Drawing.Point(206, 403);
            this.N_U_D_ProductCount.Margin = new System.Windows.Forms.Padding(4);
            this.N_U_D_ProductCount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.N_U_D_ProductCount.Name = "N_U_D_ProductCount";
            this.N_U_D_ProductCount.Size = new System.Drawing.Size(231, 24);
            this.N_U_D_ProductCount.TabIndex = 41;
            // 
            // N_U_D_ProductPrice
            // 
            this.N_U_D_ProductPrice.BackColor = System.Drawing.SystemColors.MenuBar;
            this.N_U_D_ProductPrice.Location = new System.Drawing.Point(206, 350);
            this.N_U_D_ProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.N_U_D_ProductPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.N_U_D_ProductPrice.Name = "N_U_D_ProductPrice";
            this.N_U_D_ProductPrice.Size = new System.Drawing.Size(231, 24);
            this.N_U_D_ProductPrice.TabIndex = 40;
            // 
            // categoryCombox
            // 
            this.categoryCombox.BackColor = System.Drawing.SystemColors.Info;
            this.categoryCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCombox.FormattingEnabled = true;
            this.categoryCombox.Location = new System.Drawing.Point(206, 233);
            this.categoryCombox.Margin = new System.Windows.Forms.Padding(4);
            this.categoryCombox.Name = "categoryCombox";
            this.categoryCombox.Size = new System.Drawing.Size(230, 24);
            this.categoryCombox.TabIndex = 39;
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.LightSalmon;
            this.Btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Update.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.Location = new System.Drawing.Point(526, 42);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(161, 47);
            this.Btn_Update.TabIndex = 45;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // C_Box_Upt_Product
            // 
            this.C_Box_Upt_Product.BackColor = System.Drawing.SystemColors.Info;
            this.C_Box_Upt_Product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.C_Box_Upt_Product.FormattingEnabled = true;
            this.C_Box_Upt_Product.Location = new System.Drawing.Point(208, 178);
            this.C_Box_Upt_Product.Margin = new System.Windows.Forms.Padding(4);
            this.C_Box_Upt_Product.Name = "C_Box_Upt_Product";
            this.C_Box_Upt_Product.Size = new System.Drawing.Size(232, 24);
            this.C_Box_Upt_Product.TabIndex = 46;
            this.C_Box_Upt_Product.SelectedIndexChanged += new System.EventHandler(this.C_Box_Upt_Product_SelectedIndexChanged);
            // 
            // Update_Label
            // 
            this.Update_Label.AutoSize = true;
            this.Update_Label.BackColor = System.Drawing.Color.SandyBrown;
            this.Update_Label.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Label.ForeColor = System.Drawing.Color.Lime;
            this.Update_Label.Location = new System.Drawing.Point(204, 465);
            this.Update_Label.Name = "Update_Label";
            this.Update_Label.Size = new System.Drawing.Size(219, 22);
            this.Update_Label.TabIndex = 47;
            this.Update_Label.Text = "Product has been Updated";
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.LightSalmon;
            this.Btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Delete.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Location = new System.Drawing.Point(790, 42);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(161, 47);
            this.Btn_Delete.TabIndex = 48;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightSalmon;
            this.label6.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(526, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 40);
            this.label6.TabIndex = 49;
            this.label6.Text = "Select Product";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Delete_Label
            // 
            this.Delete_Label.AutoSize = true;
            this.Delete_Label.BackColor = System.Drawing.Color.SandyBrown;
            this.Delete_Label.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Label.ForeColor = System.Drawing.Color.Lime;
            this.Delete_Label.Location = new System.Drawing.Point(363, 501);
            this.Delete_Label.Name = "Delete_Label";
            this.Delete_Label.Size = new System.Drawing.Size(212, 22);
            this.Delete_Label.TabIndex = 50;
            this.Delete_Label.Text = "Product has been Deleted";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 532);
            this.ControlBox = false;
            this.Controls.Add(this.Delete_Label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Update_Label);
            this.Controls.Add(this.C_Box_Upt_Product);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.N_U_D_ProductCount);
            this.Controls.Add(this.N_U_D_ProductPrice);
            this.Controls.Add(this.categoryCombox);
            this.Controls.Add(this.SuccedLabel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCategory);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.N_U_D_ProductCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_U_D_ProductPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SuccedLabel;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown N_U_D_ProductCount;
        private System.Windows.Forms.NumericUpDown N_U_D_ProductPrice;
        private System.Windows.Forms.ComboBox categoryCombox;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.ComboBox C_Box_Upt_Product;
        private System.Windows.Forms.Label Update_Label;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Delete_Label;
    }
}