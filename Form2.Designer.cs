namespace Cryptologia
{
    partial class Form2
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
            this.Knopka_dlya_vivoda = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.Mod = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ogran = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Knopka_dlya_vivoda
            // 
            this.Knopka_dlya_vivoda.Location = new System.Drawing.Point(190, 190);
            this.Knopka_dlya_vivoda.Name = "Knopka_dlya_vivoda";
            this.Knopka_dlya_vivoda.Size = new System.Drawing.Size(88, 42);
            this.Knopka_dlya_vivoda.TabIndex = 0;
            this.Knopka_dlya_vivoda.Text = "Рассчёт";
            this.Knopka_dlya_vivoda.UseVisualStyleBackColor = true;
            this.Knopka_dlya_vivoda.Click += new System.EventHandler(this.Knopka_dlya_vivoda_Click);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(14, 121);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(100, 26);
            this.A.TabIndex = 1;
            this.A.TextChanged += new System.EventHandler(this.A_TextChanged);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(226, 121);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(100, 26);
            this.B.TabIndex = 2;
            // 
            // Mod
            // 
            this.Mod.Location = new System.Drawing.Point(332, 121);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(100, 26);
            this.Mod.TabIndex = 3;
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(120, 121);
            this.X.Multiline = true;
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(100, 26);
            this.X.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "MOD ";
            // 
            // Ogran
            // 
            this.Ogran.Location = new System.Drawing.Point(654, 108);
            this.Ogran.Multiline = true;
            this.Ogran.Name = "Ogran";
            this.Ogran.Size = new System.Drawing.Size(80, 47);
            this.Ogran.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "ограничение на поиск делителей";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 496);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Ogran);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Mod);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.Knopka_dlya_vivoda);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Knopka_dlya_vivoda;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.TextBox Mod;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Ogran;
        private System.Windows.Forms.Label label4;
    }
}