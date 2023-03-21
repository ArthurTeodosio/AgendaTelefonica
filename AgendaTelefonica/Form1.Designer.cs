namespace AgendaTelefonica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Nome = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.Label();
            this.txtListaTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.listTelefones = new System.Windows.Forms.ListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(159, 30);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(44, 16);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.Location = new System.Drawing.Point(159, 89);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(61, 16);
            this.Telefone.TabIndex = 1;
            this.Telefone.Text = "Telefone";
            // 
            // txtListaTelefone
            // 
            this.txtListaTelefone.AutoSize = true;
            this.txtListaTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListaTelefone.Location = new System.Drawing.Point(20, 171);
            this.txtListaTelefone.Name = "txtListaTelefone";
            this.txtListaTelefone.Size = new System.Drawing.Size(118, 16);
            this.txtListaTelefone.TabIndex = 2;
            this.txtListaTelefone.Text = "Lista de Telefones";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(242, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(186, 20);
            this.txtNome.TabIndex = 3;
            // 
            // listTelefones
            // 
            this.listTelefones.FormattingEnabled = true;
            this.listTelefones.Location = new System.Drawing.Point(23, 197);
            this.listTelefones.Name = "listTelefones";
            this.listTelefones.Size = new System.Drawing.Size(405, 212);
            this.listTelefones.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(353, 85);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(353, 168);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 7;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(242, 85);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(85, 20);
            this.txtTelefone.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(453, 419);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.listTelefones);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtListaTelefone);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Nome);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.Label txtListaTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ListBox listTelefones;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
    }
}

