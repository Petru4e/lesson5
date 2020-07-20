using System;
using System.Text.RegularExpressions;

namespace Message
{
    class Program
    {
        //Разработать класс Message, содержащий следующие статические методы для обработки
        //текста:
        //а) Вывести только те слова сообщения, которые содержат не более n букв.
        //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        //в) Найти самое длинное слово сообщения.
        //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        //Продемонстрируйте работу программы на текстовом файле с вашей программой.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любую фразу: ");
            string words = Console.ReadLine();
            
            Console.WriteLine($"Слова сообщения, которые содержат не более 5 букв: {FiveWords(words)}");
            Console.WriteLine($"Сообщение без слов, которые заканчиваются на заданный символ(s): {NoWords(words)}");
            Console.WriteLine($"Cамое длинное слово сообщения");
            Console.WriteLine($"Строкa из самых длинных слов сообщения: ");

        }
        static string NoWords(string words)
        {
            Regex minWord = new Regex(@"s$");
            string minWords = default;
            foreach (Match match in minWord.Matches(words))
            {
                minWords = match.Value;
            }
            return minWords;
        }
        static string FiveWords(string words)
        {
            Regex minWord = new Regex(@".{1,9}");
            string minWords = default;
            foreach (Match match in minWord.Matches(words))
            {
                minWords = match.Value;
            }
            return minWords;
        }

    }
}
