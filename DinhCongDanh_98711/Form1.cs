using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinhCongDanh_98711
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadCBB();
            loadDgv();
        }
        private void loadCBB()
        {
            cbNCC.DataSource = database.Query("select * from NhaCungCap_1");
            cbNSX.DataSource = database.Query("Select * from NhaSanXuat_7");
            cbNCCTK.DataSource = database.Query("select * from NhaCungCap_1");
            cbNSXTK.DataSource = database.Query("Select * from NhaSanXuat_7");
        }

        private void loadDgv()
        {
            dataGridView1.DataSource = database.Query("select MaSanPham, TenSanPham, TenNhaCungCap, TenNhaSanXuat from SanPham_1 INNER JOIN NhaCungCap_1 ON SanPham_1.MaNhaCungCap=NhaCungCap_1.MaNhaCungCap  INNER JOIN NhaSanXuat_7 ON SanPham_1.MaNhaSanXuat=NhaSanXuat_7.MaNhaSanXuat");
            btnSua.Enabled = btnXoa.Enabled = dataGridView1.Rows.Count > 0;
        }

        private bool ktra()
        {
            bool kq = true;
            errorProvider1.Clear();
            if (txtMaSanPham.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMaSanPham, "Chua dien ma");
                kq = false;
            }
            if (txtTenSanPham.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTenSanPham, "Chua dien ten");
                kq = false;
            }
            return kq;
        }
        

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ktra() == false) return;
            bool kq = true;
            string sql = "select * from SanPham_1 where MaSanPham=N'" + txtMaSanPham.Text + "'";
            if (database.Query(sql).Rows.Count > 0)
            {
                errorProvider1.SetError(txtMaSanPham, "Trùng mã");
                txtMaSanPham.Clear();
                kq = false;
            }
            string sql1 = "select * from SanPham_1 where TenSanPham=N'" + txtTenSanPham.Text + "'";
            if (database.Query(sql1).Rows.Count > 0)
            {
                errorProvider1.SetError(txtTenSanPham, "Trùng tên");
                txtTenSanPham.Clear();
                kq = false;
            }
            if (kq == false) return;
            database.Execute("INSERT SanPham_1 VALUES(N'" + txtMaSanPham.Text + "', N'" + txtTenSanPham.Text + "', N'" + cbNCC.SelectedValue + "', N'" + cbNSX.SelectedValue + "')");
            loadDgv();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ktra() == false) return;
            bool kq = true;
            string sql1 = "select * from SanPham_1 where  MaSanPham != N'"+txtMaSanPham.Text+"' and TenSanPham=N'" + txtTenSanPham.Text + "'";
            if (database.Query(sql1).Rows.Count > 0)
            {
                errorProvider1.SetError(txtTenSanPham, "trùng tên");
                txtTenSanPham.Clear();
                kq = false;
            }
            if (kq == false) return;
            string ttXoa = dataGridView1.CurrentRow.Cells["clMaSanPham"].Value.ToString();
            database.Execute("update SanPham_1 set MaSanPham=N'" + txtMaSanPham.Text + "', TenSanPham=N'" + txtTenSanPham.Text + "', MaNhaCungCap= N'" + cbNCC.SelectedValue + "', MaNhaSanXuat=N'" + cbNSX.SelectedValue + "' where MaSanPham=N'" + ttXoa + "'");
            loadDgv();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            string ttXoa = dataGridView1.CurrentRow.Cells["clMaSanPham"].Value.ToString();
            database.Execute("delete SanPham_1 where MaSanPham=N'" + ttXoa + "'");
            loadDgv();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM TimKiemSanPham1(@MaSanPham,@TenSanPham, @MaNhaCungCap, @MaNhaSanXuat)";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            if (checkMa.Checked)
                dictionary.Add("@MaSanPham", txtMaSanPhamTK.Text);
            else
                dictionary.Add("@MaSanPham", "");
            if (checkTen.Checked)
                dictionary.Add("@TenSanPham", txtTenSanPhamTK.Text);
            else
                dictionary.Add("@TenSanPham", "");
            if (checkNCC.Checked)
                dictionary.Add("@MaNhaCungCap", cbNCCTK.SelectedValue);
            else
                dictionary.Add("@MaNhaCungCap", DBNull.Value);
            if (checkNSX.Checked)
                dictionary.Add("@MaNhaSanXuat", cbNSXTK.SelectedValue);
            else
                dictionary.Add("@MaNhaSanXuat", DBNull.Value);
            dataGridView1.DataSource = database.Query(sql, dictionary);
  

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSanPham.Text = dataGridView1.Rows[e.RowIndex].Cells["clMaSanPham"].Value.ToString();
            txtTenSanPham.Text = dataGridView1.Rows[e.RowIndex].Cells["clTenSanPham"].Value.ToString();
            cbNCC.Text = dataGridView1.Rows[e.RowIndex].Cells["clTenNhaCungCap"].Value.ToString();
            cbNSX.Text = dataGridView1.Rows[e.RowIndex].Cells["clTenNhaSanXuat"].Value.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loadDgv();
        }
    }
}
