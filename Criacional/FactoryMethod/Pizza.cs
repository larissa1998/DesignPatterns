using System.Collections;
using System.Text;

namespace FactoryMethod
{
    //Produto
    public abstract class Pizza
    {
        protected string Nome { get; set; }
        protected string Massa;
        protected string Molho;
        protected ArrayList Ingredientes = new ArrayList();

        public string Preparar() {
            StringBuilder sb = new StringBuilder();
            sb.Append(Nome);
            sb.Append(Massa);
            sb.Append(Molho);

            foreach (string ingrediente in Ingredientes)
            {
                sb.Append(' ');
            }

            sb.Append(Cozinhar());
            sb.Append(Fatiar());
            sb.Append(Embalar());

            return sb.ToString();
        }
    
        public virtual string Cozinhar()
        {
            return "Cozinhar";
        }

        public virtual string Fatiar()
        {
            return "Fatiar";
        }

        public virtual string Embalar()
        {
            return "Embalar";
        }
    }
}