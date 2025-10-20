using Adapter.Domain;

namespace Adapter.Adaptee
{
    public class SistemaMensalidade
    {
        public void CalculaMensalidade(List<Aluno> listaAlunos)
        {
            foreach (Aluno aluno in listaAlunos)
            {
                Console.WriteLine($"Aluno {aluno.Nome}" + $"valor da mensalidade {aluno.Mensalidade}");
            }
        }
    }
}
