using Prototype.ConcretePrototype;

internal class Program
{
    static void Main(string[] args)
    {
        Soldado soldado = new Soldado();

        soldado.Nome = "Sol1";
        soldado.Arma = "arma1";
        soldado.Acessorio = new Acessorio { Nome = "acess1"};

        Soldado sol1 = (Soldado)soldado.Clone();

        sol1.Nome = "opa";
        sol1.Arma = "aa";
        sol1.Acessorio = new Acessorio { Nome = "auds" };
    }
}