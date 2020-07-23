using System;
using System.Text.RegularExpressions;


namespace Login
{
    class Program
    {
        // Головинская Юлия Викторовна
        // Создать программу, которая будет проверять корректность ввода логина.Корректным логином будет строка от 2 до 10 символов, 
        // содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
        // а) без использования регулярных выражений;
        //б) с использованием регулярных выражений.
        static void Main(string[] args)
        {
            #region login

            //Console.WriteLine("Введите логин: ");
            //bool valid ;
            //string login;
            //string s1 = "Отлично.";
            //string s2 = "Логин должен состоять из букв латинского алфавита или цифр(первый символ логина не может быть цифрой). Длина логина от 2 до 10 символов.";
            //string s3;
            //do
            //{
            //    login = Console.ReadLine();
            //    valid = false;
            //    if ((login.Length >= 2 && login.Length <= 10)
            //        && (login[0] >= 'a' && login[0] <= 'z')
            //       || (login[0] >= 'A' && login[0] <= 'Z'))
            //    {
            //        for (int i = 1; i < login.Length; i++)
            //        {
            //            if ((login[i] >= '0' && login[i] <= '9')
            //                || (login[i] >= 'a' && login[i] <= 'z')
            //                || (login[i] >= 'A' && login[i] <= 'Z'))
            //                valid = true;
            //            else valid = false;
            //        }
            //    }
            //    else valid = false;

            //    s3 = valid == true ? s1 : s2;
            //    Console.WriteLine(s3);
            //} while (valid==false);

            #endregion
            #region LoginRegex




            //разобраться почему проходит вариант c повторяющейся буквой например: ghhhhhhhhhkkkkkkkkkkkkk

            //Regex LoginValid = new Regex(@"^[a-zA-Z]+[0-9a-zA-Z]{1,9}$");

            //string login;
            //do
            //{
            //    Console.WriteLine("Логин должен состоять из букв латинского алфавита \nили цифр(первый символ логина не может быть цифрой). \nДлина логина от 2 до 10 символов. \nВведите логин: ");
            //    login = Console.ReadLine();

            //} while (LoginValid.IsMatch(login) == false);

            //Console.WriteLine("Отлично!");




            #endregion

        }

    }
}
