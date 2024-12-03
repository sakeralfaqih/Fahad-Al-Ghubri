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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        TextBox tbsize = new TextBox(), tbnumber = new TextBox(), tbsum = new TextBox();
        Label lbsize = new Label(), lbnumber = new Label();
        Button btaddlist = new Button(), btdelitem = new Button(), btshowitem = new Button(), 
            btsumitem = new Button(),tbdel=new Button();
        ListBox ltblist = new ListBox();

        
        string[] array;
        int count = 0;
       

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Size=new Size(469, 530);
            this.BackColor = Color.DarkCyan;
            ///////label /////////
            lbsize.Text = ": حجم المصفوفة ";
            lbsize.Location = new Point(270, 20);
            lbsize.Font = new Font(Font.FontFamily, 11F, FontStyle.Italic);
            lbsize.ForeColor = Color.Black;

            lbnumber.Text = ": ادخل العدد ";
            lbnumber.Location = new Point(100, 20);
            lbnumber.Font = new Font(Font.FontFamily, 11F, FontStyle.Italic);
            lbnumber.ForeColor = Color.Black;

            ///////textbox//////////
            tbsize.Location=new Point(270, 50);
            tbsize.KeyPress += tb_KeyPress;
            tbsize.TextChanged += size_array;

            tbnumber.Location = new Point(100, 50);
            tbnumber.KeyPress += tb_KeyPress;

            tbsum.Location = new Point(100, 420);
            tbsum.ReadOnly = true;

            //////////////button ///////////
            btaddlist.Text = "اضافه للمصفوفه";
            btaddlist.Location = new Point(100, 80);
            btaddlist.Size = new Size(270, 30);
            btaddlist.Click += add_click;

            btdelitem.Text = "حذف العناصر";
            btdelitem.Location = new Point(270, 120);
            btdelitem.Size = new Size(100, 30);
            btdelitem.Click += del_item;

            btshowitem.Text = "عرض العناصر";
            btshowitem.Location = new Point(100, 120);
            btshowitem.Size = new Size(100, 30);
            btshowitem.Click += show_item;

            btsumitem.Text = "المجموع";
            btsumitem.Location = new Point(270, 420);
            btsumitem.Size = new Size(100, 30);
            btsumitem.Click += sum_item;

            ////////////// listbox///////////////////////
            ltblist.Location = new Point(100, 160);
            ltblist.Size = new Size(270, 250);

            /////////////add form/////

            this.Controls.Add(lbsize);
            this.Controls.Add(lbnumber);
            this.Controls.Add(tbsize);
            this.Controls.Add(tbnumber);
            this.Controls.Add(btaddlist);
            this.Controls.Add(btdelitem);
            this.Controls.Add(btshowitem);
            this.Controls.Add(ltblist);
            this.Controls.Add(btsumitem);
            this.Controls.Add(tbsum);
        }
        void tb_KeyPress(object s, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        void size_array(object s, EventArgs e)
        {
            if(tbsize.Text.Trim()!="")
            array = new string[Convert.ToInt32(tbsize.Text)];
        }
        
        void add_click(object s, EventArgs e)
        {
            
            if (Convert.ToInt32(tbsize.Text) > count)
            {
                if (tbnumber.Text.Trim() != "")
                {
                    array[count] = tbnumber.Text;
                    count++;
                }
                else
                    MessageBox.Show("ادخل رقم");
            }
            else
                MessageBox.Show(" تجاوزت حجم المصفوفه");
            tbnumber.Clear();
            tbnumber.Focus();
        }

        void show_item(object s, EventArgs e)
        {
            ltblist.Items.Clear();

            if (count > 0)
            {
                ltblist.Items.AddRange(array);
                count = 0;
                array = new string[0];
                tbsize.Clear();
                tbsum.Clear();
            }
        }
        void del_item(object s, EventArgs e)
        {
            if(ltblist.Items.Count>0)
            {
                ltblist.Items.Remove(ltblist.Items[ltblist.Items.Count-1]);
            }
            else
                MessageBox.Show("  المصفوفه فاضي");
        }

        void sum_item(object s, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < ltblist.Items.Count; i++)
            {
                sum += Convert.ToInt32(ltblist.Items[i]);
            }
            tbsum.Text = sum.ToString();

        }
    }
}
