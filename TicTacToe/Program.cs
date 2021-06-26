using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace TicTacToe
{
    class Program
    {

        static public string[,] gameBoard =
        {
                {"1","2","3"},
                {"4","5","6"},
                {"7","8","9"}
        };

        static public string[,] __gameBoard =
{
                {"1","2","3"},
                {"4","5","6"},
                {"7","8","9"}
        };


        static public bool isPlayerOne = true;
        static public int freeFields = 9;

        static void Main(string[] args)
        {
            printGameBoard();
            askPlayer();
            Console.ReadKey();
        }

        static void printGameBoard()
        {
            
            Console.WriteLine(gameBoard[0, 0] + " | " + gameBoard[0, 1] + " | " + gameBoard[0, 2]);
            Console.WriteLine("__________");
            Console.WriteLine(gameBoard[1, 0] + " | " + gameBoard[1, 1] + " | " + gameBoard[1, 2]);
            Console.WriteLine("__________");
            Console.WriteLine(gameBoard[2, 0] + " | " + gameBoard[2, 1] + " | " + gameBoard[2, 2]);
        }

        static bool checkDuplicate(string inputField)
        {
            bool duplicate;

            switch (inputField)
            {
                case "1":
                    if (gameBoard[0,0] == "X" || gameBoard[0,0] == "O")
                    {
                        duplicate = true;
                    } else
                    {
                        duplicate = false;
                    }
                    break;
                case "2":
                    if (gameBoard[0, 1] == "X" || gameBoard[0, 1] == "O")
                    {
                        duplicate = true;
                    }
                    else
                    {
                        duplicate = false;
                    }
                    break;
                case "3":
                    if (gameBoard[0, 2] == "X" || gameBoard[0, 2] == "O")
                    {
                        duplicate = true;
                    }
                    else
                    {
                        duplicate = false;
                    }
                    break;
                case "4":
                    if (gameBoard[1, 0] == "X" || gameBoard[1, 0] == "O")
                    {
                        duplicate = true;
                    }
                    else
                    {
                        duplicate = false;
                    }
                    break;
                case "5":
                    if (gameBoard[1, 1] == "X" || gameBoard[1, 1] == "O")
                    {
                        duplicate = true;
                    }
                    else
                    {
                        duplicate = false;
                    }
                    break;
                case "6":
                    if (gameBoard[1, 2] == "X" || gameBoard[1, 2] == "O")
                    {
                        duplicate = true;
                    }
                    else
                    {
                        duplicate = false;
                    }
                    break;
                case "7":
                    if (gameBoard[2, 0] == "X" || gameBoard[2, 0] == "O")
                    {
                        duplicate = true;
                    }
                    else
                    {
                        duplicate = false;
                    }
                    break;
                case "8":
                    if (gameBoard[2, 1] == "X" || gameBoard[2, 1] == "O")
                    {
                        duplicate = true;
                    }
                    else
                    {
                        duplicate = false;
                    }
                    break;
                case "9":
                    if (gameBoard[2, 2] == "X" || gameBoard[2, 2] == "O")
                    {
                        duplicate = true;
                    }
                    else
                    {
                        duplicate = false;
                    }
                    break;
                default:
                    duplicate = false;
                    break;
            }
            Console.WriteLine(duplicate);
            return duplicate;
        }

        static void fillField(string fieldToFill, bool isPlayerOne)
        {
            switch (fieldToFill)
            {
                case "1":
                    if (isPlayerOne)
                    {
                        gameBoard[0, 0] = "X";
                    }
                    else
                    {
                        gameBoard[0, 0] = "O";
                    }
                    break;
                case "2":
                    if (isPlayerOne)
                    {
                        gameBoard[0, 1] = "X";
                    }
                    else
                    {
                        gameBoard[0, 1] = "O";
                    }
                    break;
                case "3":
                    if (isPlayerOne)
                    {
                        gameBoard[0, 2] = "X";
                    }
                    else
                    {
                        gameBoard[0, 2] = "O";
                    }
                    break;
                case "4":
                    if (isPlayerOne)
                    {
                        gameBoard[1, 0] = "X";
                    }
                    else
                    {
                        gameBoard[1, 0] = "O";
                    }
                    break;
                case "5":
                    if (isPlayerOne)
                    {
                        gameBoard[1, 1] = "X";
                    }
                    else
                    {
                        gameBoard[1, 1] = "O";
                    }
                    break;
                case "6":
                    if (isPlayerOne)
                    {
                        gameBoard[1, 2] = "X";
                    }
                    else
                    {
                        gameBoard[1, 2] = "O";
                    }
                    break;
                case "7":
                    if (isPlayerOne)
                    {
                        gameBoard[2, 0] = "X";
                    }
                    else
                    {
                        gameBoard[2, 0] = "O";
                    }
                    break;
                case "8":
                    if (isPlayerOne)
                    {
                        gameBoard[2, 1] = "X";
                    }
                    else
                    {
                        gameBoard[2, 1] = "O";
                    }
                    break;
                case "9":
                    if (isPlayerOne)
                    {
                        gameBoard[2, 2] = "X";
                    }
                    else
                    {
                        gameBoard[2, 2] = "O";
                    }
                    break;
                default:
                    break;
            }
        }

        static bool checkWinner()
        {

            bool gameOver = false;

            if (gameBoard[0, 0] == "O" && gameBoard[0, 1] == "O" && gameBoard[0, 2] == "O")
            {
                gameOver = true;
                Console.WriteLine("Player 2 is winner!");
            }  else if (gameBoard[1, 0] == "O" && gameBoard[1, 1] == "O" && gameBoard[1, 2] == "O")
            {
                gameOver = true;
                Console.WriteLine("Player 2 is winner!");
            } else if (gameBoard[2, 0] == "O" && gameBoard[2, 1] == "O" && gameBoard[2, 2] == "O")
            {
                gameOver = true;
                Console.WriteLine("Player 2 is winner!");
            } else if (gameBoard[0, 1] == "O" && gameBoard[1, 1] == "O" && gameBoard[2, 1] == "O")
            {
                gameOver = true;
                Console.WriteLine("Player 2 is winner!");
            }
            else if (gameBoard[0, 2] == "O" && gameBoard[1, 2] == "O" && gameBoard[2, 2] == "O")
            {
                gameOver = true;
                Console.WriteLine("Player 2 is winner!");
            }
            else if (gameBoard[0, 0] == "O" && gameBoard[1, 0] == "O" && gameBoard[2, 0] == "O")
            {
                gameOver = true;
                Console.WriteLine("Player 2 is winner!");
            }
            else if (gameBoard[0, 0] == "X" && gameBoard[0, 1] == "X" && gameBoard[0, 2] == "X")
            {
                gameOver = true;
                Console.WriteLine("Player 1 is winner!");
            }
            else if (gameBoard[1, 0] == "X" && gameBoard[1, 1] == "X" && gameBoard[1, 2] == "X")
            {
                gameOver = true;
                Console.WriteLine("Player 1 is winner!");
            }
            else if (gameBoard[2, 0] == "X" && gameBoard[2, 1] == "X" && gameBoard[2, 2] == "X")
            {
                gameOver = true;
                Console.WriteLine("Player 1 is winner!");
            }
            else if (gameBoard[0, 0] == "X" && gameBoard[1, 0] == "X" && gameBoard[2, 0] == "X")
            {
                gameOver = true;
                Console.WriteLine("Player 1 is winner!");
            }
            else if (gameBoard[0, 1] == "X" && gameBoard[1, 1] == "X" && gameBoard[2, 1] == "X")
            {
                gameOver = true;
                Console.WriteLine("Player 1 is winner!");
            }
            else if (gameBoard[0, 2] == "X" && gameBoard[1, 2] == "X" && gameBoard[2, 2] == "X")
            {
                gameOver = true;
                Console.WriteLine("Player 1 is winner!");
            }
            else if (gameBoard[0, 0] == "0" && gameBoard[1, 1] == "0" && gameBoard[2, 2] == "0")
            {
                gameOver = true;
                Console.WriteLine("Player 2 is winner!");
            }
            else if (gameBoard[0, 0] == "X" && gameBoard[1, 1] == "X" && gameBoard[2, 2] == "X")
            {
                gameOver = true;
                Console.WriteLine("Player 1 is winner!");
            }
            else
            {
                if (isPlayerOne)
                {
                    isPlayerOne = false;
                }
                else
                {
                    isPlayerOne = true;
                }
                askPlayer();
            }

            return gameOver;
        }

        static void askPlayer()
        {
            if (isPlayerOne)
            {
                Console.WriteLine("Player 1 : Choose your field!");
            }
            else
            {
                Console.WriteLine("Player 2 : Choose your field!");
            }
            
            string inputField = Console.ReadLine();
            if (inputField != "")
            {
                if (inputField == "8" || inputField == "9" || inputField == "7" || inputField == "6" || inputField == "1" || inputField == "2" || inputField == "3" || inputField == "4" || inputField == "5")
                {
                    bool isDuplicate = checkDuplicate(inputField);
                    if (isDuplicate)
                    {
                        Console.WriteLine("Field already used. Please choose another field.");
                        askPlayer();
                    }
                    else
                    {
                        fillField(inputField, isPlayerOne);
                        freeFields--;
                        //Console.WriteLine(freeFields);
                        Console.Clear();
                        printGameBoard();
                        if (checkWinner())
                        {
                            Console.WriteLine("reset game");
                            gameBoard = __gameBoard;
                            Console.Clear();
                            printGameBoard();
                            askPlayer();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter field between 1 and 9!");
                    askPlayer();
                }

            } 
            else
            {
                Console.WriteLine("Selection cannot be empty!");
                askPlayer();
            }
        }
    }
}
