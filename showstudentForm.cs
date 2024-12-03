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
    public partial class showstudentForm : Form
    {
        student[] temp;
        public showstudentForm(student[] t)
        {
            InitializeComponent();
            temp = t;
        }
       
        private void showstudentForm_Load(object sender, EventArgs e)
        {
            listBox2.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox3.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public void setValues(string id, string name, string date, string photo)
        {

            listBox1.Items.Add(id);
            listBox2.Items.Add(name);
            listBox3.Items.Add(date);

        }
        public void set_student_agien()
        {
          
            if (student.count >= 0)
            {
                for (int i = 0; i <= student.count; i++)
                {
                    listBox1.Items.Add(temp[i].Id);
                    listBox2.Items.Add(temp[i].Name);
                    listBox3.Items.Add(temp[i].Date);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox2.SelectedIndex = listBox3.SelectedIndex = ((ListBox)sender).SelectedIndex;
            if( ((ListBox)sender).SelectedIndex!=-1)
            pictureBox1.Image = Image.FromFile(temp[((ListBox)sender).SelectedIndex].Photo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addstudentForm t = new addstudentForm(this, temp);
            int n=listBox1.SelectedIndex;
            if (n != -1)
                t.Update_Date(listBox1.Items[n].ToString(), listBox2.Items[n].ToString(), listBox3.Items[n].ToString(), temp[n].Photo);
            t.Show();
            
        }
        public void Update_Date(string id, string name, string date, string photo)
        {
            int n = listBox1.SelectedIndex;
            if (n != -1)
            {
                listBox1.Items[n] = id;
                listBox2.Items[n] = name;
                listBox3.Items[n] = date;
                temp[n].Id = id;
                temp[n].Name = name;
                temp[n].Date = date;
                temp[n].Photo = photo;
                pictureBox1.Image = Image.FromFile(temp[n].Photo);

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             int n = listBox1.SelectedIndex;
             if (n != -1)
             {
                 listBox1.Items.RemoveAt(n);
                 listBox2.Items.RemoveAt(n);
                 listBox3.Items.RemoveAt(n);
                 pictureBox1.Image = null;

                 int j = 0;
                  for (int i = 0; i <= student.count; i++)
                 {
                     if (temp[i].Id != temp[n].Id)
                     {
                         temp[j].setItmes(temp[i].Id, temp[i].Name, temp[i].Date, temp[i].Photo);
                         j++;
                     }
                     
                 }
                  student.count--;
             }
        }

    }
}
