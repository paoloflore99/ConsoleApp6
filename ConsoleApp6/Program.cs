namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IVolo> ListaA = new List<IVolo>();
            ListaA.Add(new Drone());
            ListaA.Add(new Aereo());

            foreach (var item in ListaA)
            {
                item.Vola();

            }
        }
    }
}
