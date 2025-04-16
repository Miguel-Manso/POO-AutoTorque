using AutoTorque.Views;
using System;
using System.Windows.Forms;
using System.Threading;
using AutoTorque.Controllers;

namespace AutoTorque
{
    public partial class frmPrincipal : Form
    {
        Thread t1;
        private System.Windows.Forms.Timer timer; 
        private ToolStripLabel dateTimeLabel; 
        private MenuStrip menuStrip; 
        public frmPrincipal()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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

            // Inicializa MenuStrip e ToolStripLabel
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            t1 = new Thread(() =>
            {
                //Manten a posição
                frmCadastrar cadastrarForm = new frmCadastrar();

                
                cadastrarForm.StartPosition = FormStartPosition.Manual; 
                cadastrarForm.Location = new System.Drawing.Point(
                    this.Location.X + (this.Width - cadastrarForm.Width) / 2, 
                    this.Location.Y + (this.Height - cadastrarForm.Height) / 2 
                );

                // Executa o novo formulário
                Application.Run(cadastrarForm);
            });
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
            
            this.Close();
        }
    }
}
