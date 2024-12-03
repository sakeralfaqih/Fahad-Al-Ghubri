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
    public partial class Student_set_Data_Form : Form
    {

        Student_Data[] std;
        string name = "";
        public Student_set_Data_Form(Student_Data[] s ,string n)
        {
            InitializeComponent();
            std = s;
            name = n;
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Student_set_Data_Form_Load(object sender, EventArgs e)
        {
            if (name != "")
                label1.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_Data.count++;
            std[Student_Data.count]=new Student_Data();
            string l1="";
            string l2="";
            foreach(RadioButton r in groupBox1.Controls.OfType<RadioButton>())
            {
                if(r.Checked)
                    l1=r.Text;
            }
             foreach(RadioButton r in groupBox2.Controls.OfType<RadioButton>())
            {
                if(r.Checked)
                    l2=r.Text;
            }

             std[Student_Data.count].Set_Student_Data(label1.Text.ToString(), textBox1.Text.ToString(), textBox2.Text.ToString(), l1, l2);

             if (MessageBox.Show("هل تريد حفظ البيانات", "save", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                 this.Close();
        }
    }
}
