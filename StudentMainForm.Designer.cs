namespace Fahad_Al_Ghubri
{
    partial class StudentMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.الرئيسيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ملفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافةبياناتالطالبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.صورةالطالبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضالبياناتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الرئيسيةToolStripMenuItem,
            this.ملفToolStripMenuItem,
            this.تعديلToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(577, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // الرئيسيةToolStripMenuItem
            // 
            this.الرئيسيةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافةبياناتالطالبToolStripMenuItem,
            this.صورةالطالبToolStripMenuItem,
            this.عرضالبياناتToolStripMenuItem});
            this.الرئيسيةToolStripMenuItem.Name = "الرئيسيةToolStripMenuItem";
            this.الرئيسيةToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.الرئيسيةToolStripMenuItem.Text = "الرئيسية";
            // 
            // ملفToolStripMenuItem
            // 
            this.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem";
            this.ملفToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.ملفToolStripMenuItem.Text = "ملف";
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.تعديلToolStripMenuItem.Text = "تعديل البيانات";
            // 
            // اضافةبياناتالطالبToolStripMenuItem
            // 
            this.اضافةبياناتالطالبToolStripMenuItem.Name = "اضافةبياناتالطالبToolStripMenuItem";
            this.اضافةبياناتالطالبToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.اضافةبياناتالطالبToolStripMenuItem.Text = "اضافة بيانات الطالب";
            this.اضافةبياناتالطالبToolStripMenuItem.Click += new System.EventHandler(this.اضافةبياناتالطالبToolStripMenuItem_Click);
            // 
            // صورةالطالبToolStripMenuItem
            // 
            this.صورةالطالبToolStripMenuItem.Name = "صورةالطالبToolStripMenuItem";
            this.صورةالطالبToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.صورةالطالبToolStripMenuItem.Text = "صورة الطالب";
            this.صورةالطالبToolStripMenuItem.Click += new System.EventHandler(this.صورةالطالبToolStripMenuItem_Click);
            // 
            // عرضالبياناتToolStripMenuItem
            // 
            this.عرضالبياناتToolStripMenuItem.Name = "عرضالبياناتToolStripMenuItem";
            this.عرضالبياناتToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.عرضالبياناتToolStripMenuItem.Text = "عرض البيانات";
            this.عرضالبياناتToolStripMenuItem.Click += new System.EventHandler(this.عرضالبياناتToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(279, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = " : اسم الطالب";
            // 
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 222);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentMainForm";
            this.Text = "StudentMainForm";
            this.Load += new System.EventHandler(this.StudentMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem الرئيسيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافةبياناتالطالبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem صورةالطالبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضالبياناتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ملفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}