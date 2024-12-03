using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Fahad_Al_Ghubri
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            Random R = new Random();

            for (int i = 0; i < 10; i++)
            {
                string n = R.Next(100).ToString();
                listbnumber.Items.Add(n);
            }
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox2.RightToLeft = RightToLeft.Yes;
            radioButton1.RightToLeft = RightToLeft.Yes;
            radioButton2.RightToLeft = RightToLeft.Yes;
            radioButton3.RightToLeft = RightToLeft.Yes;
            radioButton4.RightToLeft = RightToLeft.Yes;
            radioButton5.RightToLeft = RightToLeft.Yes;
            radioButton6.RightToLeft = RightToLeft.Yes;
            groupBox3.RightToLeft = RightToLeft.Yes;

            radioButton6.Checked = false;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;

            this.Height = button12.Top + button12.Height + 40;
        }
       
        ////////////////////////
        
        bool Isnumoric(string value)
        {
            if (value == " ")
                return false;
            for (int i = 0; i < value.Length; i++)
                if (value[i] < '0' || value[i] > '9')
                    return false;

            return true;
        }
        ////////////////////////
        bool RepetitionCheck(ListBox Repet ,string value)
        {

            for (int i = 0; i < Repet.Items.Count ; i++)

                    if (Repet.Items[i].ToString() == value)
                        return false;

            return true;    
        }
        ////////////////////////
        private void btadd_Click(object sender, EventArgs e)
        {
            if (Isnumoric(tbadd.Text.Trim()) && RepetitionCheck(listbnumber, tbadd.Text.Trim()))
            {
                listbnumber.Items.Add(tbadd.Text);
                
            }
            else
                MessageBox.Show("no number");
            tbadd.Text = null;
            
        }

        void AddlistResult(ListBox value)
        {
           
            //for (int i = 0; i < value.SelectedItems.Count; i++)
            //{
            //    listbresult.Items.Add(value.SelectedItems[i]);
            //}

            //int n=value.SelectedItems.Count;
            //for (int i = 0; i <n ; i++)
            //    value.Items.Remove(value.SelectedItem);
              //listbresult.Items.Remove(value.SelectedItems[i]);
            while (value.SelectedIndex != -1)
            {
                if(RepetitionCheck(listbresult,value.SelectedItem.ToString()))
                     listbresult.Items.Add(value.SelectedItem);
                value.Items.RemoveAt(value.SelectedIndex);
            }
        }
       
        private void btaddsel_Click(object sender, EventArgs e)
        {
            if (RBeven.Checked)
                AddlistResult(listbnumber);
            else if(RBodd.Checked)
                AddlistResult(listbnumber);
            else if (RBpra.Checked)
                AddlistResult(listbnumber);
            else
                MessageBox.Show("no number selectedItme");

            RBeven.Checked = false;
            RBodd.Checked = false;
            RBpra.Checked = false;
           
        }

        private void RBeven_CheckedChanged(object sender, EventArgs e)
        {
            
           
            if (RBeven.Checked)
            {
                for (int i = 0; i < listbnumber.Items.Count; i++)
                {
                    if (Convert.ToInt32(listbnumber.Items[i]) % 2 == 0)
                    {
                        // listbnumber.SelectedIndices.Add(i);
                        // listbnumber.SelectedIndex = i;
                        listbnumber.SelectedItem = listbnumber.Items[i];
                        //listbnumber.SelectedIndex = listbnumber.Items.IndexOf(listbnumber.Items[i]);
                        //listbnumber.SelectedItems.Add(listbnumber.Items[i]);
                    }
                }
                 if (listbnumber.SelectedItems.Count < 0)
                        MessageBox.Show("no event number");
            }
                else
                 listbnumber.SelectedIndex = -1;
            //listbnumber.SelectedItems.Clear();  
        }

        private void RBodd_CheckedChanged(object sender, EventArgs e)
        {
            if (RBodd.Checked)
            {
                for (int i = 0; i < listbnumber.Items.Count; i++)
                {
                    if (Convert.ToInt32(listbnumber.Items[i]) % 2 != 0)
                    {
                        // listbnumber.SelectedIndices.Add(i);
                        // listbnumber.SelectedIndex = i;
                       // listbnumber.SelectedItem = listbnumber.Items[i];
                        //listbnumber.SelectedIndex = listbnumber.Items.IndexOf(listbnumber.Items[i]);
                        listbnumber.SelectedItems.Add(listbnumber.Items[i]);
                    }
                }
                if (listbnumber.SelectedItems.Count < 0)
                    MessageBox.Show("no odd number");
            }
            else
                listbnumber.SelectedIndex = -1;
            //listbnumber.SelectedItems.Clear();  
        }

        private void RBpra_CheckedChanged(object sender, EventArgs e)
        {
            if (RBpra.Checked)
            {
                bool p;
                for (int i = 0; i < listbnumber.Items.Count; i++)
                {
                     p = true;
                    int num=Convert.ToInt32(listbnumber.Items[i]);
                    for (int j = 2; j < num; j++)
                        if (num % j == 0)
                        {
                            p = false;
                            break;
                        }
                    if(p)
                        listbnumber.SelectedIndex = i;

                }

                if (listbnumber.SelectedIndex == -1)
                    MessageBox.Show("no per number");
             }
                else
                listbnumber.SelectedIndex = -1;
            //listbnumber.SelectedItems.Clear(); 
        }

        private void btaddall_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < listbnumber.Items.Count; i++)
            //{
            //    listbresult.Items.Add(listbnumber.Items[i]);
            //}
            //listbnumber.Items.Clear();
            listbresult.Items.AddRange(listbnumber.Items);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        void sortedlist(ListBox sort )
        {
            //sort.Sorted = true;
            int c = sort.Items.Count;
            for (int i = 0; i <c; i++)
            {
         
               for (int j = i + 1; j<c; j++)
                {
                    int n = Convert.ToInt32(sort.Items[i]);
                    int m = Convert.ToInt32(sort.Items[j]);
                    if (n > m)
                    {
                        
                        int t = n;
                        sort.Items[i]= m;
                        sort.Items[j] = t;
                    }
                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
               sortedlist(listbnumber);
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            int v = listbnumber.SelectedItems.Count;
           
            if(radioButton2.Checked)
            {
                for (int i = listbnumber.SelectedIndex; i < listbnumber.SelectedIndex +v- 1; i++)
                {
                    for (int j = i + 1; j < listbnumber.SelectedIndex + v; j++)
                    {

                        int n = Convert.ToInt32(listbnumber.Items[i]);
                        int m = Convert.ToInt32(listbnumber.Items[j]);

                        if (n > m)
                        {
                            int t = n;
                            listbnumber.Items[i] = m;
                            listbnumber.Items[j] = t;
                        }
                    }
                    listbnumber.SelectedIndex = i;
                }

            }
                  
                
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            sortedlist(listbresult);
        }

        void Reverse(ListBox Revers)
        {
            int temp = 0;
            int count = Revers.Items.Count;
            int j = 0;
            for (int i = count - 1; i >= count / 2; i--)
            {

                temp = Convert.ToInt32(Revers.Items[j]);
                Revers.Items[j] = Revers.Items[i];
                Revers.Items[i] = temp;
                j++;


            }

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButton3.Checked)
            {
                Reverse(listbnumber);

            }
        }

        void move_Reverse(ListBox Revers)
        {
           // Reverse(Revers);
            
            //for (int i = 0; i <Revers.Items.Count; i++)
            //{
            //    listbresult.Items.Add(Revers.Items[i]);             
            //}
            //Revers.Items.Clear();

            int n=Revers.Items.Count;
            for (int i = 0; i <n; i++)
            {
               if(RepetitionCheck(listbresult,Revers.Items[Revers.Items.Count-1-i].ToString()))
                    listbresult.Items.Add(Revers.Items[Revers.Items.Count-1-i]);
             
            }
            Revers.Items.Clear();
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            move_Reverse(listbnumber);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton6.Checked)
                Reverse(listbresult);
        }
        void delete(ListBox del)
        {
             int n=del.SelectedItems.Count;
             for (int i = 0; i < n; i++)
                 del.Items.Remove(del.SelectedItem);
             //while (del.SelectedIndex != -1)
             //{

             //    del.Items.RemoveAt(del.SelectedIndex);
             //}
        }

        void deleteall(ListBox del)
        {
            int n = del.Items.Count;
            for (int i = 0; i < n; i++)
                del.Items.Remove(del.Items[del.Items.Count-1]);
            //del.Items.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            delete(listbnumber);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteall(listbnumber);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete(listbresult);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deleteall(listbresult);
        }
     

        private void button5_Click(object sender, EventArgs e)
        {

           
            //listbresult.SelectedItem = textBox1.Text;
           // listbnumber.SelectedIndex = listbnumber.Items.IndexOf(textBox1.Text);
            listbnumber.SelectedIndex = -1;
            listbnumber.SelectedItems.Add(textBox1.Text.Trim());
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listbnumber.SelectedItems.Remove(textBox2.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listbnumber.SelectedIndices.Remove(Convert.ToInt32( textBox3.Text));
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                if (listbnumber.Items.Count > 0)
                {
                    for (int i = 0; i < listbnumber.Items.Count; i++)
                        listbnumber.SelectedIndex = i;
                }
            }
            else
                listbnumber.SelectedIndex = -1;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
               listbnumber.SelectedIndex = -1;
        }

       

        private void button8_Click(object sender, EventArgs e)
        {
            textBox4.Text = listbnumber.Items.Count.ToString();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox5.Text = listbnumber.SelectedItems.Count.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox6.Text = (listbnumber.Items.Count - listbnumber.SelectedItems.Count).ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listbnumber.SelectedIndex = -1;
            listbresult.SelectedIndex = -1;
            RBeven.Checked = false;
            RBodd.Checked = false;
            RBpra.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.Text == "V")
            {
             
                this.Height = groupBox3.Top + groupBox3.Height + 40;
                button12.Text = "^";
            }
            else
            {
                button12.Text = "V";
                this.Height = button12.Top + button12.Height + 40;
               
            }

        }
       


    }
}
