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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        TextBox txBox = new TextBox();
        Button btsum = new Button(), btadd = new Button(), btdel = new Button(), btcloes = new Button();
        ListBox lblist = new ListBox();
        private void Form4_Load(object sender, EventArgs e)
        {
            this.Size=new Size(489, 441);


            /////////////textbox/////////////
            txBox.Location = new Point(350, 70);
            txBox.Size = new Size(110, 20);
            txBox.KeyPress += txBox_KeyPress;
            txBox.TextChanged += txBox_textChanged;

            /////////button //////////////

            btadd.Location = new Point(370, 100);
            btadd.Size = new Size(93, 38);
            btadd.Text = "أضافة";
            btadd.ForeColor = Color.Black;
            btadd.BackColor = Color.White;
            btadd.Click += btadd_click;
            btadd.Enabled = false;


            btdel.Location = new Point(370, 150);
            btdel.Size = new Size(93, 38);
            btdel.Text = "حذف";
            btdel.ForeColor = Color.White;
            btdel.BackColor = Color.Red;
            btdel.Click += btdel_click;
            btdel.Enabled = false;

            btsum.Location = new Point(370, 200);
            btsum.Size = new Size(93, 38);
            btsum.Text = "مجموع";
            btsum.ForeColor = Color.White;
            btsum.BackColor = Color.Green;
            btsum.Click += btsum_click;
            btsum.Enabled = false;


            btcloes.Location = new Point(370, 250);
            btcloes.Size = new Size(93, 38);
            btcloes.Text = "اغلاق";
            btcloes.ForeColor = Color.White;
            btcloes.BackColor = Color.Red;
            btcloes.Click += btcloes_click;
            ///////////listbox//////////////

            lblist.Location = new Point(100, 100);
            lblist.Size = new Size(120, 186);

            ////////////// add form //////////
            this.Controls.Add(txBox);
            this.Controls.Add(btadd);
            this.Controls.Add(btdel);
            this.Controls.Add(btsum);
            this.Controls.Add(btcloes);
            this.Controls.Add(lblist);

        }
        void txBox_textChanged(object s, EventArgs e)
        {
            if (txBox.Text.Trim() != "")
                btadd.Enabled = btdel.Enabled = btsum.Enabled = true;
            else
                btadd.Enabled = btdel.Enabled = btsum.Enabled = false;
        }

        void txBox_KeyPress(object s, KeyPressEventArgs e)
        {
            if((e.KeyChar< 48 || e.KeyChar >57)&&(e.KeyChar!=8))
                e.Handled=true;
            else
                e.Handled=false;

        }
            
           
        void btadd_click(object s, EventArgs e)
        {
       
          
            if (txBox.Text.Trim() != "")
            {
                lblist.Items.Add(txBox.Text);
                
                txBox.Clear();
                txBox.Focus();
            }
            else
                MessageBox.Show("النص فاضي");
        }
      
        void btdel_click(object s, EventArgs e)
        {

            if (lblist.Items.Count > 0 )
            {
               // lblist.Items.Remove(lblist.Items[lblist.Items.Count-1]);
                lblist.Items.RemoveAt(lblist.Items.Count - 1);
              
            }
            else
                MessageBox.Show("لا توجد اعداد");

        }
        void btsum_click(object s, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < lblist.Items.Count; i++)
            {
                sum += int.Parse(lblist.Items[i].ToString());
            }
            txBox.Text = sum.ToString();
        }
        void btcloes_click(object s, EventArgs e)
        {
            this.Close();
        }
    }
}
