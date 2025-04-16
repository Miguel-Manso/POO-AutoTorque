namespace AutoTorque.Views
{
    partial class frmVisualizarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizarFuncionario));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVisEndereco = new System.Windows.Forms.TextBox();
            this.txtVisSalario = new System.Windows.Forms.TextBox();
            this.txtVisCargo = new System.Windows.Forms.TextBox();
            this.txtVisNome = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Salário:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 75;
            this.label8.Text = "Cargo:";
            // 
            // txtVisEndereco
            // 
            this.txtVisEndereco.Location = new System.Drawing.Point(105, 399);
            this.txtVisEndereco.Name = "txtVisEndereco";
            this.txtVisEndereco.ReadOnly = true;
            this.txtVisEndereco.Size = new System.Drawing.Size(615, 20);
            this.txtVisEndereco.TabIndex = 74;
            // 
            // txtVisSalario
            // 
            this.txtVisSalario.Location = new System.Drawing.Point(105, 376);
            this.txtVisSalario.Name = "txtVisSalario";
            this.txtVisSalario.ReadOnly = true;
            this.txtVisSalario.Size = new System.Drawing.Size(615, 20);
            this.txtVisSalario.TabIndex = 73;
            // 
            // txtVisCargo
            // 
            this.txtVisCargo.Location = new System.Drawing.Point(105, 350);
            this.txtVisCargo.Name = "txtVisCargo";
            this.txtVisCargo.ReadOnly = true;
            this.txtVisCargo.Size = new System.Drawing.Size(615, 20);
            this.txtVisCargo.TabIndex = 72;
            // 
            // txtVisNome
            // 
            this.txtVisNome.Location = new System.Drawing.Point(105, 324);
            this.txtVisNome.Name = "txtVisNome";
            this.txtVisNome.ReadOnly = true;
            this.txtVisNome.Size = new System.Drawing.Size(615, 20);
            this.txtVisNome.TabIndex = 71;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(22, 426);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 70;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(269, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 29);
            this.label7.TabIndex = 68;
            this.label7.Text = "Visualizar Funcionario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoTorque.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(197, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 297);
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // frmVisualizarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtVisEndereco);
            this.Controls.Add(this.txtVisSalario);
            this.Controls.Add(this.txtVisCargo);
            this.Controls.Add(this.txtVisNome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVisualizarFuncionario";
            this.Text = "Visualizar de Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVisEndereco;
        private System.Windows.Forms.TextBox txtVisSalario;
        private System.Windows.Forms.TextBox txtVisCargo;
        private System.Windows.Forms.TextBox txtVisNome;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}