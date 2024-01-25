namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TripleDictionary ukrainianEnglishGermar = new TripleDictionary("Українаська", "English", "Deutsch");
            ukrainianEnglishGermar.AddWord("дерево", "tree", "Baum");
            ukrainianEnglishGermar.AddWord("стіл", "table", "Tabelle");
            ukrainianEnglishGermar.AddWord("книга", "book", "Buch");
            ukrainianEnglishGermar.AddWord("сковорода", "pan", "Bratpfanne");
            ukrainianEnglishGermar.AddWord("олівець", "pensil", "Bleistift");
            ukrainianEnglishGermar.AddWord("вулиця", "street", "Straße");
            ukrainianEnglishGermar.AddWord("яблуко", "apple", "Apfel");
            ukrainianEnglishGermar.AddWord("продукти", "grocery", "Produkte");
            ukrainianEnglishGermar.AddWord("приклад", "example", "Beispiel");

            Console.WriteLine("enter your ukrainian word:");
            string word = Console.ReadLine();
            Console.WriteLine($"English translate: {ukrainianEnglishGermar.GetLanguage1Translate(word)}");
            Console.WriteLine($"Deutsch translate: {ukrainianEnglishGermar.GetLanguage2Translate(word)}");
            Console.WriteLine("\nAll added words:");
            foreach (var item in ukrainianEnglishGermar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
