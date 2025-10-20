namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance;
        private int numeroInstancia  = 0;

        public Singleton() 
        {
            Console.WriteLine("instanciando");
            numeroInstancia++;
            Console.WriteLine("num instancia" + numeroInstancia);
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
