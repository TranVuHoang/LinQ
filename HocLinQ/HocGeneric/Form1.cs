using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocGeneric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // khai báo 1 generic

        List<int> dsInt = new List<int>();
        public void checkData()
        {
            if (this.txtN.Text.Trim() == "")
            {
                MessageBox.Show("Bạn cần nhập nội dung cho ô này.");
                this.txtN.Focus();
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            checkData();
            int n = int.Parse(txtN.Text);
            Random rd = new Random();

            for (int i = 0; i < n; i++)
            {
                int x = rd.Next(100);
                dsInt.Add(x); // phương thức Add() để đẩy dữ liệu vào
            }

            dsInt.AddRange(new int[] { 113, 114 });
            lstSo.Items.Clear();

            for (int i = 0; i < dsInt.Count; i++)
            {
               lstSo.Items.Add(dsInt[i]);
            }

        }

        private void lstSo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.lstSo.SelectedIndex != -1)
            {
                txtValue.Text = dsInt[lstSo.SelectedIndex] + "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            checkData();

            if(this.lstSo.SelectedIndex != -1)
            {
                dsInt[lstSo.SelectedIndex] = int.Parse(txtValue.Text);
                lstSo.Items[lstSo.SelectedIndex] = dsInt[lstSo.SelectedIndex];
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(this.lstSo.SelectedIndex != -1)
            {
                dsInt.RemoveAt(lstSo.SelectedIndex);
                lstSo.Items.Clear();

                for (int i = 0; i < dsInt.Count; i++)
                {
                    lstSo.Items.Add(dsInt[i]);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn, không xóa được.");
            }
        }

        Dictionary <int, string> dicSV = new Dictionary<int, string>();
        private void btnSave_Click(object sender, EventArgs e)
        {
            int maSv = int.Parse(txtCode.Text);
            string tenSv = txtName.Text;
            dicSV.Add(maSv, tenSv);
            txtCode.Text = "";
            txtName.Text = "";

            ShowDataStudent();
        }

        private void ShowDataStudent()
        {
            lvStudent.Items.Clear();

            foreach (KeyValuePair <int, string> item in dicSV)
            {
                ListViewItem lvi = new ListViewItem(item.Key + "");
                lvi.SubItems.Add(item.Value);  
                lvStudent.Items.Add(lvi);
            }
        }

        private void lvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem lvi = lvStudent.SelectedItems[0];
            int ma = int.Parse(lvi.SubItems[0].Text);
            string ten = dicSV[ma];
            txtCode.Text = ma + "";
            txtName.Text = ten;
        }

        private void btnDeleteSV_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtCode.Text);
            dicSV.Remove(ma);
            ShowDataStudent() ;
        }
    }
}
