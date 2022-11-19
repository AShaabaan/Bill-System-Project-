namespace Inventory
{
    partial class All_Invoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(All_Invoices));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnReport = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.dp_startDate = new System.Windows.Forms.DateTimePicker();
            this.dp_endDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(167, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(684, 344);
            this.dataGridView1.TabIndex = 1;
            // 
            // BtnReport
            // 
            this.BtnReport.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnReport.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.Location = new System.Drawing.Point(759, 35);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(240, 47);
            this.BtnReport.TabIndex = 8;
            this.BtnReport.Text = "Back To Reports";
            this.BtnReport.UseVisualStyleBackColor = false;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSearch.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(408, 35);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(240, 47);
            this.BtnSearch.TabIndex = 9;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dp_startDate
            // 
            this.dp_startDate.Location = new System.Drawing.Point(247, 118);
            this.dp_startDate.Name = "dp_startDate";
            this.dp_startDate.Size = new System.Drawing.Size(221, 24);
            this.dp_startDate.TabIndex = 10;
            // 
            // dp_endDate
            // 
            this.dp_endDate.CalendarFont = new System.Drawing.Font("Tahoma", 10F);
            this.dp_endDate.Location = new System.Drawing.Point(534, 118);
            this.dp_endDate.Name = "dp_endDate";
            this.dp_endDate.Size = new System.Drawing.Size(233, 24);
            this.dp_endDate.TabIndex = 11;
            // 
            // All_Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 532);
            this.ControlBox = false;
            this.Controls.Add(this.dp_endDate);
            this.Controls.Add(this.dp_startDate);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnReport);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "All_Invoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All_Invoices";
            this.Load += new System.EventHandler(this.All_Invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DateTimePicker dp_startDate;
        private System.Windows.Forms.DateTimePicker dp_endDate;
    }
}