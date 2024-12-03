using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Data;
namespace Fahad_Al_Ghubri
{
    public class MyTools:Form
    {
        public TextBox tbone, tbtwo, tbResult;
       public Button btResult , btclose;
       public Label lpone , lptwo, lpResult , lpopertion , lpequl;
        public MyTools()
        {
            lpone = new Label();
            lptwo = new Label();
            lpResult = new Label();
            lpopertion = new Label();
            lpequl = new Label();

             tbone = new TextBox();
             tbtwo = new TextBox();
            tbResult = new TextBox();

            btResult = new Button();
            btclose = new Button();
            //////////////////label////////////////////////
            lpone.Text = "العدد الاول";
            lpone.Location = new Point(340, 30);
            lpone.Font = new Font(Font.FontFamily, 11, FontStyle.Italic);

            lpopertion.Location = new Point(285, 72);
            lpopertion.Font = new Font(Font.FontFamily, 11, FontStyle.Bold);
            lpopertion.ForeColor = Color.Black;
            lpopertion.AutoSize = true;

            lptwo.Text = "العدد الثاني";
            lptwo.Location = new Point(180, 30);
            lptwo.Font = new Font(Font.FontFamily, 11, FontStyle.Italic);

            lpequl.Text = "=";
            lpequl.Location = new Point(130, 72);
            lpequl.Font = new Font(Font.FontFamily, 11, FontStyle.Bold);
            lpequl.ForeColor = Color.Black;
            lpequl.AutoSize = true;


            lpResult.Text = "الناتج";
            lpResult.Location = new Point(50, 30);
            lpResult.Font = new Font(Font.FontFamily, 11, FontStyle.Italic);

            //////////////////////textBox///////////////////
            tbone.Location = new Point(315, 70);
            tbone.KeyPress += tbone_KeyPress;

            tbtwo.Location = new Point(170, 70);
             tbtwo.KeyPress += tbone_KeyPress;

            tbResult.Location = new Point(10, 70);
            tbResult.ReadOnly = true;

            btResult.Location = new Point(315, 130);
            btResult.Size = new Size(94, 35);
            btResult.Text = "حساب";
            btResult.BackColor = Color.Green;
            btResult.Click += btResult_click;

            btclose.Location = new Point(10, 130);
            btclose.Size = new Size(94, 35);
            btclose.Text = "اغلاق";
            btclose.BackColor = Color.Red;
             btclose.Click += btclose_Click;
        }

        public void ControlsAdd(Form FT)
        {
            FT.Controls.Add(lpone);
            FT.Controls.Add(lpopertion);
            FT.Controls.Add(lptwo);
            FT.Controls.Add(lpResult);
            FT.Controls.Add(lpequl);

            FT.Controls.Add(tbone);
            FT.Controls.Add(tbtwo);
            FT.Controls.Add(tbResult);

            FT.Controls.Add(btResult);
            FT.Controls.Add(btclose);

        }
        public void opertionForm(string op)
        {
            lpopertion.Text = op;

        }
        void btResult_click(object s, EventArgs e)
        {

            if (tbone.Text.Trim() != "")
                if (tbtwo.Text.Trim() != "")
                {
                    switch (lpopertion.Text)
                    {
                        case "+": tbResult.Text = (Convert.ToInt32(tbone.Text) + Convert.ToInt32(tbtwo.Text)).ToString(); break;
                        case "-": tbResult.Text = (Convert.ToInt32(tbone.Text) - Convert.ToInt32(tbtwo.Text)).ToString(); break;
                        case "*": tbResult.Text = (Convert.ToInt32(tbone.Text) * Convert.ToInt32(tbtwo.Text)).ToString(); break;
                        case "/": tbResult.Text = (Convert.ToInt32(tbone.Text) / Convert.ToInt32(tbtwo.Text)).ToString(); break;
                    }
                }
                else
                    MessageBox.Show("العدد الثاني فاضي");
            else
                MessageBox.Show("العدد الاول فاضي");
        }

        


        void tbone_KeyPress(object s, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;
            else
                e.Handled = false;

        }

        void btclose_Click(object s, EventArgs e)
        {

            this.Close();

        }
    }
}
