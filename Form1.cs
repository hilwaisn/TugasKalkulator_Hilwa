using System;
using System.Data;
using System.Windows.Forms;

namespace TugasKalkulator_Hilwa
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        double temp;
        char oper;
        bool oper1;
        private void Calculator_Load(object sender, EventArgs e)
        {
            bersih();
            fokus();
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtinput.Text += button.Text;
        }

        private void fokus()
        {
            txthasil.Focus();
            txthasil.Select(txthasil.Text.Length, 1);
        }

        private void bersih()
        {
            txthasil.Text = "";
            txtinput.Text = "";
            temp = 0;
            oper = ' ';
            oper1 = false;
        }
        private void btnAngka_Click(object sender, EventArgs e)
        {
            Button btnAng = (Button)sender;
            if (txthasil.Text == "0")
            {
                txthasil.Clear();
            }
            if (oper == '=')
            {
                oper = ' ';
                //oper1 = false;
                txthasil.Clear();
                temp = 0;
            }
            txthasil.Text = txthasil.Text + btnAng.Text;
            fokus();
        }
        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button op = (Button)sender;
            if (oper1 == false)
            {
                if (txtinput.Text == "")
                {
                    temp = Convert.ToDouble(txthasil.Text);
                }
                else
                {
                    if (oper == '+')
                    {
                        temp = temp + Convert.ToDouble(txthasil.Text);
                    }
                    else if (oper == '-')
                    {
                        temp = temp - Convert.ToDouble(txthasil.Text);
                    }
                    else if (oper == '÷')
                    {
                        temp = temp / Convert.ToDouble(txthasil.Text);
                    }
                    else if (oper == '×')
                    {
                        temp = temp * Convert.ToDouble(txthasil.Text);
                    }
                }
            }
            if (op.Text == "=") 
            {
                txtinput.Text = "";
                txthasil.Text = temp.ToString();
            }
            else
            {
                txtinput.Text = temp.ToString() + op.Text;
                txthasil.Text = "0";
            }
            oper = Convert.ToChar(op.Text);
            fokus();
        }
        private void btnHapus_Click(object sender, EventArgs e)
        {
            txthasil.Text = txthasil.Text.Remove(txthasil.Text.Length - 1);

            if ((txthasil.Text == "") || (txthasil.Text == "-"))
            {
                txthasil.Text = "0";
            }
            if (oper == '=')
            {
                temp = 0;
                oper1 = false;
                oper = ' ';
            }
            fokus();
        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            bersih();
            fokus();
        }
        
        private void btnC_Click(object sender, EventArgs e)
        {
            bersih();
            fokus();
        }

        private void btnSD_Click(object sender, EventArgs e)
        {
            if (oper1)
            {
                if (oper == '+')
                {
                    temp +=+ Convert.ToDouble(txthasil.Text);
                }
                else if (oper == '-')
                {
                    temp -= Convert.ToDouble(txthasil.Text);
                }
                else if (oper == '÷')
                {
                    temp /= Convert.ToDouble(txthasil.Text);   
                }
                else if (oper == '×')
                {
                    temp *= Convert.ToDouble(txthasil.Text);
                }
                txtinput.Text = "";
                txthasil.Text = temp.ToString();
                oper = '=';
                fokus();
            }
        }
        private void btnKoma_Click(object sender, EventArgs e)
        {
            if (txthasil.Text.Contains(".") == false)
            {
                txthasil.Text = txthasil.Text + ",";
            }
            if (temp == '=')
            {
                bersih();
            }
            fokus();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            txthasil.Text = (Convert.ToDouble(txthasil.Text) * -1).ToString();
            fokus();
        }

        private void btn2x_Click(object sender, EventArgs e)
        {
            double inputValue = Convert.ToDouble(txthasil.Text);
            double akarKuadrat = Math.Sqrt(inputValue);
            txthasil.Text = akarKuadrat.ToString();
            fokus();
        }

        private void btnPersen_Click(object sender, EventArgs e)
        {
            txthasil.Text = (Convert.ToDouble(txthasil.Text) % 2).ToString();
            fokus();
        }

        private void btnx2_Click(object sender, EventArgs e)
        {
            double inputValue = Convert.ToDouble(txthasil.Text);
            double duaKuadrat = inputValue*inputValue;
            txthasil.Text = duaKuadrat.ToString();
            fokus();
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            double inputValue = Convert.ToDouble(txthasil.Text);
            double satuBagi = 1/inputValue;
            txthasil.Text = satuBagi.ToString();
            fokus();
        }
    }
}