using LetsSpeak.Logic;
using Sharprompt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsSpeak.View
{
    public static class ConsoleView
    {

        private static List<string> itens = new List<string>() { "Buscar termo", "Adicionoar termo" };
        public static void MenuGenerator()
        {

            Console.Clear();
            var selected = Prompt.Select("Selecione a opção desejada", itens);
            Console.WriteLine(selected);
            if(selected == itens[1])
            {
                Console.Clear();
                DataBase.Include();
                Console.Clear();
                Console.WriteLine("Item adicionado com sucesso");
            }
            else if(selected == itens[0])
            {
                Console.Clear();
                Console.Write("Digite o termo que deseja procurar: ");
                OperatorsLogic.Find();
            }
            Console.ReadKey();
            MenuGenerator();
        }
        public static void SetPrompt()
        {
            Prompt.ColorSchema.Answer = ConsoleColor.White;
            Prompt.ColorSchema.Select = ConsoleColor.White;

            Prompt.Symbols.Prompt = new Symbol("", "");
            Prompt.Symbols.Done = new Symbol("", "");
            Prompt.Symbols.Error = new Symbol("", "");
        }
    }
}
