using System;

namespace Самый_первый
{


    class Program
    {
        static void Main(string[] args)
        {   //типы переменных
            string exampleString = "Hello World!"; // - простейший
            int exampleInt = 4; //- 4 байта, целое число
            double exampleDouble = 50.5; //- целая или дробная часть, лучше, чем  float
            
            float exampleFloat = 50.5f;
            short exampleShort = 50; //- 2 байта
            long exampleLong = 50; //- 8 байт

            bool exampleBoolean = true; //-внутри условия 
            char exampleCharacter = 'n'; //только один символ
            char[] exampleCharacters = { 'f', 'e', 'q' };

           //Тест массивов и строк
            string[] hellos = { "Hallo", "Hello", "Salve", "Ciao" };
            Console.WriteLine(hellos[0]); //Hallo
            Console.WriteLine(hellos[3]); //Ciao

            Console.WriteLine(exampleString);

            //for
            //while - пока
            //foreach
            
            //for (int i = 0; i < exampleInt; i++)
            int i = 0;
            foreach (string hello in hellos)
            {
                Console.WriteLine(hello);
                i++;
                Console.WriteLine("Вы продолжили" + i + "раз.");
            }

            exampleCharacter = Console.ReadLine()[0];

            switch(exampleCharacter)
            {
                case 'n':
                    Console.WriteLine("Это N");
                    break;

                case 't':
                    Console.WriteLine("Это t");
                    break;
                
                default:
                    Console.WriteLine("Это ни один из символов");
                    break;

            }
            //Контатинация = сложение строк + .. +
               //тест условия
                /* 
                if (Console.ReadKey().Key == ConsoleKey.N)
                {
                    Console.WriteLine("\nВы продолжили");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nВы остановились");
                    Console.ReadKey();

                }
                */
             



        } 

    }
}
