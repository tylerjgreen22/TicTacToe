using System;

namespace TicTacToe
{
    internal class Program
    {
        static string[,] board =
            {
                {"1", "2", "3" },
                {"4", "5", "6" },
                {"7", "8", "9" }
            };
        static int counter = 0;
        static string player;
        static void Main(string[] args)
        {
            while (true)
            {
                counter++;
                Console.Clear();

                WriteBoard();
                Console.WriteLine($"Turn: {counter}");

                if (CheckDraw() || CheckWin(board))
                {
                    Console.Clear();
                    Console.WriteLine(CheckDraw() ? "Draw" : $"Player {player} wins.");
                    if (ResetGame() == "0")
                    {
                        break;
                    }
                    continue;
                }

                UpdatePlayer(counter);
                UpdateBoard();
            }
        }

        public static void WriteBoard()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (j == 1)
                    {
                        Console.Write($"| {board[i, j]} |");
                    }
                    else
                    {
                        Console.Write($" {board[i, j]} ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void UpdatePlayer(int counter)
        {
            if (counter % 2 == 1)
            {
                player = "X";
            }
            else
            {
                player = "O";
            }
        }

        public static void UpdateBoard()
        {
            bool getOut = false;

            while (!getOut)
            {
                Console.WriteLine($"Player {player}, choose a number.");
                string playerInput = Console.ReadLine();
                switch (playerInput)
                {
                    case "1":
                        if (board[0, 0] != "X" && board[0, 0] != "O")
                        {
                            board[0, 0] = player;
                            getOut = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Entry taken");
                            break;
                        }
                    case "2":
                        if (board[0, 1] != "X" && board[0, 1] != "O")
                        {
                            board[0, 1] = player;
                            getOut = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Entry taken");
                            break;
                        }
                    case "3":
                        if (board[0, 2] != "X" && board[0, 2] != "O")
                        {
                            board[0, 2] = player;
                            getOut = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Entry taken");
                            break;
                        }
                    case "4":
                        if (board[1, 0] != "X" && board[1, 0] != "O")
                        {
                            board[1, 0] = player;
                            getOut = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Entry taken");
                            break;
                        }
                    case "5":
                        if (board[1, 1] != "X" && board[1, 1] != "O")
                        {
                            board[1, 1] = player;
                            getOut = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Entry taken");
                            break;
                        }
                    case "6":
                        if (board[1, 2] != "X" && board[1, 2] != "O")
                        {
                            board[1, 2] = player;
                            getOut = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Entry taken");
                            break;
                        }
                    case "7":
                        if (board[2, 0] != "X" && board[2, 0] != "O")
                        {
                            board[2, 0] = player;
                            getOut = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Entry taken");
                            break;
                        }
                    case "8":
                        if (board[2, 1] != "X" && board[2, 1] != "O")
                        {
                            board[2, 1] = player;
                            getOut = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Entry taken");
                            break;
                        }
                    case "9":
                        if (board[2, 2] != "X" && board[2, 2] != "O")
                        {
                            board[2, 2] = player;
                            getOut = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Entry taken");
                            break;
                        }

                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }
            }
        }

        public static bool CheckWin(string[,] board)
        {
            // Vertical
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (board[i, j] == board[i, j + 1] && board[i, j] == board[i, j + 2])
                    {
                        return true;
                    }
                }
            }

            // Horizontal
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == board[i + 1, j] && board[i, j] == board[i + 2, j])
                    {
                        return true;
                    }
                }
            }

            // Diagonal One
            if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2])
            {
                return true;
            }

            // Diagonal Two
            if (board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0])
            {
                return true;
            }
            return false;
        }

        public static bool CheckDraw()
        {
            if (counter == 10) return true;
            return false;
        }

        public static string ResetGame()
        {
            string[,] initialBoard =
            {
                {"1", "2", "3" },
                {"4", "5", "6" },
                {"7", "8", "9" }
            };
            WriteBoard();
            board = initialBoard;
            counter = 0;
            Console.WriteLine("Press any key to reset the game. Or press 0 to exit.");
            string choice = Console.ReadLine();
            return choice;
        }
    }
}
