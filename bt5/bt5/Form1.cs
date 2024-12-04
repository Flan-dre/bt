using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Khởi tạo DataGridView với dữ liệu mẫu
            dataGridView1.Rows.Add("NV001", "Nguyễn Thị Thu Hiền", "8500000");
        }

        private void btnThem_Click_Click(object sender, EventArgs e)
        {
            Form2 employeeForm = new Form2();
            if (employeeForm.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add(employeeForm.MSNV, employeeForm.TenNV, employeeForm.LuongCB);
            }
        }

        private void btnSua_Click_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                Form2 employeeForm = new Form2(
                    row.Cells[0].Value.ToString(),
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString()
                );

                if (employeeForm.ShowDialog() == DialogResult.OK)
                {
                    row.Cells[0].Value = employeeForm.MSNV;
                    row.Cells[1].Value = employeeForm.TenNV;
                    row.Cells[2].Value = employeeForm.LuongCB;
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn một nhân viên để sửa.");
            }
        }

        private void btnXoa_Click_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Hãy chọn một nhân viên để xóa.");
            }
        }

        private void btnDong_Click_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
