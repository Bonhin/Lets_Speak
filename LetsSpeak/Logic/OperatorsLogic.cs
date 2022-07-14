namespace LetsSpeak.Logic
{
    public static class OperatorsLogic
    {
        private static string SearchTerm { get; set; }
        public static void Find()
        {
            int flag = 0;
            SearchTerm = Console.ReadLine();

            foreach (var term in DataBase.Contents)
            {
                if (term.Key.Contains(SearchTerm, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"{term.Key} : {term.Value}");
                }
                else
                {
                    flag++;
                }
            }
            if (flag == DataBase.Contents.Count())
            {
                Console.WriteLine("Nenhum termo encontrado");
            }
        }
    }
}