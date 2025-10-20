namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance = null;
        private static object lockObject = new object();

        private Singleton() 
        {
        }

        public static Singleton Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
                return instance;
            }
        }
    }
}
