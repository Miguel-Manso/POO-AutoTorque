namespace AutoTorque
{
    partial class frmCadastrar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrar));
            this.btnSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.btnCadastroServico = new System.Windows.Forms.Button();
            this.btnCadastroFuncionario = new System.Windows.Forms.Button();
            this.btnCadastroVeiculo = new System.Windows.Forms.Button();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(12, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 36;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Funcionário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Veículo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(659, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Serviço";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnCadastroServico
            // 
            this.btnCadastroServico.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastroServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroServico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastroServico.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastroServico.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroServico.Image")));
            this.btnCadastroServico.Location = new System.Drawing.Point(636, 57);
            this.btnCadastroServico.Name = "btnCadastroServico";
            this.btnCadastroServico.Size = new System.Drawing.Size(84, 83);
            this.btnCadastroServico.TabIndex = 3;
            this.btnCadastroServico.UseVisualStyleBackColor = false;
            this.btnCadastroServico.Click += new System.EventHandler(this.btnCadastroServico_Click);
            // 
            // btnCadastroFuncionario
            // 
            this.btnCadastroFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastroFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastroFuncionario.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastroFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroFuncionario.Image")));
            this.btnCadastroFuncionario.Location = new System.Drawing.Point(256, 57);
            this.btnCadastroFuncionario.Name = "btnCadastroFuncionario";
            this.btnCadastroFuncionario.Size = new System.Drawing.Size(84, 83);
            this.btnCadastroFuncionario.TabIndex = 2;
            this.btnCadastroFuncionario.UseVisualStyleBackColor = false;
            this.btnCadastroFuncionario.Click += new System.EventHandler(this.btnCadastroFuncionario_Click);
            // 
            // btnCadastroVeiculo
            // 
            this.btnCadastroVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastroVeiculo.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastroVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroVeiculo.Image")));
            this.btnCadastroVeiculo.Location = new System.Drawing.Point(449, 57);
            this.btnCadastroVeiculo.Name = "btnCadastroVeiculo";
            this.btnCadastroVeiculo.Size = new System.Drawing.Size(84, 83);
            this.btnCadastroVeiculo.TabIndex = 1;
            this.btnCadastroVeiculo.UseVisualStyleBackColor = true;
            this.btnCadastroVeiculo.Click += new System.EventHandler(this.btnCadastroVeiculo_Click);
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastroCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastroCliente.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastroCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroCliente.Image")));
            this.btnCadastroCliente.Location = new System.Drawing.Point(73, 57);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(84, 83);
            this.btnCadastroCliente.TabIndex = 0;
            this.btnCadastroCliente.UseVisualStyleBackColor = false;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoTorque.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(196, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 337);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // frmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastroServico);
            this.Controls.Add(this.btnCadastroFuncionario);
            this.Controls.Add(this.btnCadastroVeiculo);
            this.Controls.Add(this.btnCadastroCliente);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrar";
            this.RightToLeftLayout = true;
            this.Text = "Cadastrar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroCliente;
        private System.Windows.Forms.Button btnCadastroVeiculo;
        private System.Windows.Forms.Button btnCadastroFuncionario;
        private System.Windows.Forms.Button btnCadastroServico;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer tempo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}