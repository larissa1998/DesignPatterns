using Adapter.Adaptee;
using Adapter.Domain;
using Adapter.Target;

namespace Adapter.Adapter
{
    public class AlunoAdapter : ITarget
    {
        private SistemaMensalidade sistemaMensalidade = new SistemaMensalidade();

        public void ProcessaCalculoMensalidade(string[,] alunosArray)
        {
            string id = null;
            string nome = null;
            string curso = null;
            string mensalidade = null;

            List<Aluno> listaAlunos = new List<Aluno>();

            for (int i = 0; i < alunosArray.GetLength(0); i++)
            {
                for (int j = 0; j < alunosArray.GetLength(1); j++)
                {
                    if(j == 0)
                    {
                        id = alunosArray[i, j];
                    } 
                    else if(j == 1)
                    {
                        nome = alunosArray[i, j];
                    }
                    else if (j == 1)
                    {
                        curso = alunosArray[i, j];
                    }
                    else
                    {
                        mensalidade = alunosArray[i, j];
                    }
                }

                listaAlunos.Add(new Aluno(Convert.ToInt32(id), nome, curso, Convert.ToDecimal(mensalidade)));

                sistemaMensalidade.CalculaMensalidade(listaAlunos);
            }
        }
    }
}
