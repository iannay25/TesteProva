public class Funcionario
{
    public string nome;
    public string email;
    public string cpf;
    public double salario;
    public string funcao;
    public string funcaoMedico;
    public string funcaoTI;
    public string funcaADM;

    public double CalcularSalario()
    {
        if (this.funcao == "Médico")
        {
            this.salario += salario * 20 / 100;

        }
        else if (this.funcao == "TI")
        {
            this.salario += salario = 5600;

        }
        else if (this.funcao == "ADM")
        {
            this.salario += salario * 15 / 100;
        }

        return this.salario;
    }
}