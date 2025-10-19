namespace Builder.Product
{
    public class Pizza
    {
        public string TipoMassa { get; set; }
        public string TipoBorda { get; set; }
        public string Tamanho { get; set; }
        public List<string> Ingredientes { get; set; }

        public void PizzaConteudo()
        {
            Console.WriteLine(TipoMassa);
            Console.WriteLine(TipoBorda);
            Console.WriteLine(Tamanho);

            foreach (var item in Ingredientes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
