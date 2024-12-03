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
    public partial class Show_Student_Data_Form : Form
    {
        public Show_Student_Data_Form()
        {
            InitializeComponent();
        }

        private void Show_Student_Data_Form_Load(object sender, EventArgs e)
        {
            Width = button1.Right + 20;
        }
        public void Set_Data(string n, string c, string s, string l, string ll, string p)
        {
            label1.Text = n;
            label2.Text = c;
            label3.Text = s;
            label4.Text = l;
            label5.Text = ll;
            if (p != null)
                pictureBox1.Image = Image.FromFile(p);
            else
                pictureBox1.Image = Image.FromFile(@"C:\Users\SAKERALFAQIH\Documents\icon\ايقونات اساسية للتصميم والبرمجة\ايقونات اساسية للتصميم\ايقونات الدالة للتواصل\ion_ios_personadd.png");
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == ">>")
            {

                Width = label1.Right + label1.Width + 40;
                button1.Text = "<<";
            }
            else
            {
                Width = button1.Right + 20;
                button1.Text = ">>";
            }
        }
       
    }
}
