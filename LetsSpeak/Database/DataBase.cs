using LetsSpeak.Interfaces;
using System.Collections.Generic;
using System.Text.Json;

namespace LetsSpeak
{
    public class DataBase : IDataBase
    {
        public static Dictionary<string, string> Contents = new Dictionary<string, string>();

        private static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.json");
        public static void Include()
        {
            Console.Write("Digite o termo de deseja incluir no dicionário: ");
            var term = Console.ReadLine();
            Console.Write("Ditite o significado do termo: ");
            var meaning = Console.ReadLine();
            Contents.Add(term, meaning);
            Save();
        }
        public static void Save()
        {
            var content = JsonSerializer.Serialize(Contents);
            File.WriteAllText(dbPath, content);
        }
        public static void Initialize()
        {
            if (!File.Exists(dbPath))
                Save();

            var content = File.ReadAllText(dbPath);
            Contents = JsonSerializer.Deserialize<Dictionary<string,string>>(content);
        }

    }
}