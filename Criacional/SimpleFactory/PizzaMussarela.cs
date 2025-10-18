namespace SimpleFactory
{
    public class PizzaMussarela : Pizza
    {
        public PizzaMussarela()
        {
            Nome = "Pizza de mussarela";
        }

        public override void Preparar()
        {
            Console.WriteLine("Preparando pizza" + Nome);
        }
        public override void Assar(int tempo)
        {
            Console.WriteLine("Preparando de" + Nome + "assando por" + tempo + "min");
        }
        public override void Embalar()
        {
            Console.WriteLine("Embalando pizza" + Nome);
        }
    }
}
