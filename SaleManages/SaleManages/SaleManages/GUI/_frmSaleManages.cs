﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaleManages.DAO;
using SaleManages.GUI;
using SaleManages.DTO;
using System.Resources;
using System.Globalization;
using System.Threading;

namespace SaleManages.GUI
{
    public partial class _frmSalesManage : Form
    {
        string checklang;
        CultureInfo culture;
        public _frmSalesManage()
        {
            InitializeComponent();
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmLogin"];
            checklang = ((_frmLogin)f).lbTitle.Text;
            culture = CultureInfo.CurrentCulture;
            if (checklang == "Đăng Nhập") SetLanguage("vi-VN");
            else SetLanguage("en-US");
        }

        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("SaleManages.Resources.MyResource", typeof(_frmLogin).Assembly);
            btnAdd.LabelText = rm.GetString("them", culture);
            btnEra.LabelText = rm.GetString("xoa", culture);
            btnFix.LabelText = rm.GetString("sua", culture);
            btnView.LabelText = rm.GetString("xem", culture);
            btnFind.LabelText = rm.GetString("tim", culture);
            metroTabPage1.Text = rm.GetString("khachhang", culture);
            metroTabPage2.Text = rm.GetString("nhanvien", culture);
            metroTabPage3.Text = rm.GetString("sanpham", culture);
            lbNameKh.Text = rm.GetString("hoten", culture);
            lbNameNh.Text = rm.GetString("hoten", culture);
            lbCodeKh.Text = rm.GetString("maso", culture);
            lbCodeNh.Text = rm.GetString("maso", culture);
            lbBirth.Text = rm.GetString("ngaysinh", culture);
            lbBirthNv.Text = rm.GetString("ngaysinh", culture);
            lbAddKh.Text = rm.GetString("diachi", culture);
            lbAddNv.Text = rm.GetString("diachi", culture);
            lbPhone.Text = rm.GetString("sdt", culture);
            lbPhoneNv.Text = rm.GetString("sdt", culture);
            lbBeginday.Text = rm.GetString("ngayvaolam", culture);
            lbSex.Text = rm.GetString("gioitinh", culture);
            label1.Text = rm.GetString("gioitinh", culture);
            rbNam.Text = rm.GetString("nam", culture);
            rbNu.Text = rm.GetString("nu", culture);
            rbElse.Text = rm.GetString("khac", culture);
            rbNamNV.Text = rm.GetString("nam", culture);
            rbNuNV.Text = rm.GetString("nu", culture);
            rbKhacNV.Text = rm.GetString("khac", culture);
            lbMucdo.Text = rm.GetString("mucdo", culture);
            label2.Text = rm.GetString("mucdo", culture);
            backToolStripMenuItem.Text = rm.GetString("hethong", culture);
            windowToolStripMenuItem.Text = rm.GetString("thongtin", culture);
            tàiKhoảnToolStripMenuItem.Text = rm.GetString("taikhoan", culture);
            tùyChọnToolStripMenuItem.Text = rm.GetString("tuychon", culture);
            ngônNgữToolStripMenuItem.Text = rm.GetString("ngonngu", culture);
            tiếngViệtToolStripMenuItem.Text = rm.GetString("tiengviet", culture);
            tiếngAnhToolStripMenuItem.Text = rm.GetString("tienganh", culture);
            thôngTinỨngDụngToolStripMenuItem.Text = rm.GetString("thongtinungdung", culture);
            lbNameSp.Text = rm.GetString("tensp", culture);
            lbCodeSp.Text = rm.GetString("masp", culture);
            lbDateSp.Text = rm.GetString("nsx", culture);
            lbHsdSp.Text = rm.GetString("hsd", culture);
            lbNcc.Text = rm.GetString("ncc", culture);
            lbPrice.Text = rm.GetString("giathanh", culture);
            lbDonvi.Text = rm.GetString("donvi", culture);
            lbSaleoff.Text = rm.GetString("ctkm", culture);
            xuấtHóaĐơnToolStripMenuItem.Text = rm.GetString("hoadon", culture);
            inToolStripMenuItem.Text = rm.GetString("in", culture);
            điềuKhoảnToolStripMenuItem.Text = rm.GetString("dieukhoan", culture);
            đăngXuấtToolStripMenuItem.Text = rm.GetString("btnLogout", culture);
            thôngTinToolStripMenuItem.Text = rm.GetString("btnInfo", culture);
            đổiMậtKhẩuToolStripMenuItem.Text = rm.GetString("idoimatkhau", culture);
            doanhThuToolStripMenuItem.Text = rm.GetString("ibieudo", culture);
            phêDuyệtToolStripMenuItem.Text = rm.GetString("ipheduyet", culture);
            metroTabPage4.Text = rm.GetString("hoadon", culture);
            label3.Text = rm.GetString("sohd", culture);
            label4.Text = rm.GetString("ngayhd", culture);
            label5.Text = rm.GetString("makh", culture);
            label6.Text = rm.GetString("manv", culture);
            label9.Text = rm.GetString("giatri", culture);
            bunifuFlatButton1.Text = rm.GetString("xemthem", culture);
            dtgvHoadon.Columns[0].HeaderText = rm.GetString("dtgvsohd", culture);
            dtgvHoadon.Columns[1].HeaderText = rm.GetString("dtgvmakh", culture);
            dtgvHoadon.Columns[2].HeaderText = rm.GetString("dtgvmanv", culture);
            dtgvHoadon.Columns[3].HeaderText = rm.GetString("dtgvngayhd", culture);
            dtgvHoadon.Columns[4].HeaderText = rm.GetString("dtgvgiahd", culture);
            dtgvKhachhang.Columns[0].HeaderText = rm.GetString("dtgvmakh", culture);
            dtgvKhachhang.Columns[1].HeaderText = rm.GetString("dtgvhoten", culture);
            dtgvKhachhang.Columns[2].HeaderText = rm.GetString("dtgvdiachi", culture);
            dtgvKhachhang.Columns[3].HeaderText = rm.GetString("dtgvsdt", culture);
            dtgvKhachhang.Columns[4].HeaderText = rm.GetString("dtgvngaysinh", culture);
            dtgvKhachhang.Columns[5].HeaderText = rm.GetString("dtgvngaydk", culture);
            dtgvKhachhang.Columns[6].HeaderText = rm.GetString("dtgvgioitinh", culture);
            dtgvKhachhang.Columns[8].HeaderText = rm.GetString("dtgvmucdo", culture);
            dtgvNhanvien.Columns[0].HeaderText = rm.GetString("dtgvmanv", culture);
            dtgvNhanvien.Columns[1].HeaderText = rm.GetString("dtgvhoten", culture);
            dtgvNhanvien.Columns[3].HeaderText = rm.GetString("dtgvdiachi", culture);
            dtgvNhanvien.Columns[2].HeaderText = rm.GetString("dtgvsdt", culture);
            dtgvNhanvien.Columns[4].HeaderText = rm.GetString("dtgvngaysinh", culture);
            dtgvNhanvien.Columns[5].HeaderText = rm.GetString("dtgvngayvl", culture);
            dtgvNhanvien.Columns[6].HeaderText = rm.GetString("dtgvgioitinh", culture);
            dtgvNhanvien.Columns[8].HeaderText = rm.GetString("dtgvmucdo", culture);
            dtgvSanpham.Columns[0].HeaderText = rm.GetString("dtgvmasp", culture);
            dtgvSanpham.Columns[1].HeaderText = rm.GetString("dtgvtensp", culture);
            dtgvSanpham.Columns[2].HeaderText = rm.GetString("dtgvdonvi", culture);
            dtgvSanpham.Columns[3].HeaderText = rm.GetString("dtgvnsx", culture);
            dtgvSanpham.Columns[4].HeaderText = rm.GetString("dtgvhsd", culture);
            dtgvSanpham.Columns[5].HeaderText = rm.GetString("dtgvncc", culture);
            dtgvSanpham.Columns[6].HeaderText = rm.GetString("dtgvgia", culture);
            dtgvSanpham.Columns[7].HeaderText = rm.GetString("dtgvctkm", culture);
            this.Text = rm.GetString("formSale", culture);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            int rs = CheckTabPage();
            if (rs == 0)
            {
                ValidateChildren(ValidationConstraints.Enabled);

                if (!string.IsNullOrEmpty(tbNameKh.Text))
                    if (!string.IsNullOrEmpty(tbCodeKh.Text))
                        if (!string.IsNullOrEmpty(tbAddKh.Text))
                            if (!string.IsNullOrEmpty(tbEmailKh.Text))
                                if (!string.IsNullOrEmpty(tbPhone.Text))
                                {
                                    ObjCustomerDAO.Instance.Add();
                                    
                                }

            }
            else if (rs == 1)
            {
                ValidateChildren(ValidationConstraints.Enabled);

                if (!string.IsNullOrEmpty(tbNameNv.Text))
                    if (!string.IsNullOrEmpty(tbCodeNv.Text))
                        if (!string.IsNullOrEmpty(dateNv.Text))
                            if (!string.IsNullOrEmpty(tbEmailNv.Text))
                                if (!string.IsNullOrEmpty(tbAddNv.Text))
                                    if (!string.IsNullOrEmpty(tbPhoneNv.Text))
                                    { ObjEmployeesDAO.Instance.Add();
                                        
                                    }

            }
            else if (rs == 2)
            {
                ValidateChildren(ValidationConstraints.Enabled);

                if (!string.IsNullOrEmpty(tbNameSp.Text))
                    if (!string.IsNullOrEmpty(tbCodeSp.Text))
                        if (!string.IsNullOrEmpty(tbDateSp.Text))
                            if (!string.IsNullOrEmpty(tbNcc.Text))
                                if (!string.IsNullOrEmpty(tbPrice.Text))
                                    if (!string.IsNullOrEmpty(tbDonvi.Text))
                                    {
                                        ObjProductDAO.Instance.Add();
                                       
                                    }

            }
            else if(rs ==3)
            {
                ValidateChildren(ValidationConstraints.Enabled);

                if (!string.IsNullOrEmpty(tbCodeHD.Text))
                    if (!string.IsNullOrEmpty(tbCodeKH_HD.Text))
                        if (!string.IsNullOrEmpty(tbCodeNV_HD.Text))
                        {
                            ObjBillDAO.Instance.Add();
                            
                        }

            }
        }
        int CheckTabPage()
        {
            
            return metroTabControl1.SelectedIndex;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int check = CheckTabPage();
            if (check == 0)
            {

                dtgvKhachhang.DataSource = ObjCustomerDAO.Instance.LoadCustomerData();
                ObjCustomerDAO.Instance.Bindings();
                
            }
            else if (check == 1)
            {

                dtgvNhanvien.DataSource = ObjEmployeesDAO.Instance.LoadEmployeesData();
                ObjEmployeesDAO.Instance.Bindings();
            }
            else if (check == 2)
            {
                dtgvSanpham.DataSource = ObjProductDAO.Instance.LoadProductData();
                ObjProductDAO.Instance.Bindings();

            }
            else if (check == 3)
            {
                dtgvHoadon.DataSource = ObjBillDAO.Instance.LoadBillData();
                ObjBillDAO.Instance.Bindings();
            }
        }

