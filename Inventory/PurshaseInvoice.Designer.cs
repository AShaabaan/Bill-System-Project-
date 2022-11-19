namespace Inventory
{
    partial class PurshaseInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurshaseInvoice));
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TotalProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SalesMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuccedLabel = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnBackToMain = new System.Windows.Forms.Button();
            this.Btn_Add_To_DGV = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SupplierLabel = new System.Windows.Forms.Label();
            this.productcombox = new System.Windows.Forms.ComboBox();
            this.suppliercombox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductPriceNm = new System.Windows.Forms.NumericUpDown();
            this.QuantityofProductNm = new System.Windows.Forms.NumericUpDown();
            this.SalesManLabel = new System.Windows.Forms.Label();
            this.salesManCombox = new System.Windows.Forms.ComboBox();
            this.R_D_Supplier = new System.Windows.Forms.RadioButton();
            this.R_D_SalesMan = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceNm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityofProductNm)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Delete.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Location = new System.Drawing.Point(347, 16);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(148, 45);
            this.Btn_Delete.TabIndex = 73;
            this.Btn_Delete.Text = "delete Product";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ProductName,
            this.col_ProductPrice,
            this.col_Quantity,
            this.col_TotalProductPrice,
            this.col_Supplier,
            this.col_SalesMan});
            this.dataGridView1.Location = new System.Drawing.Point(331, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(671, 366);
            this.dataGridView1.TabIndex = 69;
            // 
            // col_ProductName
            // 
            this.col_ProductName.HeaderText = "Product Name";
            this.col_ProductName.MinimumWidth = 6;
            this.col_ProductName.Name = "col_ProductName";
            this.col_ProductName.ReadOnly = true;
            this.col_ProductName.Width = 125;
            // 
            // col_ProductPrice
            // 
            this.col_ProductPrice.HeaderText = "Product Price";
            this.col_ProductPrice.MinimumWidth = 6;
            this.col_ProductPrice.Name = "col_ProductPrice";
            this.col_ProductPrice.ReadOnly = true;
            this.col_ProductPrice.Width = 125;
            // 
            // col_Quantity
            // 
            this.col_Quantity.HeaderText = "Quantity";
            this.col_Quantity.MinimumWidth = 6;
            this.col_Quantity.Name = "col_Quantity";
            this.col_Quantity.ReadOnly = true;
            this.col_Quantity.Width = 125;
            // 
            // col_TotalProductPrice
            // 
            this.col_TotalProductPrice.HeaderText = "Total";
            this.col_TotalProductPrice.MinimumWidth = 6;
            this.col_TotalProductPrice.Name = "col_TotalProductPrice";
            this.col_TotalProductPrice.ReadOnly = true;
            this.col_TotalProductPrice.Width = 125;
            // 
            // col_Supplier
            // 
            this.col_Supplier.HeaderText = "Supplier Name";
            this.col_Supplier.MinimumWidth = 6;
            this.col_Supplier.Name = "col_Supplier";
            this.col_Supplier.ReadOnly = true;
            this.col_Supplier.Width = 125;
            // 
            // col_SalesMan
            // 
            this.col_SalesMan.HeaderText = "salesMan";
            this.col_SalesMan.MinimumWidth = 6;
            this.col_SalesMan.Name = "col_SalesMan";
            this.col_SalesMan.ReadOnly = true;
            this.col_SalesMan.Width = 125;
            // 
            // SuccedLabel
            // 
            this.SuccedLabel.AutoSize = true;
            this.SuccedLabel.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SuccedLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccedLabel.ForeColor = System.Drawing.Color.Lime;
            this.SuccedLabel.Location = new System.Drawing.Point(391, 491);
            this.SuccedLabel.Name = "SuccedLabel";
            this.SuccedLabel.Size = new System.Drawing.Size(286, 22);
            this.SuccedLabel.TabIndex = 63;
            this.SuccedLabel.Text = "Purchase Invoice has been Created";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(822, 12);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(161, 50);
            this.BtnAdd.TabIndex = 62;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnBackToMain
            // 
            this.BtnBackToMain.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnBackToMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBackToMain.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackToMain.Location = new System.Drawing.Point(12, 15);
            this.BtnBackToMain.Name = "BtnBackToMain";
            this.BtnBackToMain.Size = new System.Drawing.Size(161, 47);
            this.BtnBackToMain.TabIndex = 60;
            this.BtnBackToMain.Text = "Main";
            this.BtnBackToMain.UseVisualStyleBackColor = false;
            this.BtnBackToMain.Click += new System.EventHandler(this.BtnBackToMain_Click);
            // 
            // Btn_Add_To_DGV
            // 
            this.Btn_Add_To_DGV.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Btn_Add_To_DGV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Add_To_DGV.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add_To_DGV.Location = new System.Drawing.Point(512, 16);
            this.Btn_Add_To_DGV.Name = "Btn_Add_To_DGV";
            this.Btn_Add_To_DGV.Size = new System.Drawing.Size(148, 45);
            this.Btn_Add_To_DGV.TabIndex = 80;
            this.Btn_Add_To_DGV.Text = "Add Product";
            this.Btn_Add_To_DGV.UseVisualStyleBackColor = false;
            this.Btn_Add_To_DGV.Click += new System.EventHandler(this.Btn_Add_To_DGV_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 38);
            this.label3.TabIndex = 64;
            this.label3.Text = "Product Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SupplierLabel
            // 
            this.SupplierLabel.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SupplierLabel.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SupplierLabel.Location = new System.Drawing.Point(12, 307);
            this.SupplierLabel.Name = "SupplierLabel";
            this.SupplierLabel.Size = new System.Drawing.Size(186, 38);
            this.SupplierLabel.TabIndex = 65;
            this.SupplierLabel.Text = "Supplier Name";
            this.SupplierLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productcombox
            // 
            this.productcombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productcombox.FormattingEnabled = true;
            this.productcombox.Location = new System.Drawing.Point(208, 217);
            this.productcombox.Name = "productcombox";
            this.productcombox.Size = new System.Drawing.Size(117, 24);
            this.productcombox.TabIndex = 67;
            // 
            // suppliercombox
            // 
            this.suppliercombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suppliercombox.FormattingEnabled = true;
            this.suppliercombox.Location = new System.Drawing.Point(208, 313);
            this.suppliercombox.Name = "suppliercombox";
            this.suppliercombox.Size = new System.Drawing.Size(117, 24);
            this.suppliercombox.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 38);
            this.label1.TabIndex = 72;
            this.label1.Text = "Product Quantity";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalprice
            // 
            this.txtTotalprice.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotalprice.Enabled = false;
            this.txtTotalprice.Location = new System.Drawing.Point(208, 420);
            this.txtTotalprice.Name = "txtTotalprice";
            this.txtTotalprice.Size = new System.Drawing.Size(117, 24);
            this.txtTotalprice.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Font = new System.Drawing.Font("SimSun-ExtB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 38);
            this.label4.TabIndex = 77;
            this.label4.Text = "Product Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductPriceNm
            // 
            this.ProductPriceNm.Location = new System.Drawing.Point(208, 160);
            this.ProductPriceNm.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ProductPriceNm.Name = "ProductPriceNm";
            this.ProductPriceNm.Size = new System.Drawing.Size(120, 24);
            this.ProductPriceNm.TabIndex = 78;
            // 
            // QuantityofProductNm
            // 
            this.QuantityofProductNm.Location = new System.Drawing.Point(208, 265);
            this.QuantityofProductNm.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.QuantityofProductNm.Name = "QuantityofProductNm";
            this.QuantityofProductNm.Size = new System.Drawing.Size(120, 24);
            this.QuantityofProductNm.TabIndex = 79;
            // 
            // SalesManLabel
            // 
            this.SalesManLabel.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SalesManLabel.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesManLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SalesManLabel.Location = new System.Drawing.Point(12, 359);
            this.SalesManLabel.Name = "SalesManLabel";
            this.SalesManLabel.Size = new System.Drawing.Size(186, 38);
            this.SalesManLabel.TabIndex = 81;
            this.SalesManLabel.Text = "SalesMan Name";
            this.SalesManLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salesManCombox
            // 
            this.salesManCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.salesManCombox.FormattingEnabled = true;
            this.salesManCombox.Location = new System.Drawing.Point(211, 365);
            this.salesManCombox.Name = "salesManCombox";
            this.salesManCombox.Size = new System.Drawing.Size(117, 24);
            this.salesManCombox.TabIndex = 82;
            // 
            // R_D_Supplier
            // 
            this.R_D_Supplier.AutoSize = true;
            this.R_D_Supplier.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_D_Supplier.Location = new System.Drawing.Point(96, 23);
            this.R_D_Supplier.Name = "R_D_Supplier";
            this.R_D_Supplier.Size = new System.Drawing.Size(80, 20);
            this.R_D_Supplier.TabIndex = 84;
            this.R_D_Supplier.TabStop = true;
            this.R_D_Supplier.Text = "Supplier";
            this.R_D_Supplier.UseVisualStyleBackColor = true;
            this.R_D_Supplier.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // R_D_SalesMan
            // 
            this.R_D_SalesMan.AutoSize = true;
            this.R_D_SalesMan.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_D_SalesMan.Location = new System.Drawing.Point(0, 23);
            this.R_D_SalesMan.Name = "R_D_SalesMan";
            this.R_D_SalesMan.Size = new System.Drawing.Size(89, 20);
            this.R_D_SalesMan.TabIndex = 83;
            this.R_D_SalesMan.TabStop = true;
            this.R_D_SalesMan.Text = "SalesMan";
            this.R_D_SalesMan.UseVisualStyleBackColor = true;
            this.R_D_SalesMan.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.R_D_SalesMan);
            this.groupBox1.Controls.Add(this.R_D_Supplier);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 62);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(14, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 38);
            this.label2.TabIndex = 85;
            this.label2.Text = "Total Price";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PurshaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1011, 532);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.salesManCombox);
            this.Controls.Add(this.SalesManLabel);
            this.Controls.Add(this.Btn_Add_To_DGV);
            this.Controls.Add(this.QuantityofProductNm);
            this.Controls.Add(this.ProductPriceNm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalprice);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.suppliercombox);
            this.Controls.Add(this.productcombox);
            this.Controls.Add(this.SupplierLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SuccedLabel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnBackToMain);
            this.DoubleBuffered = true;
            this.Name = "PurshaseInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurshaseInvoice";
            this.Load += new System.EventHandler(this.PurshaseInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceNm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityofProductNm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label SuccedLabel;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnBackToMain;
        private System.Windows.Forms.Button Btn_Add_To_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TotalProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SalesMan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SupplierLabel;
        private System.Windows.Forms.ComboBox productcombox;
        private System.Windows.Forms.ComboBox suppliercombox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ProductPriceNm;
        private System.Windows.Forms.NumericUpDown QuantityofProductNm;
        private System.Windows.Forms.Label SalesManLabel;
        private System.Windows.Forms.ComboBox salesManCombox;
        private System.Windows.Forms.RadioButton R_D_Supplier;
        private System.Windows.Forms.RadioButton R_D_SalesMan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}