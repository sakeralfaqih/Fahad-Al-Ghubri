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
    public partial class addstudentForm : Form
    {
        showstudentForm temp;
        student[] std;
        public addstudentForm(showstudentForm t, student[] te)
        {
            InitializeComponent();
            temp = t;
            std = te;
        }

        private void addstudentForm_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        OpenFileDialog file = new OpenFileDialog();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            file.Filter = "Image file(*.jpg)|*.png";
            if (file.ShowDialog()== DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(file.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "اضافه")
            {
                student.count++;
                std[student.count] = new student();
                temp.setValues(number.Text, tbname.Text, dateTime.Text, file.FileName);
                std[student.count].setItmes(number.Text, tbname.Text, dateTime.Text, file.FileName);
            }
            else
                temp.Update_Date(number.Text, tbname.Text, dateTime.Text, file.FileName);
            

        }
        //private void button1_Click2(object sender, EventArgs e)
        //{

        //    temp.Update_Date(number.Text, tbname.Text, dateTime.Text, file.FileName);

        //}
        public void Update_Date(string id, string name, string date, string photo)
        {
            button1.Text = "تعديل";
            //button1.Click += button1_Click2;
            number.Text = id;
            tbname.Text = name;
            dateTime.Text = date;
            file.FileName = photo;
            if(photo!="")
                pictureBox1.Image = Image.FromFile(file.FileName);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
