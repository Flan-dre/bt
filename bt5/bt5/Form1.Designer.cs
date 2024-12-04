namespace bt5
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThem_Click = new System.Windows.Forms.Button();
            this.btnSua_Click = new System.Windows.Forms.Button();
            this.btnXoa_Click = new System.Windows.Forms.Button();
            this.btnDong_Click = new System.Windows.Forms.Button();
            this.MSNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSNV,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(486, 261);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnThem_Click
            // 
            this.btnThem_Click.Location = new System.Drawing.Point(568, 25);
            this.btnThem_Click.Name = "btnThem_Click";
            this.btnThem_Click.Size = new System.Drawing.Size(75, 23);
            this.btnThem_Click.TabIndex = 1;
            this.btnThem_Click.Text = "Them";
            this.btnThem_Click.UseVisualStyleBackColor = true;
            this.btnThem_Click.Click += new System.EventHandler(this.btnThem_Click_Click);
            // 
            // btnSua_Click
            // 
            this.btnSua_Click.Location = new System.Drawing.Point(568, 100);
            this.btnSua_Click.Name = "btnSua_Click";
            this.btnSua_Click.Size = new System.Drawing.Size(75, 23);
            this.btnSua_Click.TabIndex = 2;
            this.btnSua_Click.Text = "Sua";
            this.btnSua_Click.UseVisualStyleBackColor = true;
            this.btnSua_Click.Click += new System.EventHandler(this.btnSua_Click_Click);
            // 
            // btnXoa_Click
            // 
            this.btnXoa_Click.Location = new System.Drawing.Point(568, 177);
            this.btnXoa_Click.Name = "btnXoa_Click";
            this.btnXoa_Click.Size = new System.Drawing.Size(75, 23);
            this.btnXoa_Click.TabIndex = 3;
            this.btnXoa_Click.Text = "Xoa";
            this.btnXoa_Click.UseVisualStyleBackColor = true;
            this.btnXoa_Click.Click += new System.EventHandler(this.btnXoa_Click_Click);
            // 
            // btnDong_Click
            // 
            this.btnDong_Click.Location = new System.Drawing.Point(568, 250);
            this.btnDong_Click.Name = "btnDong_Click";
            this.btnDong_Click.Size = new System.Drawing.Size(75, 23);
            this.btnDong_Click.TabIndex = 4;
            this.btnDong_Click.Text = "Dong";
            this.btnDong_Click.UseVisualStyleBackColor = true;
            this.btnDong_Click.Click += new System.EventHandler(this.btnDong_Click_Click);
            // 
            // MSNV
            // 
            this.MSNV.HeaderText = "MSNV";
            this.MSNV.MinimumWidth = 6;
            this.MSNV.Name = "MSNV";
            this.MSNV.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ten NV";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Luong CB";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDong_Click);
            this.Controls.Add(this.btnXoa_Click);
            this.Controls.Add(this.btnSua_Click);
            this.Controls.Add(this.btnThem_Click);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThem_Click;
        private System.Windows.Forms.Button btnSua_Click;
        private System.Windows.Forms.Button btnXoa_Click;
        private System.Windows.Forms.Button btnDong_Click;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