        private void dtgvKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvKhachhang.Rows.Count > 1)
            {
                ObjCustomerDAO.Instance.Bindings();
            }
        }

        private void btnEra_Click(object sender, EventArgs e)
        {
            int check = CheckTabPage();
            if (check == 0)
            {
                ObjCustomerDAO.Instance.Delete();
            }
            else if (check == 1)
            {
                ObjEmployeesDAO.Instance.Delete();
            }
            else if (check == 2)
            {
                ObjProductDAO.Instance.Delete();
            }
            else if (check == 3)
            {
                ObjBillDAO.Instance.Delete();
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            int check = CheckTabPage();
            if (check == 0)
            {
                ObjCustomerDAO.Instance.Update();
            }
            else if (check == 1)
            {
                ObjEmployeesDAO.Instance.Update();
            }
            else if (check == 2)
            {
                ObjProductDAO.Instance.Update();
            }
            else if(check == 3)
            {
                ObjBillDAO.Instance.Update();
            }
        }

        private void lbSex_Click(object sender, EventArgs e)
        {

        }

        private void lbMucdo_Click(object sender, EventArgs e)
        {

        }

        private void dtgvNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvNhanvien.Rows.Count > 1)
            {
                ObjEmployeesDAO.Instance.Bindings();
            }
        }

        private void _frmSalesManage_Load(object sender, EventArgs e)
        {
            //metroTabControl1.SelectedIndex = 0;
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmInfoAcc f = new _frmInfoAcc();

            f.ShowDialog();

        }

        private void điềuKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmUseTerm f = new _frmUseTerm();
            f.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmChangePass f = new _frmChangePass();
            f.ShowDialog();
        }

        private void tbNameSp_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNameSp.Text))
            {
                e.Cancel = true;
                if (checklang == "Đăng Nhập")
                    epTenSanPham.SetError(tbNameSp, "Vui lòng điền tên sản phẩm!");
                else
                    epTenSanPham.SetError(tbNameSp, "Please enter the product name!");
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
                epTenSanPham.SetError(tbNameSp, null);
            }
        }

        private void tbCodeSp_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbCodeSp.Text))
            {
                e.Cancel = true;
                if (checklang == "Đăng Nhập")
                    epMaSanPham.SetError(tbCodeSp, "Vui lòng điền mã sản phẩm!");
                else
                    epMaSanPham.SetError(tbCodeSp, "Please enter the product code!");
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
                epMaSanPham.SetError(tbCodeSp, null);
            }
        }

        private void tbDateSp_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbDateSp.Text))
            {
                e.Cancel = true;
                if (checklang == "Đăng Nhập")
                    epNSX.SetError(tbDateSp, "NSX phải nhỏ hơn HSD!");
                else
                    epNSX.SetError(tbDateSp, "NSX must be smaller than EXP!");
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
                epNSX.SetError(tbDateSp, null);
            }
        }

        private void tbNcc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNcc.Text))
            {
                e.Cancel = true;
                if (checklang == "Đăng Nhập")
                    epNCC.SetError(tbNcc, "Vui lòng điền tên NCC!");
                else
                    epNCC.SetError(tbNcc, "Please enter name!");
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
                epNCC.SetError(tbNcc, null);
            }
        }

        private void tbPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPrice.Text))
            {
                e.Cancel = true;
                if (checklang == "Đăng Nhập")
                    epPrice.SetError(tbPrice, "Vui lòng điền giá thành!");
                else
                    epPrice.SetError(tbPrice, "Please enter the price!");
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
                epPrice.SetError(tbPrice, null);
            }
        }

        private void tbDonvi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbDonvi.Text))
            {
                e.Cancel = true;
                if (checklang == "Đăng Nhập")
                    epDonVi.SetError(tbDonvi, "Vui lòng điền đơn vị!");
                else
                    epDonVi.SetError(tbDonvi, "Please enter unit!");
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
                epDonVi.SetError(tbDonvi, null);
            }

        }

        private void tiếngViệtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetLanguage("vi-VN");
        }

        private void tiếngAnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetLanguage("en-US");
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _frmLogin frmLogin = new _frmLogin();
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmLogin"];
            if (lbNameKh.Text == "Họ Tên:")
                ((_frmLogin)f).lbTitle.Text = "Đăng Nhập";
            else ((_frmLogin)f).lbTitle.Text = "Login";
            frmLogin.Show();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int check = CheckTabPage();
            if (check == 0)
            {
                _frmFindCustomerData f = new _frmFindCustomerData();
                f.ShowDialog();
            }
            else if (check == 1)
            {
                _frmFindEmployeesData f = new _frmFindEmployeesData();
                f.ShowDialog();
            }
            else if (check == 2)
            {
                _frmFindProductData f = new _frmFindProductData();
                f.ShowDialog();
            }
            else
            {
                _frmFindBillData f = new _frmFindBillData();
                f.ShowDialog();
            }
        }

        

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            _frmListBill f = new _frmListBill();
            f.Show();
        }

        

        private void tbNameNv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNameNv.Text))
            {
                e.Cancel = true;
                if (checklang == "Đăng Nhập")
                    epNVName.SetError(tbNameNv, "Vui lòng điền họ tên nhân viên!");
                else
                    epNVName.SetError(tbNameNv, "Please enter employee's full name!");
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
                epNVName.SetError(tbNameNv, null);
            }
        }

        private void tbCodeNv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbCodeNv.Text))
            {
                e.Cancel = true;
                if (checklang == "Đăng Nhập")
                    epNVCode.SetError(tbCodeNv, "Vui lòng điền mã số nhân viên!");
                else
                    epNVCode.SetError(tbCodeNv, "Please enter the employee code!");
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
                epNVCode.SetError(tbCodeNv, null);
            }
        }

        private void dateNv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dateNv.Text))
            {
                e.Cancel = true;
                if (checklang == "Đăng Nhập")
                    epNVBirth.SetError(dateNv, "Ngày sinh phải trước ngày vào làm!");
                else
                    epNVBirth.SetError(dateNv, "Date of birth must be before the day to work!");
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
                epNVBirth.SetError(dateNv, null);
            }
        }

        private void tbAddNv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbAddNv.Text))
            {
                e.Cancel = true;
                if (checklang == "Đăng Nhập")
                    epNVDiaChi.SetError(tbAddNv, "Vui lòng điền địa chỉ nhân viên!");
                else
                    epNVDiaChi.SetError(tbAddNv, "Please enter staff address!");
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
                epNVDiaChi.SetError(tbAddNv, null);
            }
        }

        private void tbEmailNv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmailNv.Text))
            {
                e.Cancel = true;
                if (checklang == "Đăng Nhập")
                    epNVEmail.SetError(tbEmailNv, "Vui lòng điền email nhân viên!");
                else
                    epNVEmail.SetError(tbEmailNv, "Please enter staff email!");
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
                epNVEmail.SetError(tbEmailNv, null);
            }
        }

        private void tbPhoneNv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPhoneNv.Text))
            {
                e.Cancel = true;
                if (checklang == "Đăng Nhập")
                    epNVSDT.SetError(tbPhoneNv, "Vui lòng điền sđt nhân viên!");
                else
                    epNVSDT.SetError(tbPhoneNv, "Please enter the employee number!");
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
                epNVSDT.SetError(tbPhoneNv, null);
            }
        }

        private void tbNameKh_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNameKh.Text))
            {
                e.Cancel = true;
                if (checklang == "Đăng Nhập")
                    epKHName.SetError(tbNameKh, "Vui lòng điền họ tên khách hàng!");
                else
                    epKHName.SetError(tbNameKh, "Please enter customer name!");
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
                epKHName.SetError(tbNameKh, null);
            }
        }

        private void tbCodeKh_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbCodeKh.Text))
            {
                e.Cancel = true;
                if (checklang == "Đăng Nhập")
                    epKHCode.SetError(tbCodeKh, "Vui lòng điền mã số khách hàng!");
                else
                    epKHCode.SetError(tbCodeKh, "Please enter customer code!");
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
                epKHCode.SetError(tbCodeKh, null);
            }
        }

        private void tbAddKh_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbAddKh.Text))
            {
                e.Cancel = true;
                if (checklang == "Đăng Nhập")
                    epKHAdd.SetError(tbAddKh, "Vui lòng điền địa chỉ khách hàng!");
                else
                    epKHAdd.SetError(tbAddKh, "Please enter customer address!");
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
                epKHAdd.SetError(tbAddKh, null);
            }
        }

        private void tbEmailKh_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmailKh.Text))
            {
                e.Cancel = true;
                if (checklang == "Đăng Nhập")
                    epKHEmail.SetError(tbEmailKh, "Vui lòng điền email khách hàng!");
                else
                    epKHEmail.SetError(tbEmailKh, "Please enter customer email!");
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
                epKHEmail.SetError(tbEmailKh, null); 
            }
            
        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPhone.Text))
            {
                e.Cancel = true;
                if (checklang == "Đăng Nhập")
                    epKHSdt.SetError(tbPhone, "Vui lòng điền sđt khách hàng!");
                else
                    epKHSdt.SetError(tbPhone, "Please enter the customer's phone number!");
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
                epKHSdt.SetError(tbPhone, null);
            }
        }

        private void tbCodeHD_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbCodeHD.Text))
            {
                e.Cancel = true;
                if (checklang == "Đăng Nhập")
                    epSHD.SetError(tbCodeHD, "Vui lòng điền số hóa đơn!");
                else
                    epSHD.SetError(tbCodeHD, "Please enter invoice number!");
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
                epSHD.SetError(tbCodeHD, null);
            }
        }

        private void tbCodeKH_HD_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbCodeKH_HD.Text))
            {
                e.Cancel = true;
                if (checklang == "Đăng Nhập")
                    epCodeKh_HD.SetError(tbCodeKH_HD, "Vui lòng điền mã khách hàng!");
                else
                    epCodeKh_HD.SetError(tbCodeKH_HD, "Please enter customer code!");
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
                epCodeKh_HD.SetError(tbCodeKH_HD, null);
            }
        }

        private void tbCodeNV_HD_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbCodeNV_HD.Text))
            {
                e.Cancel = true;
                if (checklang == "Đăng Nhập")
                    epCodeNv_HD.SetError(tbCodeNV_HD, "Vui lòng điền mã nhân viên!");
                else
                    epCodeNv_HD.SetError(tbCodeNV_HD, "Please enter the staff code!");
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
                epCodeNv_HD.SetError(tbCodeNV_HD, null);
            }
        }

        private void tbCodeHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroTabPage4_Click(object sender, EventArgs e)
        {
            
        }

        private void phêDuyệtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmLogin"];
            string TK = ((_frmLogin)f).tbUsername.Text;
            if (TK.ToUpper() == "ADMIN")
            {
                _frmAdmin f1 = new _frmAdmin();
                f1.Show();
            }
            else
            {
                if (checklang == "Đăng Nhập")
                    MessageBox.Show("Bạn không phải Admin , không thể phê duyệt !", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("You are not Admin, cannot approve!", "Notification", MessageBoxButtons.OK);
            }
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmRevenue f = new _frmRevenue();
            f.Show();
        }

        private void bunifuFlatButton1_Click_2(object sender, EventArgs e)
        {
            _frmDetail frmDetail = new _frmDetail();
            frmDetail.Show();
        }
    }
}
