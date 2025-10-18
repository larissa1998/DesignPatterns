namespace PizzariaSemFactory
{
    public class PizzaMussarela
    {
        public string Nome { get; set; }
        public PizzaMussarela()
        {
            Nome = "Pizza de mussarela";
        }

        public void Preparar()
        {
            Console.WriteLine("Preparando pizza" + Nome);
        }
        public void Assar(int tempo)
        {
            Console.WriteLine("Preparando de" + Nome + "assando por" + tempo + "min");
        }
        public void Embalar()
        {
            Console.WriteLine("Embalando pizza" + Nome);
        }
    }
}
