namespace ProjetoPetShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)

        {
            if (MessageBox.Show("Deseja mesmo sair?", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Minimizar

            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmCadCliente cliente = new FrmCadCliente();
            cliente.TopLevel= false;
            cliente.Dock= DockStyle.Fill;
            PanelCentral.Controls.Clear(); // Limpa o painel
            PanelCentral.Controls.Add(cliente); // Adiciona o formulário no painel
            cliente.Show();

            //Aplica a posição do eixo x do botão ao PanelSelecao

            PanelSelecao.Top = btnCliente.Top;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            PanelCentral.Controls.Clear();

            PanelSelecao.Top = btnInicio.Top;   
        }

        private void btnRaca_Click(object sender, EventArgs e)
        {
            FrmCadRaca raca = new FrmCadRaca();
            raca.TopLevel = false;
            raca.Dock = DockStyle.Fill;
            PanelCentral.Controls.Clear(); // Limpa o painel
            PanelCentral.Controls.Add(raca); //Adiciona o formulário no painel
            raca.Show();

            //Aplica a posição do eixo x do botão ao PanelSelecao

            PanelSelecao.Top = btnRaca.Top;

        }



        private void btnAnimal_Click(object sender, EventArgs e)
        {
            FrmCadAnimal animal = new FrmCadAnimal();
            animal.TopLevel = false;
            animal.Dock = DockStyle.Fill;
            PanelCentral.Controls.Clear(); // Limpa o painel
            PanelCentral.Controls.Add(animal);
            animal.Show();

            //Aplica a posição do eixo x do botão ao PanelSelecao

            PanelSelecao.Top = btnAnimal.Top;
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            FrmCadServico servico = new FrmCadServico();
            servico.TopLevel = false;
            servico.Dock = DockStyle.Fill;
            PanelCentral.Controls.Clear(); // Limpa o painel
            PanelCentral.Controls.Add(servico);
            servico.Show();

            //Aplica a posição do eixo x do botão ao PanelSelecao

            PanelSelecao.Top = btnServico.Top;
        }

        private void btnAgendamento_Click(object sender, EventArgs e)
        {
            FrmCadAgendamento agendamento = new FrmCadAgendamento();
            agendamento.TopLevel = false;
            agendamento.Dock = DockStyle.Fill;
            PanelCentral.Controls.Clear(); // Limpa o painel
            PanelCentral.Controls.Add(agendamento);
            agendamento.Show();

            //Aplica a posição do eixo x do botão ao PanelSelecao

            PanelSelecao.Top = btnAgendamento.Top;
        }
    }
}