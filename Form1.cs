namespace WinFormsApp1
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();
            f.nome = tx_nome.Text;
            f.email = tx_email.Text;
            f.cpf = tx_cpf.Text;
            f.salario = Convert.ToDouble(num_salario.Value);
            f.funcao = cb_funcao.Text;
            double resultado = f.CalcularSalario();
            lb_resultado.Text = "O salário final é de " + resultado.ToString();
        }
    }
}