using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntNhap_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            long sum = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sum += long.Parse(listBox1.Items[i].ToString());
            }
            MessageBox.Show("Kết quả " + sum);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.RemoveAt(0);
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);

            }
            else
                MessageBox.Show("Danh sach trong", "Thong Bao");
        }

        private void bn3_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i != -1)
            {
                listBox1.Items.RemoveAt(i);
            }
            else
            {
                MessageBox.Show("Khong tim thay");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            for (int i = 0;i < listBox1.Items.Count;i++)
            {
                listBox1.Items[i] = long.Parse(listBox1.Items[i].ToString()) + 2;
            }
        }

        private void bnt5_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.Items[i] = long.Parse(listBox1.Items[i].ToString()) +
                    long.Parse(listBox1.Items[i].ToString());
            }
        }

        private void bntKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Trống", "THông báo");
        }
    }
}
