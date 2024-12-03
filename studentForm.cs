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
    public partial class studentForm : Form
    {
        public studentForm()
        {
            InitializeComponent();
        }

        bool close = true;
        addstudentForm AddStudent;
        showstudentForm ShowStudent;
        student[] students = new student[50];
        int count = 0;
        private void studentForm_Load(object sender, EventArgs e)
        {

        }

        private void اضافةطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close = true;
            if (AddStudent == null || AddStudent.IsDisposed)
            {
                if (ShowStudent == null || ShowStudent.IsDisposed)
                {
                    ShowStudent = new showstudentForm(students);
                    ShowStudent.set_student_agien();
                }

               // 
                AddStudent = new addstudentForm(ShowStudent, students);
                
                AddStudent.Show();

            }
            else
                AddStudent.Focus();
        }

        private void عرضالطلابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close = false;
            if (ShowStudent == null || ShowStudent.IsDisposed)
            {
                ShowStudent = new showstudentForm(students);
                ShowStudent.set_student_agien();
                ShowStudent.Show();
            }
            else
                ShowStudent.Show();
        }

        private void اغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (ShowStudent != null )
            //{
            //    ShowStudent.Close();
            //}
            if (AddStudent == null || AddStudent.IsDisposed)
                close = false;
            if (ShowStudent == null || ShowStudent.IsDisposed)
                close = true;

            if (close == true)
            {
                AddStudent.Close();
                close = false;
            }
            else
            {         
                   ShowStudent.Close();
                   close = true;
            }
        }

        private void اغلاقالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudent.Close();
            AddStudent.Close();
        }
    }
}
