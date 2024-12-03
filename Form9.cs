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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        Label lpone = new Label(), lptwo = new Label(), lpResult = new Label(), lpopertion = new Label(), lpequl = new Label();
        Button btsum = new Button(), btmult = new Button(), btdivide = new Button(), btsub = new Button();
        TextBox tbone = new TextBox(), tbtwo = new TextBox(), tbResult = new TextBox();
        Button btResult = new Button(), btclose = new Button();

        Panel multoprtion = new Panel();

        private void Form9_Load(object sender, EventArgs e)
        {
            this.Size = new Size(449, 100);
            //this.Size = new Size(449, 250);
            //////////button opertion ////////////
            btsum.Location = new Point(1, 1);
            btsum.Size = new Size(94, 35);
            btsum.Text = "جمع";
            btsum.Click += btsum_click;

            btsub.Location = new Point(109, 1);
            btsub.Size = new Size(94, 35);
            btsub.Text = "طرح";
            btsub.Click += btsub_click;

            btmult.Location = new Point(224, 1);
            btmult.Size = new Size(94, 35);
            btmult.Text = "ضرب";
            btmult.Click += btmult_click;

            btdivide.Location = new Point(338, 1);
            btdivide.Size = new Size(94, 35);
            btdivide.Text = "قسمة";
            btdivide.Click += btdivide_click;

            //////////label  panel //////////////
            lpone.Text = "العدد الاول";
            lpone.Location = new Point(340, 10);
            lpone.Font = new Font(Font.FontFamily, 11, FontStyle.Italic);

            //lpopertion.Text = "no";
            lpopertion.Location = new Point(285, 55);
            lpopertion.Font = new Font(Font.FontFamily, 11, FontStyle.Bold);
            lpopertion.ForeColor = Color.Black;
            lpopertion.AutoSize = true;

            lptwo.Text = "العدد الثاني";
            lptwo.Location = new Point(180, 10);
            lptwo.Font = new Font(Font.FontFamily, 11, FontStyle.Italic);

            lpequl.Text = "=";
            lpequl.Location = new Point(130, 52);
            lpequl.Font = new Font(Font.FontFamily, 11, FontStyle.Bold);
            lpequl.ForeColor = Color.Black;
            lpequl.AutoSize = true;


            lpResult.Text = "الناتج";
            lpResult.Location = new Point(50, 10);
            lpResult.Font = new Font(Font.FontFamily, 11, FontStyle.Italic);


            ///////////textbox panel and button panel //////////////

            tbone.Location = new Point(315, 50);
            tbone.KeyPress += tbone_KeyPress;
            
            tbtwo.Location = new Point(170, 50);
            tbtwo.KeyPress += tbone_KeyPress;

            tbResult.Location = new Point(10, 50);
            tbResult.ReadOnly = true;

            btResult.Location = new Point(315, 100);
            btResult.Size = new Size(94, 35);
            btResult.Text = "حساب";
            btResult.BackColor = Color.Green;
            btResult.Click += btResult_click;

            btclose.Location = new Point(10, 100);
            btclose.Size = new Size(94, 35);
            btclose.Text = "اغلاق";
            btclose.BackColor = Color.Red;
            btclose.Click += btclose_Click;
            

            ////////////////add panel////////////////
           
            multoprtion.Location = new Point(1, 70);
            multoprtion.Size = new Size(435, 140);
            multoprtion.Visible = false;
            multoprtion.Controls.Add(lpone);
            multoprtion.Controls.Add(lpopertion);
            multoprtion.Controls.Add(lptwo);
           
            multoprtion.Controls.Add(tbone);
            multoprtion.Controls.Add(lpResult);
            multoprtion.Controls.Add(tbtwo);
            multoprtion.Controls.Add(lpequl);
            multoprtion.Controls.Add(tbResult);

            multoprtion.Controls.Add(btResult);
            multoprtion.Controls.Add(btclose);

            ////////////add from //////////
            this.Controls.Add(btsum);
            this.Controls.Add(btsub);
            this.Controls.Add(btmult);
            this.Controls.Add(btdivide);
            this.Controls.Add(multoprtion);
        }

        
        void Transferoperation(Color color, string opretion)
        {
            this.Height = multoprtion.Height * 2 - 30;
            multoprtion.BackColor = color;
            lpopertion.Text = opretion;
            tbone.Text = tbtwo.Text = tbResult.Text = null;
            multoprtion.Visible = true;

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

        void btsum_click(object s, EventArgs e)
        {    
            Transferoperation(Color.Aquamarine, "+");
        }

        void btsub_click(object s, EventArgs e)
        { 
            Transferoperation(Color.Cyan, "-");
        }

        void btmult_click(object s, EventArgs e)
        {
            Transferoperation(Color.DarkOrange, "*");
        }

        void btdivide_click(object s, EventArgs e)
        {
            Transferoperation(Color.DarkOliveGreen, "/");
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
            multoprtion.Visible = false;
            this.Height =multoprtion.Height-30;
           // this.Height = Height /2;
            tbone.Text = tbtwo.Text = tbResult.Text = null;

        }
    }
}
