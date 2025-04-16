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
using System.Windows.Forms;

namespace AutoTorque.Views
{
    public partial class frmCadastroVeiculo : Form
    {
        Thread t1;
        private ClienteController clienteController;
        private VeiculoController veiculoController;
        private VeiculoCollection veiculoCollection;
        private System.Windows.Forms.Timer timer; 
        private ToolStripLabel dateTimeLabel; 
        private MenuStrip menuStrip; 

        public frmCadastroVeiculo()
        {
            clienteController = new ClienteController();
            veiculoController = new VeiculoController();
            veiculoCollection = new VeiculoCollection();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            clienteLoad();
            veiculoLoad();
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

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            // Validação dos campos
            if (string.IsNullOrWhiteSpace(txtModelo.Text) ||
                string.IsNullOrWhiteSpace(txtMarca.Text) ||
                string.IsNullOrWhiteSpace(txtAno.Text) ||
                string.IsNullOrWhiteSpace(txtPlaca.Text) ||
                cmbCliente.SelectedItem == null)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos e um cliente deve ser selecionado.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Interrompe a execução se algum campo estiver vazio ou cliente não selecionado
            }

            // Verifica se o ano é um número válido
            if (!int.TryParse(txtAno.Text, out int ano) || ano < 1886) // O primeiro carro foi inventado em 1886
            {
                MessageBox.Show("O ano deve ser um número válido e maior que 1886.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Interrompe a execução se o ano não for válido
            }

            // Verifica se a placa já está cadastrada
            foreach (var existente in veiculoCollection)
            {
                if (existente.Placa.Equals(txtPlaca.Text, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Esta placa já está cadastrada.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Interrompe a execução se a placa já existir
                }
            }

            // Se todas as validações passarem, prossegue com a inserção
            Veiculo novoVeiculo = new Veiculo
            {
                Modelo = txtModelo.Text,
                Marca = txtMarca.Text,
                Ano = ano,
                Placa = txtPlaca.Text,
                Cliente = (Cliente)cmbCliente.SelectedItem
            };

            veiculoController.Inserir(novoVeiculo);
            veiculoCollection.Add(novoVeiculo);

            AtualizarLista();

            // Limpa os campos de texto
            txtModelo.Clear();
            txtMarca.Clear();
            txtPlaca.Clear();
            txtAno.Clear();
            cmbCliente.SelectedItem = null; // Limpa a seleção do cliente
        }

        private void AtualizarLista()
        {
            lstVeiculo.DataSource = null;
            lstVeiculo.DataSource = veiculoCollection.Listar();
            lstVeiculo.DisplayMember = "ModeloMarcaPlaca";
        }

        private void veiculoLoad()
        {
            List<Veiculo> veiculos = veiculoController.carregarVeiculo();

            veiculoCollection.AddRange(veiculos);

            AtualizarLista();
        }
        
        private void clienteLoad()
        {
            ClienteCollection clientes = clienteController.carregarCliente();

            cmbCliente.DataSource = clientes;
            cmbCliente.DisplayMember = "Nome";
            cmbCliente.ValueMember = "IdCliente";

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

        private void Cadastro(object obj)
        {
            Application.Run(new frmCadastrar());
        }

        private void btnVisRegistros_Click_1(object sender, EventArgs e)
        {
            Veiculo veiculoSelecionado = lstVeiculo.SelectedItem as Veiculo;

            if (veiculoSelecionado != null)
            {
                frmVisualizarVeiculo frm = new frmVisualizarVeiculo(veiculoSelecionado);
                frm.ShowDialog(); // Abre o formulário de visualização de veículo
            }
            else
            {
                MessageBox.Show("Por favor, selecione um cliente."); // Mensagem de erro
            }
        }

        private void txtAno_TextChanged(object sender, EventArgs e)
        {
            // Remove qualquer caractere que não seja dígito
            string anoInput = txtAno.Text;
            string anoNumeros = new string(anoInput.Where(char.IsDigit).ToArray());

            // Atualiza o campo de texto com os números válidos
            txtAno.Text = anoNumeros;

            // Define o cursor na posição correta
            txtAno.SelectionStart = txtAno.Text.Length;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            // Verifica se um veículo está selecionado na lista
            Veiculo veiculoSelecionado = lstVeiculo.SelectedItem as Veiculo;

            if (veiculoSelecionado != null)
            {
                // Solicita confirmação do usuário
                var resultado = MessageBox.Show(
                    "Tem certeza que deseja deletar este veículo?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Se o usuário confirmar a deleção
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Chama o método para deletar no VeiculoController
                        veiculoController.Apagar(veiculoSelecionado.IdVeiculo); // Certifique-se de que IdVeiculo existe

                        // Remove o veículo da coleção local
                        veiculoCollection.Remove(veiculoSelecionado);

                        // Atualiza a lista exibida
                        AtualizarLista();

                        MessageBox.Show("Veículo deletado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao deletar veículo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Caso nenhum veículo esteja selecionado
                MessageBox.Show("Por favor, selecione um veículo para deletar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Veiculo veiculoSelecionado = lstVeiculo.SelectedItem as Veiculo;
            Cliente clienteSelecionado = (Cliente)cmbCliente.SelectedItem;

            if (veiculoSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um veículo para alterar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtModelo.Text) ||
                string.IsNullOrWhiteSpace(txtMarca.Text) ||
                string.IsNullOrWhiteSpace(txtPlaca.Text) ||
                string.IsNullOrWhiteSpace(txtAno.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPlaca.Text.Length != 7)
            {
                MessageBox.Show("A Placa deve conter exatamente 7 dígitos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtAno.Text.Length != 4)
            {
                MessageBox.Show("O Ano deve conter exatamente 4 números.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            veiculoSelecionado.Modelo = txtModelo.Text;
            veiculoSelecionado.Marca = txtMarca.Text;
            veiculoSelecionado.Placa = txtPlaca.Text;
            veiculoSelecionado.Ano = Convert.ToInt32(txtAno.Text);
            veiculoSelecionado.Cliente = clienteSelecionado;

            veiculoController.Alterar(veiculoSelecionado);

            AtualizarLista();

            txtModelo.Clear();
            txtMarca.Clear();
            txtPlaca.Clear();
            txtAno.Clear();
        }
    }
}
