﻿namespace Exemplo_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(217, 9);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(352, 304);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(28, 220);
            button1.Name = "button1";
            button1.Size = new Size(140, 28);
            button1.TabIndex = 2;
            button1.Text = "Adicionar item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 191);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(604, 9);
            label1.Name = "label1";
            label1.Size = new Size(184, 47);
            label1.TabIndex = 4;
            label1.Text = "Senac Eats";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(297, 358);
            label2.Name = "label2";
            label2.Size = new Size(192, 30);
            label2.TabIndex = 5;
            label2.Text = "Status: aguardando";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Coral;
            label3.Location = new Point(52, 160);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 6;
            label3.Text = "Produtos";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(28, 254);
            button2.Name = "button2";
            button2.Size = new Size(140, 27);
            button2.TabIndex = 7;
            button2.Text = "Remover item";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.InactiveCaptionText;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Coral;
            label4.Location = new Point(204, 360);
            label4.Name = "label4";
            label4.Size = new Size(0, 28);
            label4.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ListBox listBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Label label4;
    }
}