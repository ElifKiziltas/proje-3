namespace ucuncu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbSayi1 = new TextBox();
            tbSayi2 = new TextBox();
            btnToplama = new Button();
            btnCıkar = new Button();
            btnCarp = new Button();
            btnBol = new Button();
            tbIslem = new TextBox();
            tbSonuc = new TextBox();
            btnKapat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 23);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "1.Sayı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(513, 23);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "2.Sayı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 280);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "İşlem";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 329);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "&Sonuç";
            // 
            // tbSayi1
            // 
            tbSayi1.Location = new Point(28, 41);
            tbSayi1.Name = "tbSayi1";
            tbSayi1.Size = new Size(144, 23);
            tbSayi1.TabIndex = 4;
            // 
            // tbSayi2
            // 
            tbSayi2.Location = new Point(407, 41);
            tbSayi2.Name = "tbSayi2";
            tbSayi2.Size = new Size(144, 23);
            tbSayi2.TabIndex = 5;
            // 
            // btnToplama
            // 
            btnToplama.Location = new Point(239, 41);
            btnToplama.Name = "btnToplama";
            btnToplama.Size = new Size(89, 39);
            btnToplama.TabIndex = 6;
            btnToplama.Text = "&Toplama";
            btnToplama.UseVisualStyleBackColor = true;
            btnToplama.Click += btnToplama_Click;
            // 
            // btnCıkar
            // 
            btnCıkar.Location = new Point(239, 95);
            btnCıkar.Name = "btnCıkar";
            btnCıkar.Size = new Size(89, 39);
            btnCıkar.TabIndex = 7;
            btnCıkar.Text = "Çı&kar";
            btnCıkar.UseVisualStyleBackColor = true;
            btnCıkar.Click += btnCıkar_Click;
            // 
            // btnCarp
            // 
            btnCarp.Location = new Point(239, 149);
            btnCarp.Name = "btnCarp";
            btnCarp.Size = new Size(89, 39);
            btnCarp.TabIndex = 8;
            btnCarp.Text = "Çar&p";
            btnCarp.UseVisualStyleBackColor = true;
            btnCarp.Click += btnCarp_Click;
            // 
            // btnBol
            // 
            btnBol.Location = new Point(239, 203);
            btnBol.Name = "btnBol";
            btnBol.Size = new Size(89, 39);
            btnBol.TabIndex = 9;
            btnBol.Text = "&Böl";
            btnBol.UseVisualStyleBackColor = true;
            btnBol.Click += btnBol_Click;
            // 
            // tbIslem
            // 
            tbIslem.Location = new Point(130, 277);
            tbIslem.Name = "tbIslem";
            tbIslem.Size = new Size(261, 23);
            tbIslem.TabIndex = 10;
            // 
            // tbSonuc
            // 
            tbSonuc.Location = new Point(130, 326);
            tbSonuc.Name = "tbSonuc";
            tbSonuc.Size = new Size(261, 23);
            tbSonuc.TabIndex = 11;
            // 
            // btnKapat
            // 
            btnKapat.Location = new Point(222, 377);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(115, 41);
            btnKapat.TabIndex = 12;
            btnKapat.Text = "Kapa&t";
            btnKapat.UseVisualStyleBackColor = true;
            btnKapat.Click += btnKapat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 450);
            Controls.Add(btnKapat);
            Controls.Add(tbSonuc);
            Controls.Add(tbIslem);
            Controls.Add(btnBol);
            Controls.Add(btnCarp);
            Controls.Add(btnCıkar);
            Controls.Add(btnToplama);
            Controls.Add(tbSayi2);
            Controls.Add(tbSayi1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbSayi1;
        private TextBox tbSayi2;
        private Button btnToplama;
        private Button btnCıkar;
        private Button btnCarp;
        private Button btnBol;
        private TextBox tbIslem;
        private TextBox tbSonuc;
        private Button btnKapat;
    }
}
