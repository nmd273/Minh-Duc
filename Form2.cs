using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using System.Text.RegularExpressions;


namespace Bai_17
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private string _message;
        public String Message
        {
            get { return _message; }
            set { _message = value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x = name.Text;
            string pattern = ky_tu.Text;
            Regex MyRegex = new Regex(pattern);

            // su dung phuong thuc Match de do tim tren pattern xem co xuat hien 1 RE hay ko rui tra ve kq chinh xac 
            // isMatch : tra ve gtri bool cho biết liệu xem RE có tìm thấy một so khớp hay không trên pattern
            // Matchesdk xem nhu la goi Match nhieu lan
            
            Match m = MyRegex.Match(x);
            if (m.Success)
            {
                ketqua.Text = "found symbol  " + m.Value + " in " + (m.Index + 1) + "th in string ";
        
            }
            else
                ketqua.Text = "Not found";


            
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            string x = name.Text;
            MatchCollection mc;
            string pattern = ky_tu.Text;
            Regex MyRegex = new Regex(pattern);
            mc = MyRegex.Matches(x);
            int index = 0;
            foreach (Match m in mc)
            {
                index++;

            }
            MessageBox.Show ("found  "+ index.ToString() + " symbol", "Thong bao");
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            name.Text = _message;
            string s = name.Text;
            name.Text = s.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }
    }
}
