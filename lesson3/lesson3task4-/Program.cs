using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3task4_
{
    class Program
    {
        static void Main(string[] args)
        {
            string emptyCell = "o";
            string shipCell = "x";
            int fieldSize = 10;
            string[,] field = new string[fieldSize, fieldSize];
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = emptyCell;
                }
            }
            Console.WriteLine("Необходимо ввести координаты кораблей");
            Console.WriteLine("Они задаются в виде: x y z, где");
            Console.WriteLine("x - координата по x");
            Console.WriteLine("y - координата по y");
            Console.WriteLine("z - ориентация (вертикальная 1/горизонтальная 0)");
            Console.WriteLine("Пример входной строки: 1 0 0");

            Console.WriteLine("Введите четырёхпалубник:");
            string ship = Console.ReadLine();
            string[] shipArr = ship.Split(' ');
            int shipX = Convert.ToInt32(shipArr[0]);
            int shipY = Convert.ToInt32(shipArr[1]);
            int shipOr = Convert.ToInt32(shipArr[2]);

            if (shipOr == 0)
            {
                for (int i = shipX; i <= shipX+3; i++)
                {
                    field[shipY, i] = shipCell;
                }
            }
            if (shipOr == 1)
            {
                for (int i = shipY; i <= shipY + 3; i++)
                {
                    field[i, shipX] = shipCell;
                }
            }


            for (int a = 0; a < 2; a++)
            {
                Console.WriteLine("Введите трёхпалубник:");
                ship = Console.ReadLine();
                shipArr = ship.Split(' ');
                shipX = Convert.ToInt32(shipArr[0]);
                shipY = Convert.ToInt32(shipArr[1]);
                shipOr = Convert.ToInt32(shipArr[2]);

                if (shipOr == 0)
                {
                    for (int i = shipX; i <= shipX + 2; i++)
                    {
                        field[shipY, i] = shipCell;
                    }
                }
                if (shipOr == 1)
                {
                    for (int i = shipY; i <= shipY + 2; i++)
                    {
                        field[i, shipX] = shipCell;
                    }
                }
            }

            for (int a = 0; a < 3; a++)
            {
                Console.WriteLine("Введите двухпалубник:");
                ship = Console.ReadLine();
                shipArr = ship.Split(' ');
                shipX = Convert.ToInt32(shipArr[0]);
                shipY = Convert.ToInt32(shipArr[1]);
                shipOr = Convert.ToInt32(shipArr[2]);

                if (shipOr == 0)
                {
                    for (int i = shipX; i <= shipX + 1; i++)
                    {
                        field[shipY, i] = shipCell;
                    }
                }
                if (shipOr == 1)
                {
                    for (int i = shipY; i <= shipY + 1; i++)
                    {
                        field[i, shipX] = shipCell;
                    }
                }
            }

            for (int a = 0; a < 4; a++)
            {
                Console.WriteLine("Введите однопалубник:");
                ship = Console.ReadLine();
                shipArr = ship.Split(' ');
                shipX = Convert.ToInt32(shipArr[0]);
                shipY = Convert.ToInt32(shipArr[1]);
                shipOr = Convert.ToInt32(shipArr[2]);

                field[shipY, shipX] = shipCell;

            }

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write($"{field[i, j]} \t");
                }

                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}
