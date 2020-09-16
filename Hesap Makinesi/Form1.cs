using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtİslem.Text = "";
            lblİslem.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtİslem.Text != "")
            {
                txtİslem.Text = txtİslem.Text.Substring(0, txtİslem.Text.Length - 1);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
                txtİslem.Text = txtİslem.Text + 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtİslem.Text = txtİslem.Text + 1;
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtİslem.Text = txtİslem.Text + 2;
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtİslem.Text = txtİslem.Text + 3;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtİslem.Text = txtİslem.Text + 4;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtİslem.Text = txtİslem.Text + 5;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtİslem.Text = txtİslem.Text + 6;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtİslem.Text = txtİslem.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtİslem.Text = txtİslem.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtİslem.Text = txtİslem.Text + 9;
        }

        

        double ilkSayi;
       

        public void button4_Click(object sender, EventArgs e)
        {
            if (txtİslem.Text != "")
            {
                
                ilkSayi = Convert.ToDouble(txtİslem.Text);
                txtİslem.Clear();
                
                lblİslem.Text = "÷";
            }
        }

        double sonSayi;
        
        public void button19_Click(object sender, EventArgs e)
        {
            
            
                if (txtİslem.Text != "")
                {
                    sonSayi = Convert.ToDouble(txtİslem.Text);
                    //txtİslem.Clear();

                    if (lblİslem.Text == "÷")
                    {
                        double a = ilkSayi / sonSayi;
                        txtİslem.Clear();
                        txtİslem.Text = a.ToString();
                        Task.Delay(500);

                        lblİslem.Text = "";
                        
                        
                    }
                    else if (lblİslem.Text == "x")
                    {
                        double a = ilkSayi * sonSayi;
                        txtİslem.Clear();
                        txtİslem.Text = a.ToString();
                        lblİslem.Text = "";
                        
                       
                    }
                    else if (lblİslem.Text == "-")
                    {
                        double a = ilkSayi - sonSayi;
                        txtİslem.Clear();
                        txtİslem.Text = a.ToString();
                        lblİslem.Text = "";
                       
                        
                    }
                    else if (lblİslem.Text == "%")
                    {
                        double a = ilkSayi % sonSayi;
                        txtİslem.Clear();
                        txtİslem.Text = a.ToString();
                        lblİslem.Text = "";
                        
                        
                    }
                    else if (lblİslem.Text == "+")
                    {
                        double a = ilkSayi + sonSayi;
                        txtİslem.Clear();
                        txtİslem.Text = a.ToString();
                        lblİslem.Text = "";
                       
                    }
                }  
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txtİslem.Text != "")
            {
                txtİslem.Text = txtİslem.Text + ",";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtİslem.Text != "")
            {
                ilkSayi = Convert.ToDouble(txtİslem.Text);
                txtİslem.Clear();
                lblİslem.Text = "x";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtİslem.Text != "")
            {
                ilkSayi = Convert.ToDouble(txtİslem.Text);
                txtİslem.Clear();
                lblİslem.Text = "-";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtİslem.Text != "")
            {
                ilkSayi = Convert.ToDouble(txtİslem.Text);
                txtİslem.Clear();
                lblİslem.Text = "+";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtİslem.Text != "" )
            {
                ilkSayi = Convert.ToDouble(txtİslem.Text);
                txtİslem.Clear();
                lblİslem.Text = "%";
            }
        }
    }
}
