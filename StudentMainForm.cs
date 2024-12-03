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
    public partial class StudentMainForm : Form
    {
        public StudentMainForm()
        {
            InitializeComponent();
        }

        Student_Data[] students = new Student_Data[50];
        Student_set_Data_Form SDF;
        Student_set_photoForm SPF;
        Show_Student_Data_Form SSF;
        bool f = true;
        private void StudentMainForm_Load(object sender, EventArgs e)
        {

        }

        private void اضافةبياناتالطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (SDF == null || SDF.IsDisposed)
                {
                    //if (SSF == null || SSF.IsDisposed)
                    //    SSF = new Show_Student_Data_Form();
                    f = false;
                    SDF = new Student_set_Data_Form(students, textBox1.Text);
                   
                    SDF.Show();
                }
                else
                    SDF.Focus();
            }
        }

        private void صورةالطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f == false)
            {
                f = true;
                textBox1.Text = "";
                if (SPF == null || SPF.IsDisposed)
                {
                    SPF = new Student_set_photoForm(students[Student_Data.count]);
                    SPF.Show();
                }
                else
                    SPF.Focus();
                
            }
        }

        private void عرضالبياناتToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            if (SSF == null || SSF.IsDisposed)
            {
                SSF = new Show_Student_Data_Form();
                if (textBox1.Text == "")
                {
                    if (Student_Data.count >= 0)  
                        SSF.Set_Data(students[Student_Data.count].Name, students[Student_Data.count].College, students[Student_Data.count].Section, students[Student_Data.count].Level1, students[Student_Data.count].Level2, students[Student_Data.count].Photo);
                    SSF.Show();
                }
                else
                {
                    bool b = true;
                    if (Student_Data.count >= 0) 
                    for (int i = 0; i <= Student_Data.count; i++)
                    {
                        if (students[i].Name == textBox1.Text)
                        {
                            b = false;
                           SSF.Set_Data(students[i].Name, students[i].College, students[i].Section, students[i].Level1, students[i].Level2, students[i].Photo);
                           break;
                        }
                    }
                    if(b)
                        MessageBox.Show("الطالب غير موجود");
                    else
                    SSF.Show();
                }

               
                    
            }
            else
                SSF.Focus();
        }
    }
}
