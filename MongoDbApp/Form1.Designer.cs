namespace MongoDbApp
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
            txtNomeProduto = new TextBox();
            txtQuantidade = new TextBox();
            txtMarca = new TextBox();
            txtDescricao = new TextBox();
            lstProduto = new ListBox();
            btnListar = new Button();
            btnAdicionar = new Button();
            btnExcluir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 36);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do Produto :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 168);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Descrição :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 121);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Marca :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 77);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "Quantidade :";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(141, 28);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(256, 23);
            txtNomeProduto.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(141, 69);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(96, 23);
            txtQuantidade.TabIndex = 5;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(141, 113);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(256, 23);
            txtMarca.TabIndex = 6;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(141, 162);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(256, 82);
            txtDescricao.TabIndex = 7;
            // 
            // lstProduto
            // 
            lstProduto.FormattingEnabled = true;
            lstProduto.ItemHeight = 15;
            lstProduto.Location = new Point(436, 28);
            lstProduto.Name = "lstProduto";
            lstProduto.Size = new Size(352, 304);
            lstProduto.TabIndex = 8;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(301, 301);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(96, 31);
            btnListar.TabIndex = 9;
            btnListar.Text = "LISTAR";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(141, 301);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(96, 31);
            btnAdicionar.TabIndex = 9;
            btnAdicionar.Text = "ADICIONAR";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(436, 341);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(352, 28);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluir);
            Controls.Add(btnAdicionar);
            Controls.Add(btnListar);
            Controls.Add(lstProduto);
            Controls.Add(txtDescricao);
            Controls.Add(txtMarca);
            Controls.Add(txtQuantidade);
            Controls.Add(txtNomeProduto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNomeProduto;
        private TextBox txtQuantidade;
        private TextBox txtMarca;
        private TextBox txtDescricao;
        private ListBox lstProduto;
        private Button btnListar;
        private Button btnAdicionar;
        private Button btnExcluir;
    }
}
