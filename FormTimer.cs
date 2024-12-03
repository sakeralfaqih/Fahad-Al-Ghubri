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
    public partial class FormTimer : Form
    {
        public FormTimer()
        {
            InitializeComponent();
        }

        Button btstart = new Button(), btstop = new Button(),btclear = new Button();
        Label lbh = new Label(), lbm = new Label(), lbs = new Label();
        Timer timer = new Timer();
        private void FormTimer_Load(object sender, EventArgs e)
        {
            this.Size = new Size(400, 400);

            lbh.Location = new Point(100, 90);
            lbh.Text = "00 :";
            lbh.Font = new Font(Font.FontFamily, 22F, FontStyle.Bold);
            lbh.AutoSize = true;

            lbm.Location = new Point(170, 90);
            lbm.Text = "00 :";
            lbm.Font = new Font(Font.FontFamily, 22F, FontStyle.Bold);
            lbm.AutoSize = true;

            lbs.Location = new Point(240, 90);
            lbs.Text = "00";
            lbs.Font = new Font(Font.FontFamily, 22F, FontStyle.Bold);
            lbs.AutoSize = true;

            btstart.Location = new Point(240, 220);
            btstart.Size = new Size(90, 30);
            btstart.Text = "Start";
            btstart.Font = new Font(Font.FontFamily, 12F, FontStyle.Bold);
            btstart.BackColor = Color.Green;
            btstart.Click += btstart_Click;

            btstop.Location = new Point(100, 220);
            btstop.Size = new Size(90, 30);
            btstop.Text = "Stop";
            btstop.Font = new Font(Font.FontFamily, 12F, FontStyle.Bold);
            btstop.BackColor = Color.Red;
            btstop.Click += btstop_Click;

            btclear.Location = new Point(170, 280);
            btclear.Size = new Size(90, 30);
            btclear.Text = "Clear";
            btclear.Font = new Font(Font.FontFamily, 12F, FontStyle.Bold);
            btclear.BackColor = Color.Red;
            btclear.Click += btclear_Click;

            timer.Enabled = false;
            timer.Tick += timer_Tick;
           
           
            /////////////add fromtimer ///////////
            this.Controls.Add(lbh);
            this.Controls.Add(lbm);
            this.Controls.Add(lbs);
            this.Controls.Add(btstart);
            this.Controls.Add(btstop);
            this.Controls.Add(btclear);
           
        }
        int h = 0, m = 0, sc = 0;
        void timer_Tick(object sender, EventArgs e)
        {
            sc++;
            if (sc <= 9)
            {
                
                lbs.Text = "0" + sc.ToString();
            }
            else
            {

                lbs.Text = sc.ToString();
            }

            if (sc == 59 )
            {
               
                sc = 0;
                m++;
                if (m > 9)
                    lbm.Text = m.ToString() + ":";
                else
                    lbm.Text = "0" + m.ToString() +":";
            }

            if (m == 59)
            {

                m = 0;
                h++;
                if (h > 9)
                    lbh.Text = h.ToString() + ":";
                else
                    lbh.Text = "0" + h.ToString() + ":";
            }
        }
        void btstart_Click(object s, EventArgs e)
        {
           // timer.Enabled = true;
            timer.Start();

        }
        void btstop_Click(object s, EventArgs e)
        {
            // timer.Enabled = false;
            timer.Stop(); 

        }
        void btclear_Click(object s, EventArgs e)
        {
           
            timer.Stop();
            sc = m = h = 0;
            lbm.Text = lbh.Text = "00 :";
            lbs.Text = "00";
        }

    }
}
