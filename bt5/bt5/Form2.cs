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
    public partial class Form2 : Form
    {
        public string MSNV { get; private set; }
        public string TenNV { get; private set; }
        public string LuongCB { get; private set; }

        public Form2(string msnv = "", string tenNV = "", string luongCB = "")
        {
            InitializeComponent();

            txtMSNV.Text = msnv;
            txtTenNV.Text = tenNV;
            txtLuongCB.Text = luongCB;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click_Click(object sender, EventArgs e)
        {
            MSNV = txtMSNV.Text;
            TenNV = txtTenNV.Text;
            LuongCB = txtLuongCB.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnBoQua_Click_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
