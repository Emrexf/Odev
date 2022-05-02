using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "yuksek")
            {
                if (comboBox2.Text == "var")
                {
                    label5.Text = "Futbol Oynanamaz";
                }
                else
                {
                    if (comboBox3.Text == "cumartesi" || comboBox3.Text == "pazar")
                    {
                        if (comboBox4.Text == "sabah")
                        {
                            label5.Text = "Futbol Oynanamaz";
                        }
                        else if (comboBox4.Text == "aksam")
                        {
                            label5.Text = "Futbol Oynanabilir";
                        }
                        else
                        {
                            if (comboBox5.Text == "bulutlu")
                            {
                                label5.Text = "Futbol Oynanamaz";
                            }
                            else
                            {
                                label5.Text = "Futbol Oynanabilir";
                            }
                        }

                    }
                    else
                    {
                        label5.Text = "Futbol Oynanabilir";
                    }
                }

            }
            else
            {
                if (comboBox2.Text == "var")
                {
                    label5.Text = "Futbol Oynanamaz";
                }
                else
                {
                    if (comboBox3.Text == "cumartesi" || comboBox3.Text == "pazar")

                    {
                        if (comboBox4.Text == "sabah")
                        {
                            label5.Text = "Futbol Oynanamaz";
                        }
                        else if (comboBox4.Text == "aksam")
                        {
                            label5.Text = "Futbol Oynanabilir";
                        }
                        else
                        {
                            if (comboBox5.Text == "bulutlu")
                            {
                                label5.Text = "Futbol Oynanamaz";
                            }
                            else
                            {
                                label5.Text = "Futbol Oynanabilir";
                            }
                        }

                    }
                    else
                    {
                        label5.Text = "Futbol Oynanabilir";
                    }
                }
            }
        }
    }
}
