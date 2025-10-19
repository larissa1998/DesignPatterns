//obter fabricas
using AbstractFactory.Domain.Enums;
using AbstractFactory.Domain.Products;
using AbstractFactory.Factory.AbstractFactory;

var boloFactory = MassaAbstractFactory.CriarFabricaMassas(TipoMassa.Bolo);
var pizzaFactory = MassaAbstractFactory.CriarFabricaMassas(TipoMassa.Pizza);

//criar objetos com base no tipo : bolo
var bolo1 = boloFactory.CriarMassa((TipoMassa)TipoBolo.Laranja);
var bolo2 = boloFactory.CriarMassa((TipoMassa)TipoBolo.chocolate);

//criar objetos com base no tipo : pizza
var pizza1 = pizzaFactory.CriarMassa((TipoMassa)TipoPizza.Calabresa);
var pizza2 = pizzaFactory.CriarMassa((TipoMassa)TipoPizza.Mussarela);

//exibir os detalhes
ExibirDetalhes(bolo1);
ExibirDetalhes(bolo2);
ExibirDetalhes(pizza1);
ExibirDetalhes(pizza2);

Console.ReadLine();

static void ExibirDetalhes(MassaBase massaBase)
{
    Console.WriteLine(massaBase.TipoMassa);
}