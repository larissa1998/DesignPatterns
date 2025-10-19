namespace AbstractFactory.Domain.Products
{
    public sealed class BoloChocolate : Bolo
    {
        public BoloChocolate() : base("Bolo chocolate", Enums.TipoMassa.Bolo)
        {
            Ingredientes.Add("Com cobertura de chocolate");
        }
    }
}
