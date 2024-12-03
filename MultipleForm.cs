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
    public partial class MultipleForm : Form
    {
        public MultipleForm()
        {
            InitializeComponent();
        }
      
       
        
        Button btsum = new Button(), btmult = new Button(), btdivide = new Button(), btsub = new Button();
        MyTools SumForm, MultForm, SubForm, DiviForm;

        private void MultipleForm_Load(object sender, EventArgs e)
        {
           
            this.Size = new Size(449, 100);
            //this.Size = new Size(449, 250);
            //////////button opertion ////////////
            btsum.Location = new Point(1, 1);
            btsum.Size = new Size(94, 35);
            btsum.Text = "جمع";
            btsum.Click += btsum_click;

            btsub.Location = new Point(109, 1);
            btsub.Size = new Size(94, 35);
            btsub.Text = "طرح";
            btsub.Click += btsub_click;

            btmult.Location = new Point(224, 1);
            btmult.Size = new Size(94, 35);
            btmult.Text = "ضرب";
           btmult.Click += btmult_click;

            btdivide.Location = new Point(338, 1);
            btdivide.Size = new Size(94, 35);
            btdivide.Text = "قسمة";
            btdivide.Click += btdivide_click;


            ///////////////add main Form /////////////
            this.Controls.Add(btsum);
            this.Controls.Add(btsub);
            this.Controls.Add(btmult);
            this.Controls.Add(btdivide);

        }


        bool FormIsdisposed(Form FT)
        {
            if ( FT == null || FT.IsDisposed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void btsum_click(object s, EventArgs e)
        {
            if (FormIsdisposed(SumForm))
            {
                SumForm = new MyTools();
               
                SumForm.Size = new Size(449, 250);
                SumForm.BackColor = Color.YellowGreen;
                SumForm.opertionForm("+");
                SumForm.ControlsAdd(SumForm);
                SumForm.Location = new Point(10, 10);
                SumForm.Show(this);
            }
            else
                SumForm.Show();
        }
         
        void btsub_click(object s, EventArgs e)
        {
            if (FormIsdisposed(SubForm))
            {
                SubForm = new MyTools();
                SubForm.Size = new Size(449, 250);
                SubForm.BackColor = Color.Chocolate;
                SubForm.opertionForm("-");
                SubForm.ControlsAdd(SubForm);
                SubForm.Show(this);
            }
            else
                SubForm.Show();
        }

        void btmult_click(object s, EventArgs e)
        {
            if (FormIsdisposed(MultForm))
            {
                MultForm = new MyTools();
                MultForm.Size = new Size(449, 250);
                MultForm.BackColor = Color.Tomato;
                MultForm.opertionForm("*");
                MultForm.ControlsAdd(MultForm);
                MultForm.Show(this);
            }
            else
                MultForm.Show();
        }

        void btdivide_click(object s, EventArgs e)
        {
            if (FormIsdisposed(DiviForm))
            {
                DiviForm = new MyTools();
                DiviForm.Size = new Size(449, 250);
                DiviForm.BackColor = Color.Bisque;
                DiviForm.opertionForm("/");
                DiviForm.ControlsAdd(DiviForm);
                DiviForm.Show(this);
            }
            else
                DiviForm.Show();
        }
    }
}
