namespace bt5
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
            this.txtMSNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtLuongCB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDongY_Click = new System.Windows.Forms.Button();
            this.btnBoQua_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMSNV
            // 
            this.txtMSNV.Location = new System.Drawing.Point(196, 55);
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.Size = new System.Drawing.Size(155, 22);
            this.txtMSNV.TabIndex = 0;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(196, 150);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(155, 22);
            this.txtTenNV.TabIndex = 1;
            // 
            // txtLuongCB
            // 
            this.txtLuongCB.Location = new System.Drawing.Point(196, 266);
            this.txtLuongCB.Name = "txtLuongCB";
            this.txtLuongCB.Size = new System.Drawing.Size(155, 22);
            this.txtLuongCB.TabIndex = 2;
            this.txtLuongCB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "MSNV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "TenNV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "LuongCB";
            // 
            // btnDongY_Click
            // 
            this.btnDongY_Click.Location = new System.Drawing.Point(196, 363);
            this.btnDongY_Click.Name = "btnDongY_Click";
            this.btnDongY_Click.Size = new System.Drawing.Size(75, 23);
            this.btnDongY_Click.TabIndex = 6;
            this.btnDongY_Click.Text = "Dong Y";
            this.btnDongY_Click.UseVisualStyleBackColor = true;
            this.btnDongY_Click.Click += new System.EventHandler(this.btnDongY_Click_Click);
            // 
            // btnBoQua_Click
            // 
            this.btnBoQua_Click.Location = new System.Drawing.Point(401, 363);
            this.btnBoQua_Click.Name = "btnBoQua_Click";
            this.btnBoQua_Click.Size = new System.Drawing.Size(75, 23);
            this.btnBoQua_Click.TabIndex = 7;
            this.btnBoQua_Click.Text = "Bo qua";
            this.btnBoQua_Click.UseVisualStyleBackColor = true;
            this.btnBoQua_Click.Click += new System.EventHandler(this.btnBoQua_Click_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBoQua_Click);
            this.Controls.Add(this.btnDongY_Click);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLuongCB);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtMSNV);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMSNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtLuongCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDongY_Click;
        private System.Windows.Forms.Button btnBoQua_Click;
    }
}