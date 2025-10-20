using System.Text.Json;
using Bridge.Domain;
using Bridge.Implementor;

namespace Bridge.ConcreteImplementor
{
    public class GeraJson : IGeraArquivo
    {
        public void GravaArquivo(Funcionario funcionario)
        {
            var nomeArquivo = "SalarioFuncionario.json";

            var funcionarioJson = JsonSerializer.Serialize(funcionario);

            File.WriteAllText(nomeArquivo, funcionarioJson);

            Console.WriteLine(funcionario.Nome +  nomeArquivo);
        }
    }
}
