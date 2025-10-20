using Bridge.Domain;
using Bridge.Implementor;

namespace Bridge.Abstration
{
    public abstract class AbstractionGeraArquivo
    {
        protected IGeraArquivo GeraArquivo;

        protected AbstractionGeraArquivo(IGeraArquivo geraArquivo)
        {
            this.GeraArquivo = geraArquivo;
        }

        public virtual void GravaArquivo(Funcionario funcionario)
        {
            GeraArquivo.GravaArquivo(funcionario);
        }
    }
}
