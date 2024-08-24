namespace exercicio
{
    partial class Form3
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
            button1 = new Button();
            listViewClientes = new ListView();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 342);
            button1.Name = "button1";
            button1.Size = new Size(776, 96);
            button1.TabIndex = 0;
            button1.Text = "Excluir dados";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listViewClientes
            // 
            listViewClientes.Location = new Point(12, 12);
            listViewClientes.Name = "listViewClientes";
            listViewClientes.Size = new Size(776, 324);
            listViewClientes.TabIndex = 1;
            listViewClientes.UseCompatibleStateImageBehavior = false;
            listViewClientes.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewClientes);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Página de exclusão de dados";
            Load += Form3_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListView listViewClientes;
    }
}