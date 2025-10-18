namespace PizzariaSemFactory
{
    public class PizzaCalabresa
    {
        public string Nome { get; set; }
        public PizzaCalabresa()
        {
            Nome = "Pizza de calabresa";
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
