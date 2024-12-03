using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahad_Al_Ghubri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            this.Text = "calculator";
            label1.Name = "lbone";
            label1.Text = "Enter the number one :";
            label1.ForeColor = Color.Blue;
            label1.Size =new System.Drawing.Size(100, 10);
            label1.Location = new System.Drawing.Point(21, 16);

            label2.Name = "lbtwo";
            label2.Text = "Enter the number two :";
            label2.ForeColor = Color.Blue;
            label2.Location = new System.Drawing.Point(21, 64);

            tbone.Text = null;
            tbtwo.Text = null;
            label4.Text = "Result :";
            label4.ForeColor = Color.Blue;
            label4.Location = new System.Drawing.Point(21, 102);


            tbone.Location = new System.Drawing.Point(150, 16);
            tbtwo.Location = new System.Drawing.Point(150, 61);
            tbResult.Name = "tbResult";
            tbResult.ReadOnly = true;
            tbResult.Location = new System.Drawing.Point(150, 102);


            btsum.Name = "btsum";
            btsum.Text = "sum";
            btsum.ForeColor = Color.Blue;
            btsum.Enabled = false;
            btsum.Tag = "+";
            btsum.Size = new System.Drawing.Size(80, 40);
            btsum.Location = new System.Drawing.Point(24, 155);

            btmult.Name = "btmult";
            btmult.Text = "mult";
            btmult.ForeColor = Color.Blue;
            btmult.Enabled = false;
            btmult.Tag = "*";
            btmult.Size = new System.Drawing.Size(80, 40);
            btmult.Location = new System.Drawing.Point(138, 155);


            btsub.Text = "sub";
            btsub.ForeColor = Color.Blue;
            btsub.Enabled = false;
            btsub.Tag = "-";
            btsub.Size = new System.Drawing.Size(80, 40);
            btsub.Location = new System.Drawing.Point(24, 210);


            btdiv.Text = "div";
            btdiv.ForeColor = Color.Blue;
            btdiv.Enabled = false;
            btdiv.Tag = "/";
            btdiv.Size = new System.Drawing.Size(80, 40);
            btdiv.Location = new System.Drawing.Point(138, 210);


            Button clear = new Button();
            clear.Text = "clear";
            clear.Tag = "clear";
            clear.ForeColor = Color.Blue;
            clear.Size = new System.Drawing.Size(80, 40);
            clear.Location = new System.Drawing.Point(24, 260);
            clear.Click += clears;
            this.Controls.Add(clear);

        }
        public void clears(object sender,EventArgs e )
        {
            tbone.Text = null;
            tbtwo.Text = null;
            tbResult.Text = null;
            
        }
        void oprationfals()
        {
            if (tbone.Text != "" && tbtwo.Text != "")
            {
                btsum.Enabled = true;
                btmult.Enabled = true;
                btdiv.Enabled = true;
                btsub.Enabled = true;
            }
            else
            {
                btsum.Enabled = false;
                btmult.Enabled = false;
                btdiv.Enabled = false;
                btsub.Enabled = false;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            oprationfals();
        }
        private void tbtwo_TextChanged(object sender, EventArgs e)
        {
            oprationfals();
        }
        bool exeption1()
        {
            if (tbone.Text == "")
            {
                MessageBox.Show("Enter the number one");
                tbone.Focus();
                return false;
            }

            if (tbtwo.Text == "")
            {
                MessageBox.Show("Enter the number two");
                tbtwo.Focus();
                return false;
            }
               
            return true;

        }
        void exeption3()
        {
            if (tbone.Text == "")
            {
                MessageBox.Show("Enter the number one");
                tbone.Focus();
            }

            else if (tbtwo.Text == "")
            {
                MessageBox.Show("Enter the number two");
                tbtwo.Focus();
               
            }
            else
                tbResult.Text = (Double.Parse(tbone.Text) + Double.Parse(tbtwo.Text)).ToString();

        }
     
        void exeption2(string t)
        {
            double x, y;
            try
            {
                x= Double.Parse(tbone.Text);
              
            }
            catch
            {
                MessageBox.Show("Erorr In number one");
                tbone.Focus();
                return ;
            }
            try
            {
                y = Double.Parse(tbtwo.Text);

            }
            catch
            {
                MessageBox.Show("Erorr In number two");
                tbtwo.Focus();
                return ;
                

            }

            //tbResult.Text = (y+x).ToString();
            switch (t)
            {
                case "+":
                    tbResult.Text = (x + y).ToString();
                    break;
                case "-":
                    tbResult.Text = (x - y).ToString();
                    break;
                case "*":
                    tbResult.Text = (x * y).ToString();
                    break;
                case "/":
                    tbResult.Text = (x / y).ToString();
                    break;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
           // if (exeption1())
            // tbResult.Text = (Double.Parse(tbone.Text) + Double.Parse(tbtwo.Text)).ToString();
           exeption2(btsum.Tag.ToString()); 
           // exeption3();
            
        }


        void keypress(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar!=8))
                e.Handled = true;
        }
        private void tbone_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypress(e);
        }
        private void tbtwo_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypress(e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            exeption2(btmult.Tag.ToString()); 
        }

        private void btsub_Click(object sender, EventArgs e)
        {
            exeption2(btsub.Tag.ToString()); 
        }

        private void btdiv_Click(object sender, EventArgs e)
        {
            exeption2(btdiv.Tag.ToString()); 
        }

        private void tbResult_TextChanged(object sender, EventArgs e)
        {

        }

       
        

        
    }
}
