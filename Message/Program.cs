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
        //г) Сформировать строку из самых длинных слов сообщения.
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любую фразу: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(" ");
           

            Console.WriteLine($"Слова сообщения, которые содержат не более 5 букв: {FiveChar(words)}");
            Console.WriteLine($"Сообщение без слов, которые заканчиваются на заданный символ(s): {LastChar(words)}");
            Console.WriteLine($"Cамое длинное слово сообщения: {BigWord(words)}");
            Console.WriteLine($"Строкa из самых длинных слов сообщения: {BigWords(words)}");

        }

        /// <summary>
        /// функция выбирающая слова, содержащие не более 5 букв
        /// </summary>
        /// <param name="words"> массив слов</param>
        /// <returns></returns>
        private static string FiveChar(string [] words)          
        {
            string fiveChar="";
            for (int i = 0; i < words.Length; i++)

            {
                if (words[i].Length <= 5)
                {
                    fiveChar = ($"{fiveChar} {words[i]} ");
                }
                               
            }
            return fiveChar;
        }
        /// <summary>
        /// функция, игнорируюшая слова оканчивающиеся на заданный символ "s"
        /// </summary>
        /// <param name="words"> массив слов</param>
        /// <returns></returns>
        private static string LastChar(string [] words)
        {
            string lastChar = "";
            Regex last = new Regex(@"[s]$");
            for (int i = 0; i < words.Length; i++)
            {
                if (last.IsMatch(words[i]))
                {
                    continue;
                }
                else lastChar = ($"{lastChar} {words[i]} ");
            }
            return lastChar;
        }
        /// <summary>
        /// функция, выбирающая самое длинное слово
        /// </summary>
        /// <param name="words">массив слов</param>
        /// <returns></returns>
        private static string BigWord(string[] words)
        {
            string bigWord = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (bigWord.Length < words[i].Length)
                {
                    bigWord = words[i];
                }

            }
            return bigWord;
        }
        /// <summary>
        /// функция, отбирающая самые длинные слова
        /// </summary>
        /// <param name="words"> массив слов</param>
        /// <returns></returns>
        private static string BigWords(string [] words)
        {
            string bigWords = "";
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                count += words[i].Length;
            }
            count = count / words.Length;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= count)
                {
                    bigWords = ($"{bigWords} {words[i]} ");
                }
            }
            return bigWords;
        }


    }
}
