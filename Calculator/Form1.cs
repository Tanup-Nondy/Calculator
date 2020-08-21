using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1 = 0;
        double num2 = 0;
        string ope_rator;
        bool eq_btn = false;
        private void zerobtn_Click(object sender, EventArgs e)
        {
            if (eq_btn)
            {
                box.Clear();
                eq_btn = false;
            }
            box.Text = box.Text + zerobtn.Text;
        }

        private void pbtn_Click(object sender, EventArgs e)
        {
            if (eq_btn)
            {
                box.Clear();
                eq_btn = false;
            }
            box.Text = box.Text + pbtn.Text;
        }

        private void cbtn_Click(object sender, EventArgs e)
        {
            box.Clear();
        }

        private void divbtn_Click(object sender, EventArgs e)
        {
            num1 = num1 + double.Parse(box.Text);
            box.Clear();
            ope_rator = "/";
        }

        private void onebtn_Click(object sender, EventArgs e)
        {
            if (eq_btn)
            {
                box.Clear();
                eq_btn = false;
            }
            box.Text = box.Text + onebtn.Text;
        }

        private void twobtn_Click(object sender, EventArgs e)
        {
            if (eq_btn)
            {
                box.Clear();
                eq_btn = false;
            }
            box.Text = box.Text + twobtn.Text;
        }

        private void threebtn_Click(object sender, EventArgs e)
        {
            if (eq_btn)
            {
                box.Clear();
                eq_btn = false;
            }
            box.Text = box.Text + threebtn.Text;
        }

        private void mbtn_Click(object sender, EventArgs e)
        {
            num1 = num1 + double.Parse(box.Text);
            box.Clear();
            ope_rator = "x";
        }

        private void fourbtn_Click(object sender, EventArgs e)
        {
            if (eq_btn)
            {
                box.Clear();
                eq_btn = false;
            }
            box.Text = box.Text + fourbtn.Text;
        }

        private void sixbtn_Click(object sender, EventArgs e)
        {
            if (eq_btn)
            {
                box.Clear();
                eq_btn = false;
            }
            box.Text = box.Text + sixbtn.Text;
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            num1 = num1 + double.Parse(box.Text);
            box.Clear();
            ope_rator = "-";
        }

        private void sevenbtn_Click(object sender, EventArgs e)
        {
            if (eq_btn)
            {
                box.Clear();
                eq_btn = false;
            }
            box.Text = box.Text + sevenbtn.Text;
        }

        private void eightbtn_Click(object sender, EventArgs e)
        {
            if (eq_btn)
            {
                box.Clear();
                eq_btn = false;
            }
            box.Text = box.Text + eightbtn.Text;
        }

        private void ninebtn_Click(object sender, EventArgs e)
        {
            if (eq_btn)
            {
                box.Clear();
                eq_btn = false;
            }
            box.Text = box.Text + ninebtn.Text;
        }

        private void plusbtn_Click(object sender, EventArgs e)
        {
            num1 = num1 + double.Parse(box.Text);
            box.Clear();
            ope_rator = "+";
        }

        private void eqbtn_Click(object sender, EventArgs e)
        {
            switch (ope_rator)
            {
                case "+":
                    num2 = num1 + double.Parse(box.Text);
                    num1 = 0;
                    break;
                case "-":
                    num2 = num1 - double.Parse(box.Text);
                    num1 = 0;
                    break;
                case "x":
                    num2 = num1 * double.Parse(box.Text);
                    num1 = 0;
                    break;
                case "/":
                    num2 = num1 / double.Parse(box.Text);
                    num1 = 0;
                    break;
            }
            box.Text = num2.ToString();
            eq_btn = true;
        }

        private void fivebtn_Click(object sender, EventArgs e)
        {
            if (eq_btn)
            {
                box.Clear();
                eq_btn = false;
            }
            box.Text = box.Text + fivebtn.Text;
        }
    }
}
