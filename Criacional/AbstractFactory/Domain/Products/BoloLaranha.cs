namespace AbstractFactory.Domain.Products
{
    public sealed class BoloLaranha : Bolo
    {
        public BoloLaranha() : base("Bolo laranja", Enums.TipoMassa.Bolo)
        {
            Ingredientes.Add("Com cobertura de laranja");
        }
    }
}
