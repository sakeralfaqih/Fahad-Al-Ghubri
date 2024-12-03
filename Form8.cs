using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Fahad_Al_Ghubri
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        Button play1 = new Button(), play2 = new Button();
        PictureBox pbplay1 = new PictureBox(), pbplay2 = new PictureBox();
        Thread thplay1;
        private void Form8_Load(object sender, EventArgs e)
        {
            this.Size= new Size(937,526);

            play1.Location = new Point(796, 380);
            play1.Text = "play1";
            play1.Click += play1_click;

            play2.Location = new Point(796, 430);
            play2.Text = "play2";
            play2.Click += play2_click;

            pbplay1.Image=new Bitmap(@"C:\Users\SAKERALFAQIH\Documents\icon\60-video-production-icons\PNG\256 px\film-distribution.png");
            pbplay1.Location = new Point(43, 59);
            pbplay1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbplay1.Size = new Size(60, 34);
            

            pbplay2.Image = new Bitmap(@"C:\Users\SAKERALFAQIH\Documents\icon\60-video-production-icons\PNG\256 px\film-distribution.png");
            pbplay2.Location = new Point(43, 130);
            pbplay2.Size = new Size(60, 34);
            pbplay2.SizeMode = PictureBoxSizeMode.StretchImage;

            ////////add form//////////
            this.Controls.Add(play1);
            this.Controls.Add(play2);
            this.Controls.Add(pbplay1);
            this.Controls.Add(pbplay2);

        }

        void thplay()
        {
            for (int i = 0; i < 1000; i++)
            {
               
                Invoke((Action)(() => { pbplay1.Left += 5; }));

                if (pbplay1.Left > 849)
                    break;
                System.Threading.Thread.Sleep(200);
                
            }

        }
        void play1_click(object s, EventArgs e)
        {
            thplay1 = new Thread(thplay);
            thplay1.Start();
        }
        void play2_click(object s, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                pbplay2.Left += 5;
                if (pbplay2.Left > 849)
                    break;
                Thread.Sleep(200);
                //System.Threading.Thread.Sleep(200);
                Application.DoEvents();

            }
        }
       
    }
}
