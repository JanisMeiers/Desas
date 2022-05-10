using System;

namespace TestProg
{
    class game_field
    {
        public void print_field(string[] field_array)
        {
            Console.WriteLine("");
            Console.WriteLine("{0} | {1} | {2}", field_array[0], field_array[1], field_array[2]);
            Console.WriteLine("_______________");
            Console.WriteLine("{0} | {1} | {2}", field_array[3], field_array[4], field_array[5]);
            Console.WriteLine("_______________");
            Console.WriteLine("{0} | {1} | {2}", field_array[6], field_array[7], field_array[8]);
            Console.WriteLine("");
        }

        public bool check_winner(string[] field_array, bool player_bool, string player1, string player2)
        {
            string player = "";
            if (player_bool == true)
                {
                    player = player1;
                } else 
                { 
                    player = player2;
                }

            if (field_array[0] == field_array[1] && field_array[0] == field_array[2])
                {
                    Console.WriteLine("{0} wins!!!", player);
                    return true;
                }

            if (field_array[0] == field_array[3] && field_array[0] == field_array[6])
                {
                    Console.WriteLine("{0} wins!!!", player);
                    return true;
                }

            if (field_array[0] == field_array[4] && field_array[0] == field_array[8])
                {
                    Console.WriteLine("{0} wins!!!", player);
                    return true;
                }
            if (field_array[2] == field_array[5] && field_array[2] == field_array[8])
                {
                    Console.WriteLine("{0} wins!!!", player);
                    return true;
                }

            if (field_array[2] == field_array[4] && field_array[2] == field_array[6])
                {
                    Console.WriteLine("{0} wins!!!", player);
                    return true;
                }

            if (field_array[3] == field_array[4] && field_array[3] == field_array[5])
                {
                    Console.WriteLine("{0} wins!!!", player);
                    return true;
                }

            if (field_array[6] == field_array[7] && field_array[6] == field_array[8])
                {
                    Console.WriteLine("{0} wins!!!", player);
                    return true;
                }

            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = "JM";
            string game_name = "Desas";
            string game_version = "1.0.0";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} - version {1} by {2}",game_name,game_version,name);

            Console.ResetColor();
            while (true)
            {
                Console.WriteLine("What is your name Player 1?");

                string user_input_p1 = Console.ReadLine();

                Console.WriteLine("What is your name Player 2?");

                string user_input_p2 = Console.ReadLine();

                Console.WriteLine("Hello {0} and {1}, let's play!", user_input_p1, user_input_p2);

                string[] field = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

                Console.WriteLine("Do you want to start?");

                string user_input_start = Console.ReadLine();

                bool player_turn = false;

                while (user_input_start == "y" || user_input_start == "yes" || user_input_start == "Yes" || user_input_start == "YES")
                {
                    var t = new game_field();
                    t.print_field(field);

                    if (player_turn == false)
                    {
                        Console.WriteLine("{0} turn, make a choice!", user_input_p1);
                        string player_1_choice = Console.ReadLine();
                        if (field[Int32.Parse(player_1_choice)] != "x" && field[Int32.Parse(player_1_choice)] != "y")
                        {
                            field[Int32.Parse(player_1_choice)] = "x";
                            player_turn = true;
                        }
                        else
                        {
                            Console.WriteLine("Cell is already taken, choose other!");
                        }

                    }
                    else
                    {
                        Console.WriteLine("{0} turn, make a choice!", user_input_p2);
                        string player_2_choice = Console.ReadLine();
                        if (field[Int32.Parse(player_2_choice)] != "x" && field[Int32.Parse(player_2_choice)] != "y")
                        {
                            field[Int32.Parse(player_2_choice)] = "y";
                            player_turn = false;
                        }
                        else
                        {
                            Console.WriteLine("Cell is already taken, choose other!");
                        }
                    }

                    bool game_check = t.check_winner(field, player_turn, user_input_p1, user_input_p2);

                    if (game_check == true)
                    {
                        t.print_field(field);
                        break;
                    }
                }
                Console.WriteLine("Do you want to play again?");

                string answer = Console.ReadLine();

                if (answer == "y" || answer == "yes" || answer == "Yes" || answer == "YES")
                {
                    Console.WriteLine("Let's play again!");
                } else
                {
                    Console.WriteLine("Bye!");
                    break;
                }
            }

        }
    }
}