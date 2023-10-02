using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Зравствуйте,введите пожалуйста пять переменных");
                bool i = false;
                int lenght, width, height, LowerSide, LateralSide;
                Console.Write("длина =");
                lenght = Convert.ToInt32(Console.ReadLine());
                Console.Write("ширина=");
                width = Convert.ToInt32(Console.ReadLine());
                Console.Write("высота=");
                height = Convert.ToInt32(Console.ReadLine());
                Console.Write("Нижняя Сторона = ");
                LowerSide = Convert.ToInt32(Console.ReadLine());
                Console.Write("Боковая Сторона = ");
                LateralSide = Convert.ToInt32(Console.ReadLine());
                if ((lenght < 0) || (width < 0) || (height < 0) || (LowerSide < 0) || (LateralSide < 0))
                {
                    Console.WriteLine("Недопустимые значения");
                }
                else
                {
                    switch ((lenght <= LowerSide) && (lenght <= LateralSide))
                    {
                        case true:
                            i = true;
                            break;
                    }
                    switch ((width <= LowerSide) && (width <= LateralSide))
                    {
                        case true:
                            i = true;
                            break;
                    }
                    switch ((height <= LowerSide) && (height <= LateralSide))
                    {
                        case true:
                            i = true;
                            break;
                    }
                    switch ((i))
                    {
                        case true:
                            Console.WriteLine("Кирпич пройдет");
                            break;
                        case false:
                            Console.WriteLine("Кирпич не пройдет");
                            break;
                    }
                }
            }
            catch (FormatException fe)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введены недопустимые значения. " + fe.Message);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введены недопустимые значения. " + e.Message);
            }

            Console.ReadKey();
        }
    }
}
