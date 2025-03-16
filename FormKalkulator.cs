using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class FormKalkulator: Form
    {
        String strDisplay;
        Double temp;
        String operasi;
        public FormKalkulator()
        {
            InitializeComponent();
            textBoxDisplay.Visible = false; 
            foreach (Control control in Controls) 
            {
                if (control is Button && control != buttonOnOff) 
                {
                    control.Enabled = false;
                }
            }
            strDisplay = "";
            temp = 0.0;
            operasi = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            strDisplay += "1";
            textBoxDisplay.Text = strDisplay;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            strDisplay += "2";
            textBoxDisplay.Text = strDisplay;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            strDisplay += "3";
            textBoxDisplay.Text = strDisplay;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (strDisplay.Length > 0)
            {
            strDisplay += "0";
            textBoxDisplay.Text = strDisplay;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            strDisplay += "4";
            textBoxDisplay.Text = strDisplay;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            strDisplay += "5";
            textBoxDisplay.Text = strDisplay;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            strDisplay += "6";
            textBoxDisplay.Text = strDisplay;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            strDisplay += "7";
            textBoxDisplay.Text = strDisplay;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            strDisplay += "8";
            textBoxDisplay.Text = strDisplay;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            strDisplay += "9";
            textBoxDisplay.Text = strDisplay;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            temp = Convert.ToDouble(textBoxDisplay.Text);
            operasi = "+";
            strDisplay = "";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            temp = Convert.ToDouble(textBoxDisplay.Text);
            operasi = "-";
            strDisplay = "";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            temp = Convert.ToDouble(textBoxDisplay.Text);
            operasi = "*";
            strDisplay = "";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            temp = Convert.ToDouble(textBoxDisplay.Text);
            operasi = "/";
            strDisplay = "";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            double hasil = 0.0;
            if (operasi == "+")
            {
                hasil = temp + Convert.ToDouble(textBoxDisplay.Text);
                strDisplay = hasil.ToString();
                textBoxDisplay.Text = strDisplay;
            }
            else if (operasi == "-")
            {
                hasil = temp - Convert.ToDouble(textBoxDisplay.Text);
                strDisplay = hasil.ToString();
                textBoxDisplay.Text = strDisplay;
            }
            else if (operasi == "*")
            {
                hasil = temp * Convert.ToDouble(textBoxDisplay.Text);
                if (hasil == (int)hasil)
                {
                    strDisplay = ((int)hasil).ToString();
                }
                else
                {
                    strDisplay = hasil.ToString();
                }
                textBoxDisplay.Text = strDisplay;
            }
            else if (operasi == "/")
            {
                if (Convert.ToDouble(textBoxDisplay.Text) != 0)
                {
                    hasil = temp / Convert.ToDouble(textBoxDisplay.Text);
                    if (hasil == (int)hasil)
                    {
                        strDisplay = ((int)hasil).ToString();
                    }
                    else
                    {
                        strDisplay = hasil.ToString();
                    }
                    textBoxDisplay.Text = strDisplay;
                }
                else
                {
                    MessageBox.Show("Tidak bisa membagi dengan nol!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    strDisplay = "";
                    textBoxDisplay.Text = "0";
                    return;
                }
                
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "0";
            strDisplay = "";
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //Menghapus string yang terakhir ditambahkan
            if(strDisplay.Length > 0)
            {
                strDisplay = strDisplay.Remove(strDisplay.Length - 1);
                textBoxDisplay.Text = strDisplay;
            }
            if(strDisplay == "")
            {
                textBoxDisplay.Text = "0";
                strDisplay = "";
            }
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (strDisplay == "") 
            {
                strDisplay = "0."; 
            }
            else if (!strDisplay.Contains("."))
            {
                strDisplay += "."; 
            }
            textBoxDisplay.Text = strDisplay;
        }

        private void buttonOnOff_Click(object sender, EventArgs e)
        {
            //Menghidupkan dan mematikan kalkulator
            if (textBoxDisplay.Visible) 
            {
                buttonOnOff.Text = "ON";
                textBoxDisplay.Enabled = false;
                textBoxDisplay.Visible = false;
                foreach (Control control in Controls) 
                {
                    if (control is Button && control != buttonOnOff) 
                    {
                        control.Enabled = false;
                    }
                }
                textBoxDisplay.Text = "0";
                strDisplay = "";
                temp = 0.0;
                operasi = "";
            }
            else
            {
                buttonOnOff.Text = "OFF";
                textBoxDisplay.Enabled = true;
                textBoxDisplay.Visible = true;
                foreach (Control control in Controls) 
                {
                    if (control is Button)
                    {
                        control.Enabled = true;
                    }
                }
            }
        }


        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            //Buat angka dalam string berubah menjadi positif dan negatif
            if (strDisplay != "" && strDisplay != "0") 
            {
                if (strDisplay.Contains("-")) 
                {
                    strDisplay = strDisplay.Remove(0, 1);
                }
                else
                {
                    strDisplay = "-" + strDisplay; 
                }
                textBoxDisplay.Text = strDisplay; 
            }
        }
    }
}
