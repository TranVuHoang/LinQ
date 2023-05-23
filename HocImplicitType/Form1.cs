using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocImplicitType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            var x = 113;
            var y = 5.5;
            var z = 7.5f;
            var s = "Obama";
            var d = new DateTime(2023, 5, 23);

            lblMessage.Text ="x = "+ x + " -> kiểu dữ liệu: " +  x.GetType().ToString();
            lblMessage.Text +="\ny = " + y + "-> kiểu dữ liệu: " + y.GetType().ToString();
            lblMessage.Text += "\nz = " + z + "-> kiểu dữ liệu: " + z.GetType().ToString();
            lblMessage.Text += "\ns = " + s + "-> kiểu dữ liệu: " + s.GetType().ToString();
            lblMessage.Text += "\nd = " + d + "-> kiểu dữ liệu: " + d.GetType().ToString();

            var t = "Putin";
            t = "Kim Jong Un";
            //t = 5.5; //sai

        }
    }
}
