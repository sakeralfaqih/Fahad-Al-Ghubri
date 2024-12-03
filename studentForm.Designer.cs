namespace Fahad_Al_Ghubri
{
    partial class studentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ادارةبياناتالطلابToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ملفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافةطالبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضالطلابToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اغلاقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اغلاقالكلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "الشاشه الرئسية";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ادارةبياناتالطلابToolStripMenuItem,
            this.ملفToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ادارةبياناتالطلابToolStripMenuItem
            // 
            this.ادارةبياناتالطلابToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافةطالبToolStripMenuItem,
            this.عرضالطلابToolStripMenuItem});
            this.ادارةبياناتالطلابToolStripMenuItem.Name = "ادارةبياناتالطلابToolStripMenuItem";
            this.ادارةبياناتالطلابToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.ادارةبياناتالطلابToolStripMenuItem.Text = "ادارة بيانات الطلاب";
            // 
            // ملفToolStripMenuItem
            // 
            this.ملفToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اغلاقToolStripMenuItem,
            this.اغلاقالكلToolStripMenuItem});
            this.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem";
            this.ملفToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.ملفToolStripMenuItem.Text = "ملف";
            // 
            // اضافةطالبToolStripMenuItem
            // 
            this.اضافةطالبToolStripMenuItem.Name = "اضافةطالبToolStripMenuItem";
            this.اضافةطالبToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.اضافةطالبToolStripMenuItem.Text = "اضافة  طالب";
            this.اضافةطالبToolStripMenuItem.Click += new System.EventHandler(this.اضافةطالبToolStripMenuItem_Click);
            // 
            // عرضالطلابToolStripMenuItem
            // 
            this.عرضالطلابToolStripMenuItem.Name = "عرضالطلابToolStripMenuItem";
            this.عرضالطلابToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.عرضالطلابToolStripMenuItem.Text = "عرض  الطلاب";
            this.عرضالطلابToolStripMenuItem.Click += new System.EventHandler(this.عرضالطلابToolStripMenuItem_Click);
            // 
            // اغلاقToolStripMenuItem
            // 
            this.اغلاقToolStripMenuItem.Name = "اغلاقToolStripMenuItem";
            this.اغلاقToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.اغلاقToolStripMenuItem.Text = "اغلاق";
            this.اغلاقToolStripMenuItem.Click += new System.EventHandler(this.اغلاقToolStripMenuItem_Click);
            // 
            // اغلاقالكلToolStripMenuItem
            // 
            this.اغلاقالكلToolStripMenuItem.Name = "اغلاقالكلToolStripMenuItem";
            this.اغلاقالكلToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.اغلاقالكلToolStripMenuItem.Text = "اغلاق الكل";
            this.اغلاقالكلToolStripMenuItem.Click += new System.EventHandler(this.اغلاقالكلToolStripMenuItem_Click);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.خروجToolStripMenuItem.Text = "خروج";
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "studentForm";
            this.Text = "studentForm";
            this.Load += new System.EventHandler(this.studentForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ادارةبياناتالطلابToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافةطالبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضالطلابToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ملفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اغلاقToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اغلاقالكلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
    }
}