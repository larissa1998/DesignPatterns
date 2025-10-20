//separar a interface do obj e da sua implementacao
//I como uma ponte, abstração e implementação dividido separadamente
using Bridge.ConcreteImplementor;
using Bridge.Domain;
using Bridge.RefinedAbstration;

class Program
{
    static void Main(string[] args)
    {
        CalculaSalario calculaSalario = new CalculaSalario(new GeraXml());

        Funcionario funcionario = new Funcionario
        {
            Id = 101,
            Nome = "teste",
            SalarioBase = 3000,
            Incentivo = 200
        };

        calculaSalario.ProcessaSalarioFuncionario(funcionario);

        funcionario.Incentivo = 2500;

        calculaSalario  = new CalculaSalario(new GeraJson());

        calculaSalario.ProcessaSalarioFuncionario(funcionario);

        Console.ReadKey();
    }
}