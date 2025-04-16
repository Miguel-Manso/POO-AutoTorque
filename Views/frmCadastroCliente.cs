using AutoTorque.Controllers;
using AutoTorque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace AutoTorque.Views
{
    public partial class frmCadastroCliente : Form
    {
        Thread t1;
        ClienteController clienteController = new ClienteController();
        ClienteCollection clienteCollection = new ClienteCollection();
        private System.Windows.Forms.Timer timer; 
        private ToolStripLabel dateTimeLabel; 
        private MenuStrip menuStrip; 

        public frmCadastroCliente()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            clienteLoad();
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Validação dos campos
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCpf.Text) ||
                string.IsNullOrWhiteSpace(txtTelefone.Text) ||
                string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Interrompe a execução se algum campo estiver vazio
            }

            // Verifica se o CPF e o Telefone têm exatamente 11 caracteres
            if (txtCpf.Text.Length != 11)
            {
                MessageBox.Show("O CPF deve conter exatamente 11 números.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtTelefone.Text.Length != 11)
            {
                MessageBox.Show("O Telefone deve conter exatamente 11 números.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se o CPF e o Telefone já existem na lista de clientes
            foreach (var cliente in clienteCollection)
            {
                if (cliente.CPF == txtCpf.Text)
                {
                    MessageBox.Show("Este CPF já está cadastrado.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cliente.Telefone == txtTelefone.Text)
                {
                    MessageBox.Show("Este Telefone já está cadastrado.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Se todas as validações passarem, prossegue com a inserção
            Cliente clienteNovo = new Cliente
            {
                Nome = txtNome.Text,
                CPF = txtCpf.Text,
                Telefone = txtTelefone.Text,
                Endereco = txtEndereco.Text
            };

            clienteController.Inserir(clienteNovo);
            clienteCollection.Add(clienteNovo);

            AtualizarLista();

            // Limpa os campos de texto
            txtNome.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
            txtEndereco.Clear();
        }

        private void AtualizarLista()
        {
            lstCliente.DataSource = null;
            lstCliente.DataSource = clienteCollection.Listar();
            lstCliente.DisplayMember = "NomeCpfTelefone";
        }

        private void clienteLoad()
        {
            List<Cliente> clientes = clienteController.carregarCliente();

            clienteCollection.AddRange(clientes);

            AtualizarLista();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            t1 = new Thread(() =>
            {
                frmCadastrar cadastrarForm = new frmCadastrar();

                cadastrarForm.StartPosition = FormStartPosition.Manual; 
                cadastrarForm.Location = new System.Drawing.Point(
                    this.Location.X + (this.Width - cadastrarForm.Width) / 2, 
                    this.Location.Y + (this.Height - cadastrarForm.Height) / 2 
                );

                Application.Run(cadastrarForm);
            });
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

            this.Close(); 
        }

        private void btnVisRegistros_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = lstCliente.SelectedItem as Cliente;

            if (clienteSelecionado != null)
            {
                frmVisualizarCliente frm = new frmVisualizarCliente(clienteSelecionado);
                frm.ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Por favor, selecione um cliente.");
            }
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            // Remove qualquer caractere que não seja dígito
            string cpfInput = txtCpf.Text;
            string cpfNumeros = new string(cpfInput.Where(char.IsDigit).ToArray());

            // Atualiza o campo de texto com os números válidos
            txtCpf.Text = cpfNumeros;

            // Define o cursor na posição correta
            txtCpf.SelectionStart = txtCpf.Text.Length;
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            // Remove qualquer caractere que não seja dígito
            string telefoneInput = txtTelefone.Text;
            string telefoneNumeros = new string(telefoneInput.Where(char.IsDigit).ToArray());

            // Atualiza o campo de texto com os números válidos
            txtTelefone.Text = telefoneNumeros;

            // Define o cursor na posição correta
            txtTelefone.SelectionStart = txtTelefone.Text.Length;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = lstCliente.SelectedItem as Cliente;

            if (clienteSelecionado != null)
            {
                var resultado = MessageBox.Show(
                    "Tem certeza que deseja deletar este cliente?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Chama o método Apagar do ClienteController
                        clienteController.Apagar(clienteSelecionado.IdCliente);

                        // Remove o cliente da coleção local
                        clienteCollection.Remove(clienteSelecionado);

                        // Atualiza a lista exibida
                        AtualizarLista();

                        MessageBox.Show("Cliente deletado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao deletar cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um cliente para deletar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = lstCliente.SelectedItem as Cliente;

            if ( clienteSelecionado == null )
            {
                MessageBox.Show("Por favor, selecione um cliente para alterar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCpf.Text) ||
                string.IsNullOrWhiteSpace(txtTelefone.Text) ||
                string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtCpf.Text.Length != 11)
            {
                MessageBox.Show("O CPF deve conter exatamente 11 números.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtTelefone.Text.Length != 11)
            {
                MessageBox.Show("O Telefone deve conter exatamente 11 números.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clienteSelecionado.Nome = txtNome.Text; 
            clienteSelecionado.CPF = txtCpf.Text;
            clienteSelecionado.Endereco = txtEndereco.Text;
            clienteSelecionado.Telefone = txtTelefone.Text;

            clienteController.Alterar(clienteSelecionado);

            AtualizarLista();

            txtNome.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
            txtEndereco.Clear();
        }
    }
}
