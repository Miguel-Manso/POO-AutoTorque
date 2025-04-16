namespace AutoTorque.Views
{
    partial class frmVisualizarVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizarVeiculo));
            this.label5 = new System.Windows.Forms.Label();
            this.txtVisAno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVisPlaca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVisMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVisModelo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVisCliente = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ano:";
            // 
            // txtVisAno
            // 
            this.txtVisAno.Location = new System.Drawing.Point(99, 393);
            this.txtVisAno.Name = "txtVisAno";
            this.txtVisAno.ReadOnly = true;
            this.txtVisAno.Size = new System.Drawing.Size(619, 20);
            this.txtVisAno.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Placa:";
            // 
            // txtVisPlaca
            // 
            this.txtVisPlaca.Location = new System.Drawing.Point(99, 367);
            this.txtVisPlaca.Name = "txtVisPlaca";
            this.txtVisPlaca.ReadOnly = true;
            this.txtVisPlaca.Size = new System.Drawing.Size(280, 20);
            this.txtVisPlaca.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Marca:";
            // 
            // txtVisMarca
            // 
            this.txtVisMarca.Location = new System.Drawing.Point(99, 341);
            this.txtVisMarca.Name = "txtVisMarca";
            this.txtVisMarca.ReadOnly = true;
            this.txtVisMarca.Size = new System.Drawing.Size(619, 20);
            this.txtVisMarca.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Modelo:";
            // 
            // txtVisModelo
            // 
            this.txtVisModelo.Location = new System.Drawing.Point(99, 315);
            this.txtVisModelo.Name = "txtVisModelo";
            this.txtVisModelo.ReadOnly = true;
            this.txtVisModelo.Size = new System.Drawing.Size(619, 20);
            this.txtVisModelo.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(298, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 29);
            this.label7.TabIndex = 80;
            this.label7.Text = "Visualizar Veiculo";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(13, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 82;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "Cliente:";
            // 
            // txtVisCliente
            // 
            this.txtVisCliente.Location = new System.Drawing.Point(445, 367);
            this.txtVisCliente.Name = "txtVisCliente";
            this.txtVisCliente.ReadOnly = true;
            this.txtVisCliente.Size = new System.Drawing.Size(273, 20);
            this.txtVisCliente.TabIndex = 83;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoTorque.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(206, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 297);
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // frmVisualizarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVisCliente);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVisAno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVisPlaca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVisMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVisModelo);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVisualizarVeiculo";
            this.Text = "Visualizar de Veiculo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVisAno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVisPlaca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVisMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVisModelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVisCliente;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}