﻿namespace CarWashApp.UI.Forms
{
    partial class KullaniciTanimlamaForm
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
            kullaniciPanel = new Panel();
            kullaniciListBox = new ListBox();
            guncelleBtn = new Button();
            resetBtn = new Button();
            silBtn = new Button();
            ekleBtn = new Button();
            checkBox1 = new CheckBox();
            sifreTextBox = new TextBox();
            kullaniciAdiTextBox = new TextBox();
            personelComBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            kullaniciPanel.SuspendLayout();
            SuspendLayout();
            // 
            // kullaniciPanel
            // 
            kullaniciPanel.Controls.Add(kullaniciListBox);
            kullaniciPanel.Controls.Add(guncelleBtn);
            kullaniciPanel.Controls.Add(resetBtn);
            kullaniciPanel.Controls.Add(silBtn);
            kullaniciPanel.Controls.Add(ekleBtn);
            kullaniciPanel.Controls.Add(checkBox1);
            kullaniciPanel.Controls.Add(sifreTextBox);
            kullaniciPanel.Controls.Add(kullaniciAdiTextBox);
            kullaniciPanel.Controls.Add(personelComBox);
            kullaniciPanel.Controls.Add(label3);
            kullaniciPanel.Controls.Add(label2);
            kullaniciPanel.Controls.Add(label4);
            kullaniciPanel.Controls.Add(label1);
            kullaniciPanel.Dock = DockStyle.Fill;
            kullaniciPanel.Location = new Point(0, 0);
            kullaniciPanel.Name = "kullaniciPanel";
            kullaniciPanel.Size = new Size(759, 400);
            kullaniciPanel.TabIndex = 0;
            // 
            // kullaniciListBox
            // 
            kullaniciListBox.FormattingEnabled = true;
            kullaniciListBox.ItemHeight = 15;
            kullaniciListBox.Items.AddRange(new object[] { "31" });
            kullaniciListBox.Location = new Point(511, 67);
            kullaniciListBox.Name = "kullaniciListBox";
            kullaniciListBox.Size = new Size(227, 304);
            kullaniciListBox.TabIndex = 26;
            kullaniciListBox.SelectedIndexChanged += kullaniciListBox_SelectedIndexChanged;
            // 
            // guncelleBtn
            // 
            guncelleBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            guncelleBtn.Location = new Point(230, 326);
            guncelleBtn.Name = "guncelleBtn";
            guncelleBtn.Size = new Size(135, 42);
            guncelleBtn.TabIndex = 22;
            guncelleBtn.Text = "Güncelle";
            guncelleBtn.UseVisualStyleBackColor = true;
            guncelleBtn.Click += guncelleBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            resetBtn.Location = new Point(230, 279);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(135, 42);
            resetBtn.TabIndex = 23;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // silBtn
            // 
            silBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            silBtn.Location = new Point(78, 326);
            silBtn.Name = "silBtn";
            silBtn.Size = new Size(135, 42);
            silBtn.TabIndex = 24;
            silBtn.Text = "Sil";
            silBtn.UseVisualStyleBackColor = true;
            silBtn.Click += silBtn_Click;
            // 
            // ekleBtn
            // 
            ekleBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ekleBtn.Location = new Point(78, 279);
            ekleBtn.Name = "ekleBtn";
            ekleBtn.Size = new Size(135, 42);
            ekleBtn.TabIndex = 25;
            ekleBtn.Text = "Ekle";
            ekleBtn.UseVisualStyleBackColor = true;
            ekleBtn.Click += ekleBtn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(230, 221);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(89, 32);
            checkBox1.TabIndex = 21;
            checkBox1.Text = "Admin";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // sifreTextBox
            // 
            sifreTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            sifreTextBox.Location = new Point(189, 156);
            sifreTextBox.Name = "sifreTextBox";
            sifreTextBox.Size = new Size(176, 34);
            sifreTextBox.TabIndex = 19;
            // 
            // kullaniciAdiTextBox
            // 
            kullaniciAdiTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            kullaniciAdiTextBox.Location = new Point(189, 93);
            kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            kullaniciAdiTextBox.Size = new Size(176, 34);
            kullaniciAdiTextBox.TabIndex = 20;
            // 
            // personelComBox
            // 
            personelComBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            personelComBox.FormattingEnabled = true;
            personelComBox.Location = new Point(189, 30);
            personelComBox.Name = "personelComBox";
            personelComBox.Size = new Size(176, 36);
            personelComBox.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 222);
            label3.Margin = new Padding(3, 10, 3, 10);
            label3.Name = "label3";
            label3.Padding = new Padding(3, 0, 3, 15);
            label3.Size = new Size(137, 43);
            label3.TabIndex = 14;
            label3.Text = "Kullanıcı Tipi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 159);
            label2.Margin = new Padding(3, 10, 3, 10);
            label2.Name = "label2";
            label2.Padding = new Padding(3, 0, 3, 15);
            label2.Size = new Size(71, 43);
            label2.TabIndex = 15;
            label2.Text = "Şifre : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 33);
            label4.Margin = new Padding(3, 10, 3, 10);
            label4.Name = "label4";
            label4.Padding = new Padding(3, 0, 3, 15);
            label4.Size = new Size(100, 43);
            label4.TabIndex = 16;
            label4.Text = "Personel :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 96);
            label1.Margin = new Padding(3, 10, 3, 10);
            label1.Name = "label1";
            label1.Padding = new Padding(3, 0, 3, 15);
            label1.Size = new Size(135, 43);
            label1.TabIndex = 17;
            label1.Text = "Kullanıcı Adı :";
            // 
            // KullaniciTanimlamaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 400);
            Controls.Add(kullaniciPanel);
            Name = "KullaniciTanimlamaForm";
            Text = "Kullanıcı";
            Load += KullaniciTanimlamaForm_Load;
            kullaniciPanel.ResumeLayout(false);
            kullaniciPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel kullaniciPanel;
        private ListBox kullaniciListBox;
        private Button guncelleBtn;
        private Button resetBtn;
        private Button silBtn;
        private Button ekleBtn;
        private CheckBox checkBox1;
        private TextBox sifreTextBox;
        private TextBox kullaniciAdiTextBox;
        private ComboBox personelComBox;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label1;
    }
}