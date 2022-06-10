using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTCNPM
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        // tab1

        double ketQua1, ketQua2, ketQua3, ketQua4, ketQua5, ketQua6, ketQua7, ketQua8 = 0;
        string noiSuy;

        private void setGiaTriNoiSuy(double ketQua)
        {
            if (ketQua <= 0)
                noiSuy = "0";
            else if (ketQua > 0 && ketQua <= 1)
                noiSuy = "0.05";
            else if (ketQua > 1 && ketQua <= 2)
                noiSuy = "0.1";
            else if (ketQua > 2 && ketQua <= 3)
                noiSuy = "0.6";
            else if (ketQua > 3)
                noiSuy = "1";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gtrXepHang = comboBox1.GetItemText(comboBox1.SelectedItem);
            ketQua1 = 1.5 * Convert.ToDouble(gtrXepHang);
            label52.Text = ketQua1.ToString();
            setGiaTriNoiSuy(ketQua1);
            label53.Text = noiSuy;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gtrXepHang = comboBox2.GetItemText(comboBox2.SelectedItem);
            ketQua2 = 0.5 * Convert.ToDouble(gtrXepHang);
            label54.Text = ketQua2.ToString();
            setGiaTriNoiSuy(ketQua2);
            label55.Text = noiSuy;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gtrXepHang = comboBox3.GetItemText(comboBox3.SelectedItem);
            ketQua3 = Convert.ToDouble(gtrXepHang);
            label56.Text = ketQua3.ToString();
            setGiaTriNoiSuy(ketQua3);
            label57.Text = noiSuy;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gtrXepHang = comboBox4.GetItemText(comboBox4.SelectedItem);
            ketQua4 = 0.5 * Convert.ToDouble(gtrXepHang);
            label58.Text = ketQua4.ToString();
            setGiaTriNoiSuy(ketQua4);
            label59.Text = noiSuy;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gtrXepHang = comboBox5.GetItemText(comboBox5.SelectedItem);
            ketQua5 = Convert.ToDouble(gtrXepHang);
            label60.Text = ketQua5.ToString();
            setGiaTriNoiSuy(ketQua5);
            label61.Text = noiSuy;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gtrXepHang = comboBox6.GetItemText(comboBox6.SelectedItem);
            ketQua6 = 2 * Convert.ToDouble(gtrXepHang);
            label62.Text = ketQua6.ToString();
            setGiaTriNoiSuy(ketQua6);
            label63.Text = noiSuy;
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gtrXepHang = comboBox7.GetItemText(comboBox7.SelectedItem);
            ketQua7 = -1 * Convert.ToDouble(gtrXepHang);
            label64.Text = ketQua7.ToString();
            setGiaTriNoiSuy(ketQua7);
            label65.Text = noiSuy;
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gtrXepHang = comboBox8.GetItemText(comboBox8.SelectedItem);
            ketQua8 = -1 * Convert.ToDouble(gtrXepHang);
            label66.Text = ketQua8.ToString();
            setGiaTriNoiSuy(ketQua8);
            label67.Text = noiSuy;
        }

        double P;

        private void setP(double ES)
        {
            if (ES < 1)
                P = 48;
            else if (ES >= 1 && ES < 3)
                P = 32;
            else if (ES >= 3)
                P = 20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double EFW = ketQua1 + ketQua2 + ketQua3 + ketQua4 + ketQua5 + ketQua6 + ketQua7 + ketQua8;
            label72.Text = EFW.ToString();
            double EF = 1.4 - 0.03 * EFW;
            label73.Text = EF.ToString();
            double ES = Convert.ToDouble(label53.Text) + Convert.ToDouble(label55.Text) + Convert.ToDouble(label57.Text) + Convert.ToDouble(label59.Text) + Convert.ToDouble(label61.Text) + Convert.ToDouble(label63.Text) + Convert.ToDouble(label65.Text) + Convert.ToDouble(label67.Text);
            label74.Text = ES.ToString();
            setP(ES);
            label75.Text = P.ToString();
        }

        // tab2

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label92.Text = numericUpDown1.Value.ToString();
            double TAW = Convert.ToDouble(label92.Text) + Convert.ToDouble(label93.Text) + Convert.ToDouble(label94.Text);
            label95.Text = TAW.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            label93.Text = (2 * numericUpDown2.Value).ToString();
            double TAW = Convert.ToDouble(label92.Text) + Convert.ToDouble(label93.Text) + Convert.ToDouble(label94.Text);
            label95.Text = TAW.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            label94.Text = (3 * numericUpDown3.Value).ToString();
            double TAW = Convert.ToDouble(label92.Text) + Convert.ToDouble(label93.Text) + Convert.ToDouble(label94.Text);
            label95.Text = TAW.ToString();
        }

        // tab3

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            label121.Text = (5 * numericUpDown4.Value).ToString();
            label115.Text = (numericUpDown4.Value + numericUpDown5.Value + numericUpDown6.Value).ToString();
            label120.Text = (Convert.ToDouble(label121.Text) + Convert.ToDouble(label122.Text) + Convert.ToDouble(label123.Text)).ToString();
            label132.Text = (Convert.ToDouble(label120.Text) + Convert.ToDouble(label124.Text) + Convert.ToDouble(label128.Text)).ToString();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            label122.Text = (10 * numericUpDown5.Value).ToString();
            label115.Text = (numericUpDown4.Value + numericUpDown5.Value + numericUpDown6.Value).ToString();
            label120.Text = (Convert.ToDouble(label121.Text) + Convert.ToDouble(label122.Text) + Convert.ToDouble(label123.Text)).ToString();
            label132.Text = (Convert.ToDouble(label120.Text) + Convert.ToDouble(label124.Text) + Convert.ToDouble(label128.Text)).ToString();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            label123.Text = (15 * numericUpDown6.Value).ToString();
            label115.Text = (numericUpDown4.Value + numericUpDown5.Value + numericUpDown6.Value).ToString();
            label120.Text = (Convert.ToDouble(label121.Text) + Convert.ToDouble(label122.Text) + Convert.ToDouble(label123.Text)).ToString();
            label132.Text = (Convert.ToDouble(label120.Text) + Convert.ToDouble(label124.Text) + Convert.ToDouble(label128.Text)).ToString();
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            double a = (double)(5 * numericUpDown7.Value);
            label125.Text = (1.2 * a).ToString();
            label116.Text = (numericUpDown7.Value + numericUpDown8.Value + numericUpDown9.Value).ToString();
            label124.Text = (Convert.ToDouble(label125.Text) + Convert.ToDouble(label126.Text) + Convert.ToDouble(label127.Text)).ToString();
            label132.Text = (Convert.ToDouble(label120.Text) + Convert.ToDouble(label124.Text) + Convert.ToDouble(label128.Text)).ToString();
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            double a = (double)(10 * numericUpDown8.Value);
            label126.Text = (1.2 * a).ToString();
            label116.Text = (numericUpDown7.Value + numericUpDown8.Value + numericUpDown9.Value).ToString();
            label124.Text = (Convert.ToDouble(label125.Text) + Convert.ToDouble(label126.Text) + Convert.ToDouble(label127.Text)).ToString();
            label132.Text = (Convert.ToDouble(label120.Text) + Convert.ToDouble(label124.Text) + Convert.ToDouble(label128.Text)).ToString();
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            double a = (double)(15 * numericUpDown9.Value);
            label127.Text = (1.2 * a).ToString();
            label116.Text = (numericUpDown7.Value + numericUpDown8.Value + numericUpDown9.Value).ToString();
            label124.Text = (Convert.ToDouble(label125.Text) + Convert.ToDouble(label126.Text) + Convert.ToDouble(label127.Text)).ToString();
            label132.Text = (Convert.ToDouble(label120.Text) + Convert.ToDouble(label124.Text) + Convert.ToDouble(label128.Text)).ToString();
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            double a = (double)(5 * numericUpDown10.Value);
            label129.Text = (1.5 * a).ToString();
            label117.Text = (numericUpDown10.Value + numericUpDown11.Value + numericUpDown12.Value).ToString();
            label128.Text = (Convert.ToDouble(label129.Text) + Convert.ToDouble(label130.Text) + Convert.ToDouble(label131.Text)).ToString();
            label132.Text = (Convert.ToDouble(label120.Text) + Convert.ToDouble(label124.Text) + Convert.ToDouble(label128.Text)).ToString();
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            double a = (double)(10 * numericUpDown11.Value);
            label130.Text = (1.5 * a).ToString();
            label117.Text = (numericUpDown10.Value + numericUpDown11.Value + numericUpDown12.Value).ToString();
            label128.Text = (Convert.ToDouble(label129.Text) + Convert.ToDouble(label130.Text) + Convert.ToDouble(label131.Text)).ToString();
            label132.Text = (Convert.ToDouble(label120.Text) + Convert.ToDouble(label124.Text) + Convert.ToDouble(label128.Text)).ToString();
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            double a = (double)(15 * numericUpDown12.Value);
            label131.Text = (1.5 * a).ToString();
            label117.Text = (numericUpDown10.Value + numericUpDown11.Value + numericUpDown12.Value).ToString();
            label128.Text = (Convert.ToDouble(label129.Text) + Convert.ToDouble(label130.Text) + Convert.ToDouble(label131.Text)).ToString();
            label132.Text = (Convert.ToDouble(label120.Text) + Convert.ToDouble(label124.Text) + Convert.ToDouble(label128.Text)).ToString();
        }

        // tab 4

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gtrXepHang = comboBox9.GetItemText(comboBox9.SelectedItem);
            label182.Text = (2 * Convert.ToDouble(gtrXepHang)).ToString();
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gtrXepHang = comboBox10.GetItemText(comboBox10.SelectedItem);
            label183.Text = Convert.ToDouble(gtrXepHang).ToString();
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gtrXepHang = comboBox11.GetItemText(comboBox11.SelectedItem);
            label184.Text = Convert.ToDouble(gtrXepHang).ToString();
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gtrXepHang = comboBox12.GetItemText(comboBox12.SelectedItem);
            label185.Text = Convert.ToDouble(gtrXepHang).ToString();
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gtrXepHang = comboBox13.GetItemText(comboBox13.SelectedItem);
            label186.Text = Convert.ToDouble(gtrXepHang).ToString();
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gtrXepHang = comboBox14.GetItemText(comboBox14.SelectedItem);
            label187.Text = (0.5 * Convert.ToDouble(gtrXepHang)).ToString();
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gtrXepHang = comboBox15.GetItemText(comboBox15.SelectedItem);
            label188.Text = (0.5 * Convert.ToDouble(gtrXepHang)).ToString();
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gtrXepHang = comboBox16.GetItemText(comboBox16.SelectedItem);
            label189.Text = (2 * Convert.ToDouble(gtrXepHang)).ToString();
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gtrXepHang = comboBox17.GetItemText(comboBox17.SelectedItem);
            label190.Text = Convert.ToDouble(gtrXepHang).ToString();
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gtrXepHang = comboBox18.GetItemText(comboBox18.SelectedItem);
            label191.Text = Convert.ToDouble(gtrXepHang).ToString();
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gtrXepHang = comboBox19.GetItemText(comboBox19.SelectedItem);
            label192.Text = Convert.ToDouble(gtrXepHang).ToString();
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gtrXepHang = comboBox20.GetItemText(comboBox20.SelectedItem);
            label193.Text = Convert.ToDouble(gtrXepHang).ToString();
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gtrXepHang = comboBox21.GetItemText(comboBox21.SelectedItem);
            label194.Text = Convert.ToDouble(gtrXepHang).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double TFW = Convert.ToDouble(label182.Text) + Convert.ToDouble(label183.Text) + Convert.ToDouble(label184.Text)
                        + Convert.ToDouble(label185.Text) + Convert.ToDouble(label186.Text) + Convert.ToDouble(label187.Text) 
                        + Convert.ToDouble(label188.Text) + Convert.ToDouble(label189.Text) + Convert.ToDouble(label190.Text)
                        + Convert.ToDouble(label191.Text) + Convert.ToDouble(label192.Text) + Convert.ToDouble(label193.Text) 
                        + Convert.ToDouble(label194.Text);
            label195.Text = TFW.ToString();
            label196.Text = (0.6 + 0.01 * TFW).ToString();
        }

        // tab 5

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox2.Text = textBox1.Text.Remove(textBox2.Text.Length - 1);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox3.Text = textBox3.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label208.Text = (Convert.ToDouble(textBox1.Text) * (double)numericUpDown13.Value).ToString();
            label209.Text = (Convert.ToDouble(textBox2.Text) * (double)numericUpDown14.Value).ToString();
            label210.Text = (Convert.ToDouble(textBox3.Text) * (double)numericUpDown15.Value).ToString();
            double tongChiLuongThang = Convert.ToInt32(label208.Text) + Convert.ToInt32(label209.Text) + Convert.ToInt32(label210.Text);
            label211.Text = tongChiLuongThang.ToString();
            int tongSoLuongCanBo = (int)(numericUpDown13.Value + numericUpDown14.Value + numericUpDown15.Value);
            double luongNguoiThang = tongChiLuongThang / tongSoLuongCanBo;
            label212.Text = luongNguoiThang.ToString();
            label213.Text = (luongNguoiThang/160).ToString();
        }

        // tab 6

        private void button4_Click(object sender, EventArgs e)
        {
            label225.Text = label95.Text;
            label229.Text = label132.Text;
            label233.Text = (Convert.ToDouble(label225.Text) + Convert.ToDouble(label229.Text)).ToString();
            label237.Text = label196.Text;
            label241.Text = label73.Text;
            double AUCP = Convert.ToDouble(label233.Text) * Convert.ToDouble(label237.Text) * Convert.ToDouble(label241.Text);
            label245.Text = AUCP.ToString();
            label249.Text = label75.Text;
            label253.Text = (10 * AUCP / 6).ToString();
            label257.Text = label213.Text;
            label261.Text = (1.4 * Convert.ToDouble(label249.Text) * Convert.ToDouble(label253.Text) * Convert.ToDouble(label257.Text)).ToString();
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double G = Convert.ToDouble(label261.Text);
            double tyle = Convert.ToDouble(textBox4.Text);
            double C = G * tyle;
            double TL = (G + C) * tyle;
            double Gpm = G + C + TL;

            label267.Text = label261.Text;
            label272.Text = C.ToString();
            label277.Text = TL.ToString();
            label282.Text = Gpm.ToString();
        }
    }
}
