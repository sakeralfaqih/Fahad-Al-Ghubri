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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        Button btchaneg = new Button(), btfile = new Button();
        TextBox tbsours = new TextBox();
        Panel photo = new Panel();
        Label tx = new Label();
        PictureBox Picture = new PictureBox();

        string soursDefult = @"C:\Users\SAKERALFAQIH\Documents\icon\ايقونات اساسية للتصميم والبرمجة\ايقونات اساسية للتصميم\ايقونات الدالة للتواصل\ion_ios_personadd.png";
        private void Form7_Load(object sender, EventArgs e)
        {
            this.Size=new Size(902,530);

            ///////////////////
            btchaneg.Location = new Point(750, 400);
            btchaneg.Size = new Size(80, 40);
            btchaneg.Text = "show photo";
            btchaneg.BackColor = Color.DarkCyan;
            btchaneg.Click += btchaneg_click;

            btfile.Location = new Point(200, 400);
            btfile.Size = new Size(80, 40);
            btfile.Text = "from files";
            btfile.BackColor = Color.DarkCyan;
            btfile.Click += btfile_click;


            tx.Location = new Point(300, 410);
            tx.Size = new Size(150, 40);
            tx.Font =new Font(Font.FontFamily, 11F, FontStyle.Italic);
            tx.Text = "Write sours photos :";

            tbsours.Location = new Point(460, 410);
            tbsours.Width = 250;
            tbsours.TextChanged += tbsours_defult;


            ////////////picturbox//////

            Picture.Location = new Point(470, 30);
            Picture.Size = new Size(350, 350);
            Picture.Image = Image.FromFile(soursDefult);
            Picture.SizeMode = PictureBoxSizeMode.Zoom;
            Picture.BorderStyle = BorderStyle.FixedSingle;

            ////////panel///////////

            photo.Location = new Point(80, 30);
            photo.Size = new Size(350, 350);
            photo.BackgroundImage = Image.FromFile(soursDefult);
            photo.BackgroundImageLayout = ImageLayout.Zoom;
            photo.BorderStyle = BorderStyle.FixedSingle;

            //////add form/////////////
            this.Controls.Add(btchaneg);
           this.Controls.Add(tbsours);
           this.Controls.Add(tx);
           this.Controls.Add(Picture);
           this.Controls.Add(photo);
           this.Controls.Add(btfile);
        }

        void btchaneg_click(object s, EventArgs e)
        {
            //ion_social_android.png
           
          
            try
            {
                
               // photo.BackgroundImage = Image.FromFile(@"C:\Users\SAKERALFAQIH\" + tbsours.Text);
                Picture.Image = Image.FromFile(@tbsours.Text);
                photo.BackgroundImage = new Bitmap(@tbsours.Text);
                

            }
            catch
            {
                MessageBox.Show("No Found  photo !");

            }

        }
        void tbsours_defult(object s, EventArgs e)
        {
            if (tbsours.Text == "")
            {
                photo.BackgroundImage = Image.FromFile(soursDefult);
                Picture.Image = Image.FromFile(soursDefult);

            }
        }
        void btfile_click(object s, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                tbsours.Text = "";
                tbsours.Text = openfile.FileName;
                photo.BackgroundImage = new Bitmap(tbsours.Text);
                Picture.Image = new Bitmap(tbsours.Text);

            }

        }
    }
}
