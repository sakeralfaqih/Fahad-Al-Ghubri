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
    public partial class FormMyForm12 : Form
    {
         Form12 F;
        public FormMyForm12(Form12 f)
        {
            InitializeComponent();
              F = f;
        }
       
        private void FormMyForm12_Load(object sender, EventArgs e)
        {

        }

      //public  string getname()
      //  {
      //      return textBox2.Text;
      //  }
      //public string getnumber()
      //  {
      //      return textBox1.Text;
      //  }
      //public string getage()
      //  {
      //      return textBox3.Text;
      //  }
      //public string getgins()
      //  {
      //      if(radioButton1.Checked)
      //          return radioButton1.Text;
      //      else if (radioButton2.Checked)
      //          return radioButton2.Text;
      //      return "Nothings";
      //  }

      public void update(string number, string name, string age, bool gins)
      {
          
          textBox1.Text=number;
          textBox2.Text = name;
          textBox3.Text = age;
          if (gins)
          {
              radioButton1.Checked = gins;
          }
          else
          {
              radioButton2.Checked = gins;
          }

      }
  
      private void button1_Click(object sender, EventArgs e)
      {
          string gins= radioButton1.Checked?radioButton1.Text:radioButton2.Text;
          F.update(textBox1.Text, textBox2.Text, textBox3.Text, gins);
          this.Close();
      }

      private void textBox1_TextChanged(object sender, EventArgs e)
      {

      }
    }
}
