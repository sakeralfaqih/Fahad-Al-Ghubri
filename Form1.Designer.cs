namespace Fahad_Al_Ghubri
{
    partial class Form1
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
            this.tbone = new System.Windows.Forms.TextBox();
            this.tbtwo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btsum = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btmult = new System.Windows.Forms.Button();
            this.btdiv = new System.Windows.Forms.Button();
            this.btsub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbone
            // 
            this.tbone.Location = new System.Drawing.Point(235, 28);
            this.tbone.Name = "tbone";
            this.tbone.Size = new System.Drawing.Size(100, 20);
            this.tbone.TabIndex = 0;
            this.tbone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbone_KeyPress);
            // 
            // tbtwo
            // 
            this.tbtwo.Location = new System.Drawing.Point(359, 64);
            this.tbtwo.Name = "tbtwo";
            this.tbtwo.Size = new System.Drawing.Size(100, 20);
            this.tbtwo.TabIndex = 1;
            this.tbtwo.TextChanged += new System.EventHandler(this.tbtwo_TextChanged);
            this.tbtwo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbtwo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // btsum
            // 
            this.btsum.Location = new System.Drawing.Point(177, 167);
            this.btsum.Name = "btsum";
            this.btsum.Size = new System.Drawing.Size(73, 19);
            this.btsum.TabIndex = 4;
            this.btsum.Text = "button1";
            this.btsum.UseVisualStyleBackColor = true;
            this.btsum.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(150, 102);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(100, 20);
            this.tbResult.TabIndex = 7;
            this.tbResult.TextChanged += new System.EventHandler(this.tbResult_TextChanged);
            // 
            // btmult
            // 
            this.btmult.Location = new System.Drawing.Point(175, 264);
            this.btmult.Name = "btmult";
            this.btmult.Size = new System.Drawing.Size(75, 19);
            this.btmult.TabIndex = 8;
            this.btmult.Text = "button1";
            this.btmult.UseVisualStyleBackColor = true;
            this.btmult.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btdiv
            // 
            this.btdiv.Location = new System.Drawing.Point(423, 229);
            this.btdiv.Name = "btdiv";
            this.btdiv.Size = new System.Drawing.Size(75, 20);
            this.btdiv.TabIndex = 9;
            this.btdiv.Text = "button1";
            this.btdiv.UseVisualStyleBackColor = true;
            this.btdiv.Click += new System.EventHandler(this.btdiv_Click);
            // 
            // btsub
            // 
            this.btsub.Location = new System.Drawing.Point(22, 215);
            this.btsub.Name = "btsub";
            this.btsub.Size = new System.Drawing.Size(75, 21);
            this.btsub.TabIndex = 10;
            this.btsub.Text = "button2";
            this.btsub.UseVisualStyleBackColor = true;
            this.btsub.Click += new System.EventHandler(this.btsub_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 409);
            this.Controls.Add(this.btsub);
            this.Controls.Add(this.btdiv);
            this.Controls.Add(this.btmult);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btsum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbtwo);
            this.Controls.Add(this.tbone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbone;
        private System.Windows.Forms.TextBox tbtwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btsum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btmult;
        private System.Windows.Forms.Button btdiv;
        private System.Windows.Forms.Button btsub;
    }
}

