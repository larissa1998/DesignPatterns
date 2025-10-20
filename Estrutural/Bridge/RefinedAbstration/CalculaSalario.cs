using Bridge.Abstration;
using Bridge.Domain;
using Bridge.Implementor;

namespace Bridge.RefinedAbstration
{
    public class CalculaSalario : AbstractionGeraArquivo
    {

        public CalculaSalario(IGeraArquivo geraArquivo) : base(geraArquivo) { }

        public void ProcessaSalarioFuncionario(Funcionario funcionario) 
        { 
            funcionario.SalarioTotal = funcionario.SalarioBase + funcionario.Incentivo;

            Console.WriteLine(funcionario.Id +  funcionario.SalarioTotal);

            GeraArquivo.GravaArquivo(funcionario);
        }
    }
}
