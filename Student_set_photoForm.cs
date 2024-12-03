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
    public partial class Student_set_photoForm : Form
    {
        Student_Data temp;
        
        public Student_set_photoForm(Student_Data t)
        {
            InitializeComponent();
            temp = t;
        }

        private void Student_set_photoForm_Load(object sender, EventArgs e)
        {
            button1.Text = "اختييار الصوره ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             OpenFileDialog file = new OpenFileDialog();         
            file.Filter = "Image file(*.jpg)|*.png";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(file.FileName);
                temp.Photo = file.FileName;
            }
            else
                temp.Photo = null;

            button1.Text = "تم ";
            if (MessageBox.Show("هل تريد حفظ الصوره", "save", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();

        }
    }
}
