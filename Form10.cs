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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            button2.Text = "طول النص المحدد";
            button3.Text = "عدد الكلمات";
            button4.Text = "حذف النص المحدد";
            button5.Text = "الغاء التحدد";
            button6.Text = "نسخ";
            button7.Text = "قص";
            button16.Text = "تراجع";
            button9.Text = "طول النص كامل من دون فراغات";
            button10.Text = "طول النص المحدد من دون فراغات";

            groupBox1.Text = "سيبدال";
            groupBox1.RightToLeft = RightToLeft.Yes;
            label1.Text = "النص الجديد";
            label5.Text = "النص القديم";
            button11.Text = "استبدال";

            groupBox2.Text = "البحث";
            groupBox2.RightToLeft = RightToLeft.Yes;
            label2.Text = "النص المراد البحث عنه";
            button12.Text = "بحث";
            button13.Text = "البحث عن التالي";
            button14.Text = "البحث عن السابق";

            button15.Text = "لصق";
            button8.Text = "تنظيف";
           


            label3.Text = "احرف الكلمه المحدد";
            button17.Text = "عرض";

            label4.Text = "كلمات الجمله المحدد";
            button18.Text = "عرض";


            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox1.Text = "saker ahmed abdh ali alfqih";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.TextLength.ToString();
           // textBox2.Text = textBox1.Text.Trim().Length.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.SelectionLength.ToString();
           // textBox3.Text = textBox1.SelectedText.Length.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = 1;
            try
            {
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if (textBox1.Text[i] == ' ' && textBox1.Text[i + 1] != ' ')
                        count++;
                }
            }
            catch { }
            textBox4.Text = count.ToString();

            //string[] word = textBox1.Text.Split(' ');
            //textBox4.Text =( word.Length - 1).ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);
            }
            else
                MessageBox.Show("لا يوجد نص محدد");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.SelectionLength = 0;
        }
       
       
       

        string TextCopy = " ";
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
               // textBox1.Copy();
                TextCopy = textBox1.SelectedText;
                
                
            }
            else
                MessageBox.Show("قم بتحديد نص");
        }

        
        /// ///////////

        const int wordsize = 50;
        int wordcount=-1;
        string[] TextCut = new string[wordsize];
        int[] TextStart = new int[wordsize];
        string[] swap = new string[wordsize];
        int SwapCount = -1;
        int[] Priority_back = new int[wordsize];
        int Prioritycount = -1;
        /// /////////
        
        
        private void button7_Click(object sender, EventArgs e)
        {

            if (textBox1.SelectionLength > 0)
            {
                //textBox1.Cut();
                wordcount++;
                
                TextCut[wordcount]= textBox1.SelectedText;
                TextStart[wordcount] = textBox1.SelectionStart;
                textBox1.SelectedText=null;
                TextCopy = " ";
            }
            else
                MessageBox.Show("قم بتحديد نص");
        }

        /// 

   
        /// 
        private void button15_Click(object sender, EventArgs e)
        {
            
            if (TextCopy!= " ")
            {
                listBox1.Items.Add(TextCopy);
                Prioritycount++;
                Priority_back[Prioritycount] = 0;
            }
            else if (wordcount >= 0)
            {
                
                listBox1.Items.Add(TextCut[wordcount]);
                Prioritycount++;
                Priority_back[Prioritycount] = 1;
                
            }
            else
                MessageBox.Show("لا يوجد نص");
        }

        
        private void button16_Click(object sender, EventArgs e)
        {
            if (Prioritycount >= 0)
            {
                if (Priority_back[Prioritycount] == 2)
                {

                    textBox1.Text= textBox1.Text.Replace(swap[SwapCount], TextCut[wordcount]);
                     //textBox1.Text = textBox1.Text.Remove(TextStart[wordcount], swap[SwapCount].Length);
                     //textBox1.SelectionStart = TextStart[wordcount];
                     //textBox1.SelectedText = TextCut[wordcount];
                    TextStart[wordcount] = -1;
                    TextCut[wordcount] = null;
                    swap[SwapCount] = null;
                    wordcount--;
                    Prioritycount--;
                    SwapCount--;

                }
                else if (listBox1.Items.Count != 0)
                {


                    if (Priority_back[Prioritycount] == 0 || Priority_back[Prioritycount] == 1 && Priority_back[Prioritycount - 1] == 1)
                    {
                        listBox1.Items.Remove(listBox1.Items[listBox1.Items.Count - 1]);
                        Prioritycount--;
                    }

                    else if (wordcount >= 0 && Priority_back[Prioritycount] == 1)
                    {
                        listBox1.Items.Remove(listBox1.Items[listBox1.Items.Count - 1]);
                        textBox1.SelectionStart = TextStart[wordcount];
                        textBox1.SelectedText = TextCut[wordcount];
                        TextStart[wordcount] = -1;
                        TextCut[wordcount] = null;
                        wordcount--;
                        Prioritycount--;
                    }
                }
            }
            else
                MessageBox.Show("القائمة فاضي");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(textBox5.Text.Trim()!="")
            {
                if (textBox7.Text != "" && textBox1.SelectionLength>0)
                    MessageBox.Show("قم بتحديد طريقه واحده الاستبدال");

                else if(textBox7.Text!="")
                {
                    
                    string word = textBox1.Text;
                    int t=1;
                    for (int i = 0; i < textBox1.Text.Length; i++)
                    {
                        t = 1;
                        int j=0;
                        while (word[i + j] != textBox7.Text[j])
                        {
                            t = 0;
                            break;
                        }
                        if (t == 1)
                        {
                            wordcount++;
                            Prioritycount++;
                            SwapCount++;
                            TextCut[wordcount] = textBox7.Text;
                            TextStart[wordcount] =i;
                            swap[SwapCount] = textBox5.Text;
                            Priority_back[Prioritycount] = 2;
                            textBox1.Text = textBox1.Text.Remove(i, textBox7.Text.Length);
                            textBox1.SelectionStart = i;
                            textBox1.SelectedText = textBox5.Text;
                            break;
                        }
                    }

                    if( t==0)
                        MessageBox.Show("النص القديم غير موجود");

                    // textBox1.Text = textBox1.Text.Replace(textBox5.Text, textBox7.Text);
                 
                }

                else if( textBox1.SelectionLength>0)
                {
                    wordcount++;
                    Prioritycount++;
                    SwapCount++;
                    TextCut[wordcount] = textBox1.SelectedText;
                    TextStart[wordcount] = textBox1.SelectionStart;
                    swap[wordcount] = textBox5.Text;
                    Priority_back[Prioritycount] = 2;
                    textBox1.SelectedText = textBox5.Text;
                    // textBox1.Text = textBox1.Text.Replace(textBox5.Text, textBox7.Text);
                }  
            }
            else
                MessageBox.Show(" لا يوجد نص الاستبدال");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //foreach (ListBox C in this.Controls.OfType<ListBox>())
            //{
            //    C.Items.Clear();
            //}
           
            
            
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            if (textBox6.Text.Trim() != "" && textBox1.Text!="")
            {
                int index=textBox1.Text.IndexOf(textBox6.Text);
                if (index > -1)
                {
                    textBox1.SelectionStart = index;
                    textBox1.SelectionLength = textBox6.Text.Length;
                    textBox1.Focus();
                }
                else
                    MessageBox.Show("no found text ");
            }
            else
                MessageBox.Show("no found text search");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox6.Text.Trim() != "" && textBox1.Text != "")
            {
                int index = textBox1.Text.IndexOf(textBox6.Text,textBox1.SelectionLength+textBox1.SelectionStart);
                if (index > -1)
                {
                    textBox1.SelectionStart = index;
                    textBox1.SelectionLength = textBox6.Text.Length;
                    textBox1.Focus();
                }
                else
                    MessageBox.Show("no found text ");
            }
            else
                MessageBox.Show("no found text search");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox6.Text.Trim() != "" && textBox1.Text != "")
            {
                int index = textBox1.Text.LastIndexOf(textBox6.Text, textBox1.SelectionStart - textBox1.SelectionLength);
                if (index > -1)
                {
                    textBox1.SelectionStart = index;
                    textBox1.SelectionLength = textBox6.Text.Length;
                    textBox1.Focus();
                }
                else
                    MessageBox.Show("no found text ");
            }
            else
                MessageBox.Show("no found text search");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                for (int i = 0; i < textBox1.SelectionLength; i++)
                {
                  //  listBox2.Items.Add(textBox1.Text[textBox1.SelectionStart + i]);
                    listBox2.Items.Add(textBox1.SelectedText[i]);
                }


            }
        }
        string text;
        private void button18_Click(object sender, EventArgs e)
        {
           
            if (textBox1.SelectionLength > 0)
            {
                
                //for (int i = 0; i < textBox1.SelectionLength; i++)
                //{

                //    if (textBox1.SelectedText[i].ToString() != " ")
                //    {
                //        text += textBox1.SelectedText[i].ToString();
                       
                //    }
                //    else
                //    {
                //        listBox3.Items.Add(text);
                //        text = null;
                //    }
                //}
                //listBox3.Items.Add(text);


                string[] word = textBox1.SelectedText.Split(' ');
                listBox3.Items.AddRange(word);
            }
        }
        
    }
}
