﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManages
{
    public partial class frmInfoAcc : Form
    {
        public frmInfoAcc()
        {
            InitializeComponent();
        }
        private void frmInfoAcc_Load(object sender, EventArgs e)
        {

        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.ShowDialog();
        }
        private void KhachhangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachhang f = new frmKhachhang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInfoAcc f = new frmInfoAcc();
            this.Hide();
            f.ShowDialog();
        }

        private void SalesManage_Load(object sender, EventArgs e)
        {

        }

        private void quênMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmForgetPass f = new frmForgetPass();
            this.Hide();
            f.ShowDialog();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SanphamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanpham f = new frmSanpham();
            this.Hide();
            f.ShowDialog();
        }

        private void NhanvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanvien f = new frmNhanvien();
            this.Hide();
            f.ShowDialog();
        }
    }
}