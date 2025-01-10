// using System;
// namespace Aula23
// {
//     public class Executar
//     {
//         public struct Point
//         {
//             public int X { get; set; }

//             public int Y { get; set; }

//             //Construtor no struct é obrigatório inicializar todos os campos e ter parametros nele
//             public Point(int x, int y)
//             {
//                 X = x;
//                 Y = y;
//             }
//             public double Distance(Point p)
//             {
//                 X = 10;
//                 return Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2));

//             }
//         }
//         public class Player
//         {
//             public string Name { get; set; }
//             public Point Position { get; set; }
//             public Player (string name, Point position)
//             {
//                 Name = name;
//                 Position = position;
//             }
//             public void Move(Point newPosition)
//             {
//                 Position = newPosition;
//             }
//         }
//         public static void ExecutarExercicio()
//         {
//             Point p1 = new Point(10, 20);
//             Point p2 = new Point(5, 10);
            
//             System.Console.WriteLine($"Distância entre p1 e p2: {p1.Distance(p2)}");    

//             Player player = new Player("Jogador 1", p1);
//             System.Console.WriteLine($"Posição do jogador: {player.Position.X}, {player.Position.Y}");
//         }
//     }
// }