namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static List<int> Filtrer(List<int> entiers, Func<int,bool> filtre)
        {
            List<int> result = new List<int>();
            
            foreach (int entier in entiers)
            {
                if (filtre(entier))
                {
                    result.Add(entier);
                }
            }
            return result;
        }

        static void Main(string[] args)
        {            
            List<int> entiers = new List<int> { 1, 2, 3, 4, 5 };
            // Filtrer les nombres pairs
            List<int> pairs = Filtrer(entiers, x => x % 2 == 0);
            Console.WriteLine(string.Join(", ", pairs));
            // Affiche "2, 4"
            // Filtrer les nombres impairs
            List<int> impairs = Filtrer(entiers, x => x % 2 == 1);
            Console.WriteLine(string.Join(", ", impairs));
            // Affiche "1, 3, 5"
            // Filtrer les nombres plus grands que 3
            List<int> grands = Filtrer(entiers, x => x > 3);
            Console.WriteLine(string.Join(", ", grands));
            // Affiche "4, 5"
        }
    }
}