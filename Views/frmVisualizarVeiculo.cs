using AutoTorque.Controllers;
using AutoTorque.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace AutoTorque.Views
{
    public partial class frmVisualizarVeiculo : Form
    {
        VeiculoController veiculoController = new VeiculoController();
        VeiculoCollection veiculoCollection = new VeiculoCollection();
        ClienteController clienteController = new ClienteController();
        private System.Windows.Forms.Timer timer; 
        private ToolStripLabel dateTimeLabel; 
        private MenuStrip menuStrip; 

        public frmVisualizarVeiculo(Veiculo veiculo)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            txtVisModelo.Text = veiculo.Modelo;
            txtVisMarca.Text = veiculo.Marca;
            txtVisPlaca.Text = veiculo.Placa;
            txtVisAno.Text = veiculo.Ano.ToString();
            txtVisCliente.Text = veiculo.Cliente.Nome;
            InitializeDateTimeDisplay(); 
        }

        private void InitializeDateTimeDisplay()
        {
            Panel redPanel = new Panel
            {
                BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000"), 
                Dock = DockStyle.Top, 
                Height = this.Height / 80 
            };

            menuStrip = new MenuStrip
            {
                BackColor = System.Drawing.ColorTranslator.FromHtml("#363636"), 
                ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF") 
            };

            dateTimeLabel = new ToolStripLabel
            {
                ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"), 
                AutoSize = false, 
                Width = 200 
            };
           
            timer = new System.Windows.Forms.Timer
            {
                Interval = 1000 
            };
            timer.Tick += Timer_Tick;
            timer.Start();
            
            menuStrip.Items.Add(dateTimeLabel);
            
            Controls.Add(redPanel); 
            Controls.Add(menuStrip); 
            
            UpdateDateTime();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void UpdateDateTime()
        {
            dateTimeLabel.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
