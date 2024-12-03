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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

            //listname.Items.Add("saker");
            //listnumber.Items.Add("1111");
            //listood.Items.Add("22");
            //listgins.Items.Add("ذكر");
        }

        bool Isnumber(string num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < '0' || num[i] > '9')
                    return false;
            }
            return true;
        }

        bool IsString(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= 'a' && str[i] <= 'z'))
                    continue;
                else
                    return false;
            }
            return true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool t = true;
            if ((textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "")&&( radioButton1.Checked || radioButton1.Checked))
            {
                
                if (!Isnumber(textBox1.Text))
                {
                    t = false;
                    MessageBox.Show("Test is string");
                    textBox1.Text = "";
                }

                if (!IsString(textBox2.Text))
                {
                    t = false;
                    MessageBox.Show("Test is number");
                    textBox2.Text = "";
                }

                if (!Isnumber(textBox3.Text))
                {
                    t = false;
                    MessageBox.Show("Test is string");
                    textBox3.Text = "";
                }

                if (t)
                {
                    listnumber.Items.Add(textBox1.Text);
                     listname.Items.Add(textBox2.Text);
                     listood.Items.Add(textBox3.Text);
                     if (radioButton1.Checked)
                      listgins.Items.Add(radioButton1.Text);

                    else if (radioButton2.Checked)
                      listgins.Items.Add(radioButton2.Text);
                     
                
                      textBox1.Text = textBox2.Text = textBox3.Text = "";
                      radioButton1.Checked = radioButton2.Checked = false;
                }

            }
            else
                MessageBox.Show("error");
        }

        void selected(ListBox sel)
        {
            listname.SelectedIndex = listood.SelectedIndex = listgins.SelectedIndex = listnumber.SelectedIndex = sel.SelectedIndex;
        }
        private void listnumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected((ListBox)sender);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButton1.Checked)
            //    listgins.Items.Add(radioButton1.Text);
            //else
            //    listgins.Items.Remove(radioButton1.Text);
            //if (radioButton1.Checked==false)
            //    listgins.Items.Remove(radioButton1.Text);
                
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButton2.Checked)
            //    listgins.Items.Add(radioButton2.Text);
            //else
            //    listgins.Items.Remove(radioButton2.Text);
             //if (radioButton2.Checked==false)
             //    listgins.Items.Remove(radioButton2.Text);
                
        }

        private void listname_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected((ListBox)sender);
        }

        private void listood_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected((ListBox)sender);
        }

        private void listgins_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected((ListBox)sender);
        }

        private void btdel_Click(object sender, EventArgs e)
        {
            int n=listnumber.SelectedIndex;
            if (n != -1)
            {
                listname.Items.RemoveAt(n);
                listnumber.Items.RemoveAt(n);
                listood.Items.RemoveAt(n);
                listgins.Items.RemoveAt(n);
            }
        }

        private void btdelall_Click(object sender, EventArgs e)
        {
            int n=listnumber.Items.Count-1;
            while ( n>= 0)
            {
                listname.Items.RemoveAt(n);
                listnumber.Items.RemoveAt(n);
                listood.Items.RemoveAt(n);
                listgins.Items.RemoveAt(n);
                n--;

            }
        }
      
      
        public void update(string number, string name, string age, string gins)
        {
           int n = listnumber.SelectedIndex;
            if (n != -1)
            {
                listnumber.Items[n] = number;
                listname.Items[n] = name;
                listood.Items[n] = age;
                listgins.Items[n] = gins;

                if (radioButton1.Text==gins)
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            int select = listnumber.SelectedIndex;
                FormMyForm12 F = new FormMyForm12(this);
                F.update(listnumber.Items[select].ToString(), listname.Items[select].ToString(), listood.Items[select].ToString(),radioButton1.Checked);
                F.Show();
  
        }
    }
}
