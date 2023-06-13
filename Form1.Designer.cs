
namespace Şehirler
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.EklenecekSehirTextBox = new System.Windows.Forms.TextBox();
            this.GidilenSehirlerListBox = new System.Windows.Forms.ListBox();
            this.SehirlerListBox = new System.Windows.Forms.ListBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.ArananSehirTextBox = new System.Windows.Forms.TextBox();
            this.SilinecekSehirTextBox = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btn3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gidilenSehirlerRadioButton = new System.Windows.Forms.RadioButton();
            this.sehirlerRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // EklenecekSehirTextBox
            // 
            this.EklenecekSehirTextBox.Location = new System.Drawing.Point(215, 46);
            this.EklenecekSehirTextBox.Name = "EklenecekSehirTextBox";
            this.EklenecekSehirTextBox.Size = new System.Drawing.Size(125, 22);
            this.EklenecekSehirTextBox.TabIndex = 0;
            this.EklenecekSehirTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GidilenSehirlerListBox
            // 
            this.GidilenSehirlerListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GidilenSehirlerListBox.FormattingEnabled = true;
            this.GidilenSehirlerListBox.ItemHeight = 16;
            this.GidilenSehirlerListBox.Items.AddRange(new object[] {
            "Hama",
            "Haleb",
            "Hamanın parçası (Homs)",
            "Şam",
            "Dimaşk",
            "İdlib",
            "Der El Zor",
            "Rakka",
            "Hasaka",
            "dar3a",
            "latkiya",
            "Suyda",
            "tartus",
            "Dareya",
            "Tudmar"});
            this.GidilenSehirlerListBox.Location = new System.Drawing.Point(319, 113);
            this.GidilenSehirlerListBox.Name = "GidilenSehirlerListBox";
            this.GidilenSehirlerListBox.Size = new System.Drawing.Size(175, 260);
            this.GidilenSehirlerListBox.TabIndex = 1;
            // 
            // SehirlerListBox
            // 
            this.SehirlerListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SehirlerListBox.FormattingEnabled = true;
            this.SehirlerListBox.ItemHeight = 16;
            this.SehirlerListBox.Items.AddRange(new object[] {
            ""});
            this.SehirlerListBox.Location = new System.Drawing.Point(26, 113);
            this.SehirlerListBox.Name = "SehirlerListBox";
            this.SehirlerListBox.Size = new System.Drawing.Size(166, 260);
            this.SehirlerListBox.TabIndex = 2;
            // 
            // btn1
            // 
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.Location = new System.Drawing.Point(348, 425);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(105, 35);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Bul";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2.Location = new System.Drawing.Point(348, 475);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(106, 32);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "Sil";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // ArananSehirTextBox
            // 
            this.ArananSehirTextBox.Location = new System.Drawing.Point(168, 438);
            this.ArananSehirTextBox.Name = "ArananSehirTextBox";
            this.ArananSehirTextBox.Size = new System.Drawing.Size(156, 22);
            this.ArananSehirTextBox.TabIndex = 5;
            this.ArananSehirTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SilinecekSehirTextBox
            // 
            this.SilinecekSehirTextBox.Location = new System.Drawing.Point(168, 485);
            this.SilinecekSehirTextBox.Name = "SilinecekSehirTextBox";
            this.SilinecekSehirTextBox.Size = new System.Drawing.Size(156, 22);
            this.SilinecekSehirTextBox.TabIndex = 6;
            this.SilinecekSehirTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(101, 46);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(110, 17);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Eklenecek Şehir";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(330, 93);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(57, 17);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = "Şehirler";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(71, 441);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(91, 17);
            this.lbl4.TabIndex = 9;
            this.lbl4.Text = "Aranan Şehir";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(66, 490);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(96, 17);
            this.lbl5.TabIndex = 10;
            this.lbl5.Text = "Silinicek Şehir";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(23, 93);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(105, 17);
            this.lbl3.TabIndex = 11;
            this.lbl3.Text = "Gidilen Şehirler";
            // 
            // btn3
            // 
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3.Location = new System.Drawing.Point(215, 74);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(61, 23);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "Ekle";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(215, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(217, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gidilenSehirlerRadioButton
            // 
            this.gidilenSehirlerRadioButton.AutoSize = true;
            this.gidilenSehirlerRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gidilenSehirlerRadioButton.Location = new System.Drawing.Point(273, 12);
            this.gidilenSehirlerRadioButton.Name = "gidilenSehirlerRadioButton";
            this.gidilenSehirlerRadioButton.Size = new System.Drawing.Size(78, 21);
            this.gidilenSehirlerRadioButton.TabIndex = 19;
            this.gidilenSehirlerRadioButton.TabStop = true;
            this.gidilenSehirlerRadioButton.Text = "Şehirler";
            this.gidilenSehirlerRadioButton.UseVisualStyleBackColor = true;
            // 
            // sehirlerRadioButton
            // 
            this.sehirlerRadioButton.AutoSize = true;
            this.sehirlerRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sehirlerRadioButton.Location = new System.Drawing.Point(85, 12);
            this.sehirlerRadioButton.Name = "sehirlerRadioButton";
            this.sehirlerRadioButton.Size = new System.Drawing.Size(126, 21);
            this.sehirlerRadioButton.TabIndex = 20;
            this.sehirlerRadioButton.TabStop = true;
            this.sehirlerRadioButton.Text = "Gidilen Şehirler";
            this.sehirlerRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 548);
            this.Controls.Add(this.sehirlerRadioButton);
            this.Controls.Add(this.gidilenSehirlerRadioButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.SilinecekSehirTextBox);
            this.Controls.Add(this.ArananSehirTextBox);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.SehirlerListBox);
            this.Controls.Add(this.GidilenSehirlerListBox);
            this.Controls.Add(this.EklenecekSehirTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EklenecekSehirTextBox;
        private System.Windows.Forms.ListBox GidilenSehirlerListBox;
        private System.Windows.Forms.ListBox SehirlerListBox;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.TextBox ArananSehirTextBox;
        private System.Windows.Forms.TextBox SilinecekSehirTextBox;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton gidilenSehirlerRadioButton;
        private System.Windows.Forms.RadioButton sehirlerRadioButton;
    }
}

