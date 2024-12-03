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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        Button btTop_inc = new Button(), btTop_dic = new Button(), btleft_inc = new Button(), btleft_dic = new Button();
        Button btwidth_inc = new Button(), btwidth_dic = new Button(), btheight_inc = new Button(), btheight_dic = new Button();
        PictureBox play = new PictureBox();
        private void Form6_Load(object sender, EventArgs e)
        {
            ///////// from ///////////
            this.Size = new Size(816,526);
            this.Name = "تحريك  button";
            
          // * /////////// button //////////// *//
            /////// left //////////////
            btleft_inc.Location = new Point(730, 220);
            btleft_inc.Size = new Size(43, 28);
            btleft_inc.Text = ">";
            btleft_inc.Font = new Font(Font.FontFamily, 12F, FontStyle.Bold);
            btleft_inc.BackColor = Color.DarkCyan;
            btleft_inc.Click += btleft_inc_click;

            btleft_dic.Location = new Point(510, 220);
            btleft_dic.Size = new Size(43, 28);
            btleft_dic.Text = "<";
            btleft_dic.Font = new Font(Font.FontFamily, 12F, FontStyle.Bold);
            btleft_dic.BackColor = Color.DarkCyan;
            btleft_dic.Click += btleft_dic_click;
           
            ////////// top//////////////////

            btTop_inc.Location = new Point(620, 290);
            btTop_inc.Size = new Size(43, 28);
            btTop_inc.Text = "v";
            btTop_inc.Font = new Font(Font.FontFamily, 12F, FontStyle.Bold);
            btTop_inc.BackColor = Color.DarkCyan;
            btTop_inc.Click += btTop_inc_click;

            btTop_dic.Location = new Point(620, 150);
            btTop_dic.Size = new Size(43, 28);
            btTop_dic.Text = "^";
            btTop_dic.Font = new Font(Font.FontFamily, 14F, FontStyle.Bold);
            btTop_dic.BackColor = Color.DarkCyan;
            btTop_dic.Click += btTop_dic_click;

           ///////////height////////////

            btheight_inc.Location = new Point(620, 190);
            btheight_inc.Size = new Size(43, 28);
            btheight_inc.Text = "+";
            btheight_inc.Font = new Font(Font.FontFamily, 14F, FontStyle.Bold);
            btheight_inc.BackColor = Color.DarkCyan;
            btheight_inc.Click += btheight_inc_click; 


            btheight_dic.Location = new Point(620, 250);
            btheight_dic.Size = new Size(43, 28);
            btheight_dic.Text = "-";
            btheight_dic.Font = new Font(Font.FontFamily, 14F, FontStyle.Bold);
            btheight_dic.BackColor = Color.DarkCyan;
            btheight_dic.Click += btheight_dic_click;

            ///////width ////////////

            btwidth_inc.Location = new Point(670, 220);
            btwidth_inc.Size = new Size(43, 28);
            btwidth_inc.Text = "+";
            btwidth_inc.Font = new Font(Font.FontFamily, 12F, FontStyle.Bold);
            btwidth_inc.BackColor = Color.DarkCyan;
            btwidth_inc.Click += btwidth_inc_click;

            btwidth_dic.Location = new Point(570, 220);
            btwidth_dic.Size = new Size(43, 28);
            btwidth_dic.Text = "-";
            btwidth_dic.Font = new Font(Font.FontFamily, 12F, FontStyle.Bold);
            btwidth_dic.BackColor = Color.DarkCyan;
            btwidth_dic.Click += btwidth_dic_click;

           /////////play////////
            play.Location = new Point(10, 10);
            play.Size = new Size(80, 50);
            play.Image = Image.FromFile(@"C:\Users\SAKERALFAQIH\Documents\60-video-production-icons\PNG\256 px\film-distribution.png");
            play.SizeMode = PictureBoxSizeMode.StretchImage;
           

            /////////////add form /////////////
            this.Controls.Add(btleft_inc);
            this.Controls.Add(btwidth_inc);
            this.Controls.Add(btTop_dic);
            this.Controls.Add(btheight_inc);
            this.Controls.Add(btheight_dic);
            this.Controls.Add(btTop_inc);
            this.Controls.Add(btwidth_dic);
            this.Controls.Add(btleft_dic);
            this.Controls.Add(play);

        }
        void btleft_inc_click(object s, EventArgs e)
        {
            play.Left += 5;
        }

        void btleft_dic_click(object s, EventArgs e)
        {
            play.Left -= 5;
        }

        void btTop_inc_click(object s, EventArgs e)
        {
            play.Top += 5;
        }

        void btTop_dic_click(object s, EventArgs e)
        {
            play.Top -= 5;
        }

        void btheight_inc_click(object s, EventArgs e)
        {
            play.Height += 5;
        }

        void btheight_dic_click(object s, EventArgs e)
        {
            play.Height -= 5;
        }

        void btwidth_inc_click(object s, EventArgs e)
        {
            play.Width += 5;
        }

        void btwidth_dic_click(object s, EventArgs e)
        {
            play.Width -= 5;
        }
        
    
    
        
    }
}
