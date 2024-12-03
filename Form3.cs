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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        TextBox txb1 = new TextBox(), txb2 = new TextBox(), txb3 = new TextBox(), txbR = new TextBox();
        Label lab1 = new Label(), lab2 = new Label(), lab3 = new Label(), labR = new Label(), labop1 = new Label(), labop2 = new Label();
        ComboBox cmbop1 = new ComboBox(), cmbop2 = new ComboBox();
        Button btResult = new Button(), btCleas = new Button();
        private void Form3_Load(object sender, EventArgs e)
        {
            this.Size = new Size(500, 500); 



            ///////////lable//////////////
            lab1.Location = new Point(150, 20);
            lab1.Text = " : العدد الاول ";
            lab1.Font =new  Font(Font.FontFamily,10F, FontStyle.Bold);

            lab2.Location = new Point(150, 120);
            lab2.Text = " : العدد الثاني ";
            lab2.Font = new Font(Font.FontFamily, 10F, FontStyle.Bold);

            lab3.Location = new Point(150, 220);
            lab3.Text = " : العدد الثالث ";
            lab3.Font = new Font(Font.FontFamily, 10F, FontStyle.Bold);

            labop1.Location = new Point(150, 70);
            labop1.Text = " : العمليه الاول ";
            labop1.Font = new Font(Font.FontFamily, 10F, FontStyle.Bold);
            labop1.ForeColor = Color.Green;


            labop2.Location = new Point(150, 170);
            labop2.Text = " : العمليه الثانيه ";
            labop2.Font = new Font(Font.FontFamily, 10F, FontStyle.Bold);
            labop2.ForeColor = Color.Green;

            labR.Location = new Point(150, 270);
            labR.Text = " : النتاتج ";
            labR.Font = new Font(Font.FontFamily, 10F, FontStyle.Bold);
            labR.ForeColor = Color.Green;
           



            //////////// textBox ////////////////

            txb1.Location = new Point(10, 20);

            txb2.Location = new Point(10, 120);

            txb3.Location = new Point(10, 220);

            txbR.Location = new Point(10, 270);
            txbR.ReadOnly = true;

            ////////////comboBox//////////////////

            string[] op = { "+", "-", "*", "/" };
            cmbop1.Location = new Point(10, 70);
            cmbop1.Size = new Size(100, 40);
            cmbop1.Items.AddRange(op);
            cmbop1.Font = new Font(Font.FontFamily, 10F, FontStyle.Bold);
            cmbop1.ForeColor = Color.Green;
            cmbop1.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbop2.Location = new Point(10, 170);
            cmbop2.Size = new Size(100, 40);
            cmbop2.Items.AddRange(op);
            cmbop2.Font = new Font(Font.FontFamily, 10F, FontStyle.Bold);
            cmbop2.ForeColor = Color.Green;
            cmbop2.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbop1.Text = cmbop2.Text = "+";

            ////////////////button////////////////////

            btResult.Size = new Size(90, 40);
            btResult.Location = new Point(150, 330);
            btResult.Text = " حساب";
            btResult.Font = new Font(Font.FontFamily, 12F, FontStyle.Bold);
            btResult.ForeColor = Color.Black;
            btResult.BackColor = Color.Green;
            btResult.Click += Result;



            btCleas.Size = new Size(90, 40);
            btCleas.Location = new Point(10, 330);
            btCleas.Text = " مسح";
            btCleas.Font = new Font(Font.FontFamily, 12F, FontStyle.Bold);
            btCleas.ForeColor = Color.Black;
            btCleas.BackColor = Color.Red;
            btCleas.Click += Clear;


            //////////// form add /////////////

            this.Controls.Add(lab1);
            this.Controls.Add(lab2);
            this.Controls.Add(lab3);
            this.Controls.Add(labR);
            this.Controls.Add(labop1);
            this.Controls.Add(labop2);


            this.Controls.Add(txb1);
            this.Controls.Add(txb2);
            this.Controls.Add(txb3);
            this.Controls.Add(txbR);

            this.Controls.Add(cmbop1);
            this.Controls.Add(cmbop2);

            this.Controls.Add(btResult);
            this.Controls.Add(btCleas);

        }
        void Clear(object s,EventArgs e)
        {
            txb1.Text = txb2.Text = txb3.Text = txbR.Text = null;
            cmbop1.Text = cmbop2.Text = "+";

        }

        double opertion_Result(string op,double n1,double n2)
        {
            switch (op)
            {
                case "+": return n1 + n2;
                case "-": return n1 - n2;
                case "*": return n1 * n2;
                case "/": return n1 / n2;
                default: return 0.0;
            }

        }

        bool check()
        {
            if (txb1.Text == "")
            {
                MessageBox.Show(" العدد الاول فارغ");
                txb1.Focus();
                return false;
            }
            if (txb2.Text == "")
            {
                MessageBox.Show(" العدد الثاني فارغ");
                txb2.Focus();
                return false;
            }
            if (txb3.Text == "")
            {
                MessageBox.Show(" العدد الثالث فارغ");
                txb3.Focus();
                return false;
            }
            return true;
        }
        void Result(object s, EventArgs e)
        {
            double Res;
            if (check())
            {
                 if (cmbop2.SelectedItem == "*" || cmbop2.SelectedItem == "/")
                {
                    Res = opertion_Result(cmbop2.SelectedItem.ToString(), double.Parse(txb2.Text), double.Parse(txb3.Text));
                    txbR.Text = opertion_Result(cmbop1.SelectedItem.ToString(), Res, double.Parse(txb1.Text)).ToString();

                }
                else
                {
                    Res = opertion_Result(cmbop1.SelectedItem.ToString(), double.Parse(txb1.Text), double.Parse(txb2.Text));
                    txbR.Text = opertion_Result(cmbop2.SelectedItem.ToString(), Res, double.Parse(txb3.Text)).ToString();
                }

            }


        }
    }
}
