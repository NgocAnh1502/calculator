using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maytinh
{
    public partial class Form1 : Form
    {
        static int pheptinh = 0;
        static float a, b;
        static char toan;
        static float ans;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblhienthi.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblhienthi.Text += "8";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblhienthi.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lblhienthi.Text += "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            lblhienthi.Text += "0";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblhienthi.Text += "9";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(pheptinh == 0)
            {
                a = float.Parse(lblhienthi.Text);
                 lblhienthi.Text += "/";
                toan = '/';
                pheptinh++;
            }
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pheptinh > 1 || pheptinh == 0) return;
            string s = lblhienthi.Text;
            int x = s.IndexOf(toan);
            b = float.Parse((s.Substring(x + 1, s.Length - x - 1)));
            char toanhang = toan;
            switch (toanhang) 
            {
                case '+':
                    float tong = a + b;
                    label1.Text += tong.ToString();
                    ans = tong;
                    break;
                case '-':
                    float hieu = a - b;
                    label1.Text += hieu.ToString();
                    ans = hieu;
                    break;
                case '*':
                    float tich = a * b;
                    label1.Text += tich.ToString();
                    ans = tich;
                    break;
                case '/':
                    if(b != 0)
                    {
                        float thuong = (float) a / b;
                        label1.Text += thuong.ToString();
                        ans = thuong;
                    }
                    else
                    {
                        lblhienthi.Text = "Matherro";
                    }
                    break;

            }

            pheptinh++;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblhienthi.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblhienthi.Text += "4";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblhienthi.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblhienthi.Text += "7";
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            if (pheptinh == 0)
            {
                a = float.Parse(lblhienthi.Text);
                lblhienthi.Text += "-";
                toan = '-';
                pheptinh++;
            }
            
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            if (pheptinh == 0)
            {
                a = float.Parse(lblhienthi.Text);
                lblhienthi.Text += "*";
                toan = '*';
                pheptinh++;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            pheptinh = 0;
            lblhienthi.Text = "";
            label1.Text = "";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string s = lblhienthi.Text;
            if (s[s.Length - 1] == toan)
            {
                pheptinh--;
            }
            lblhienthi.Text = lblhienthi.Text.Remove(lblhienthi.Text.Length - 1, 1);
        }

        private void btn_ans_Click(object sender, EventArgs e)
        {
            lblhienthi.Text += ".";
            
        }

        private void btn_am_Click(object sender, EventArgs e)
        {
            lblhienthi.Text += "-";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if(pheptinh == 0)
            {
                a = float.Parse(lblhienthi.Text);
                lblhienthi.Text += "+";
                toan = '+';
                pheptinh++;
            }
        }
    }
}
