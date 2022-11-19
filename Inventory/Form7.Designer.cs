namespace Inventory
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.SuccedLabel = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.SalesManLabel = new System.Windows.Forms.Label();
            this.BtnBackToMain = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.C_box_SalesManName = new System.Windows.Forms.ComboBox();
            this.C_box_ProductName = new System.Windows.Forms.ComboBox();
            this.C_box_CustomerName = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Col_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_box_ProductQuantity = new System.Windows.Forms.ComboBox();
            this.R_D_SalesMan = new System.Windows.Forms.RadioButton();
            this.R_D_Customer = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtTotalprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SuccedLabel
            // 
            this.SuccedLabel.AutoSize = true;
            this.SuccedLabel.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SuccedLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccedLabel.ForeColor = System.Drawing.Color.Lime;
            this.SuccedLabel.Location = new System.Drawing.Point(395, 501);
            this.SuccedLabel.Name = "SuccedLabel";
            this.SuccedLabel.Size = new System.Drawing.Size(210, 22);
            this.SuccedLabel.TabIndex = 36;
            this.SuccedLabel.Text = "Invoice has been Created";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(825, 22);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(161, 47);
            this.BtnAdd.TabIndex = 35;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // SalesManLabel
            // 
            this.SalesManLabel.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SalesManLabel.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesManLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SalesManLabel.Location = new System.Drawing.Point(12, 259);
            this.SalesManLabel.Name = "SalesManLabel";
            this.SalesManLabel.Size = new System.Drawing.Size(186, 47);
            this.SalesManLabel.TabIndex = 33;
            this.SalesManLabel.Text = "SalesMan Name";
            this.SalesManLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnBackToMain
            // 
            this.BtnBackToMain.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnBackToMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBackToMain.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackToMain.Location = new System.Drawing.Point(16, 22);
            this.BtnBackToMain.Name = "BtnBackToMain";
            this.BtnBackToMain.Size = new System.Drawing.Size(161, 47);
            this.BtnBackToMain.TabIndex = 32;
            this.BtnBackToMain.Text = "Main";
            this.BtnBackToMain.UseVisualStyleBackColor = false;
            this.BtnBackToMain.Click += new System.EventHandler(this.BtnBackToMain_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 43);
            this.label3.TabIndex = 38;
            this.label3.Text = "Product Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CustomerLabel.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomerLabel.Location = new System.Drawing.Point(12, 363);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(186, 43);
            this.CustomerLabel.TabIndex = 40;
            this.CustomerLabel.Text = "Customer Name";
            this.CustomerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // C_box_SalesManName
            // 
            this.C_box_SalesManName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.C_box_SalesManName.FormattingEnabled = true;
            this.C_box_SalesManName.Location = new System.Drawing.Point(212, 275);
            this.C_box_SalesManName.Name = "C_box_SalesManName";
            this.C_box_SalesManName.Size = new System.Drawing.Size(117, 24);
            this.C_box_SalesManName.TabIndex = 46;
            // 
            // C_box_ProductName
            // 
            this.C_box_ProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.C_box_ProductName.FormattingEnabled = true;
            this.C_box_ProductName.Location = new System.Drawing.Point(212, 330);
            this.C_box_ProductName.Name = "C_box_ProductName";
            this.C_box_ProductName.Size = new System.Drawing.Size(117, 24);
            this.C_box_ProductName.TabIndex = 47;
            this.C_box_ProductName.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // C_box_CustomerName
            // 
            this.C_box_CustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.C_box_CustomerName.FormattingEnabled = true;
            this.C_box_CustomerName.Location = new System.Drawing.Point(212, 377);
            this.C_box_CustomerName.Name = "C_box_CustomerName";
            this.C_box_CustomerName.Size = new System.Drawing.Size(117, 24);
            this.C_box_CustomerName.TabIndex = 48;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_ProductName,
            this.Col_ProductPrice,
            this.Col_Quantity,
            this.Col_TotalPrice});
            this.dataGridView1.Location = new System.Drawing.Point(335, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(671, 368);
            this.dataGridView1.TabIndex = 49;
            // 
            // Col_ProductName
            // 
            this.Col_ProductName.HeaderText = "Product Name";
            this.Col_ProductName.MinimumWidth = 6;
            this.Col_ProductName.Name = "Col_ProductName";
            this.Col_ProductName.ReadOnly = true;
            this.Col_ProductName.Width = 125;
            // 
            // Col_ProductPrice
            // 
            this.Col_ProductPrice.HeaderText = "Product Price";
            this.Col_ProductPrice.MinimumWidth = 6;
            this.Col_ProductPrice.Name = "Col_ProductPrice";
            this.Col_ProductPrice.ReadOnly = true;
            this.Col_ProductPrice.Width = 125;
            // 
            // Col_Quantity
            // 
            this.Col_Quantity.HeaderText = "Quantity";
            this.Col_Quantity.MinimumWidth = 6;
            this.Col_Quantity.Name = "Col_Quantity";
            this.Col_Quantity.ReadOnly = true;
            this.Col_Quantity.Width = 125;
            // 
            // Col_TotalPrice
            // 
            this.Col_TotalPrice.HeaderText = "Total Price";
            this.Col_TotalPrice.MinimumWidth = 6;
            this.Col_TotalPrice.Name = "Col_TotalPrice";
            this.Col_TotalPrice.ReadOnly = true;
            this.Col_TotalPrice.Width = 125;
            // 
            // C_box_ProductQuantity
            // 
            this.C_box_ProductQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.C_box_ProductQuantity.FormattingEnabled = true;
            this.C_box_ProductQuantity.Location = new System.Drawing.Point(212, 425);
            this.C_box_ProductQuantity.Name = "C_box_ProductQuantity";
            this.C_box_ProductQuantity.Size = new System.Drawing.Size(117, 24);
            this.C_box_ProductQuantity.TabIndex = 50;
            this.C_box_ProductQuantity.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // R_D_SalesMan
            // 
            this.R_D_SalesMan.AutoSize = true;
            this.R_D_SalesMan.Location = new System.Drawing.Point(33, 23);
            this.R_D_SalesMan.Name = "R_D_SalesMan";
            this.R_D_SalesMan.Size = new System.Drawing.Size(84, 21);
            this.R_D_SalesMan.TabIndex = 51;
            this.R_D_SalesMan.TabStop = true;
            this.R_D_SalesMan.Text = "SalesMan";
            this.R_D_SalesMan.UseVisualStyleBackColor = true;
            this.R_D_SalesMan.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // R_D_Customer
            // 
            this.R_D_Customer.AutoSize = true;
            this.R_D_Customer.Location = new System.Drawing.Point(196, 23);
            this.R_D_Customer.Name = "R_D_Customer";
            this.R_D_Customer.Size = new System.Drawing.Size(89, 21);
            this.R_D_Customer.TabIndex = 52;
            this.R_D_Customer.TabStop = true;
            this.R_D_Customer.Text = "Customer";
            this.R_D_Customer.UseVisualStyleBackColor = true;
            this.R_D_Customer.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.R_D_SalesMan);
            this.groupBox1.Controls.Add(this.R_D_Customer);
            this.groupBox1.Location = new System.Drawing.Point(16, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 65);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 41);
            this.label1.TabIndex = 54;
            this.label1.Text = "Product Quantity";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(16, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 47);
            this.button3.TabIndex = 57;
            this.button3.Text = "delete Product";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtTotalprice
            // 
            this.txtTotalprice.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotalprice.Enabled = false;
            this.txtTotalprice.Location = new System.Drawing.Point(212, 474);
            this.txtTotalprice.Name = "txtTotalprice";
            this.txtTotalprice.Size = new System.Drawing.Size(117, 24);
            this.txtTotalprice.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 38);
            this.label2.TabIndex = 86;
            this.label2.Text = "Total Price";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1011, 532);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalprice);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.C_box_ProductQuantity);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.C_box_CustomerName);
            this.Controls.Add(this.C_box_ProductName);
            this.Controls.Add(this.C_box_SalesManName);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SuccedLabel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.SalesManLabel);
            this.Controls.Add(this.BtnBackToMain);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoise";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SuccedLabel;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label SalesManLabel;
        private System.Windows.Forms.Button BtnBackToMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.ComboBox C_box_SalesManName;
        private System.Windows.Forms.ComboBox C_box_ProductName;
        private System.Windows.Forms.ComboBox C_box_CustomerName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox C_box_ProductQuantity;
        private System.Windows.Forms.RadioButton R_D_SalesMan;
        private System.Windows.Forms.RadioButton R_D_Customer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtTotalprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_TotalPrice;
    }
}