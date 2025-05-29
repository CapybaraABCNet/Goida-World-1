using System;

public class Tutorial
{
    public static void Main()
    {

        string a = " *(°_°)/";
        string alb = "(@±@)";

        Console.WriteLine("            ###############################");
        Console.WriteLine("            #     The Goida World!!!      #");
        Console.WriteLine("            ###############################");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("            Ты попал в Goida World. Сегодня вы попали в атракцион Columbia, Напишите 'start' чтобы начать игру");



        string input = Console.ReadLine(); // Считываем ввод пользователя

        if (input.ToLower() == "start") // Проверка на ввод
        {
            Console.WriteLine("                   Игра началась!");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.Write("               ваш персонаж - ");
            Console.WriteLine(a);
            Console.WriteLine("    вы присели на лавочку, вы видите то что на вас бежит алабай, ваши действия?");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("            ###############################");
            Console.WriteLine($"            #  {a}      {alb}        #");
            Console.WriteLine("            ###############################");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("          ###################################################");
            Console.WriteLine("             напишите свой ответ цифрой                    ");
            Console.WriteLine("            1:убежать, 2:просто сидеть,                    ");
            Console.WriteLine("                 3:сопротивляться                          ");
            Console.WriteLine("          ###################################################");
            string d = Console.ReadLine();
            if (d.ToLower() == "1")
            {
                Console.WriteLine("он за вами погнался, Game over");
            }
            else if (d.ToLower() == "2")
            {
                Console.WriteLine("        это правильное решение, он гонялся не за вами");
                Console.WriteLine(" ");
                Console.WriteLine("        Вы пошли на качели, вы начали кататься, в вас начинают вдруг стрелять, увернитесь, скажите место где вы хотите увернуться");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("            ###############################");
                Console.WriteLine("            #   3                         #");
                Console.WriteLine("            #                             #");
                Console.WriteLine("            #                         8   #");
                Console.WriteLine("            #         7                   #");
                Console.WriteLine($"            #        {a}    1        #");
                Console.WriteLine("            #    6                 4      #");
                Console.WriteLine("            #      5                2     #");
                Console.WriteLine("            ###############################");
                string inp = Console.ReadLine();
                if (inp.ToLower() == "6")
                {
                    Console.WriteLine("вас ранили, вы в больнице, Game over");
                }
                else
                {
                    Console.WriteLine("        Правильно, вы спаслись от пули");
                    Console.WriteLine("     вы пошли в другле место в парке и встретили незнакомца. Он сказал то что даст деньги с помощью рандома, вы согласились");
                    Console.WriteLine("     нажмите enter если вы на компьютере чтобы узнать сколько вам выпало коинов");
                    Console.ReadLine();
                    Random c = new Random();
                    int RandomNumber = c.Next(0, 351);
                    Console.WriteLine($"    вам выпало {RandomNumber} капибара коинов, теперь вы можете что то себе на них купить [если хватит]");
                    Console.ReadLine();

                    Console.WriteLine("     Вы зашли в магазин, купиье себе что то");
                    Console.WriteLine("     есть:чипсы [90 коинов], чупа чупс [85 коинов], дубайский шоколад [170 коинов]");
                    string h = Console.ReadLine();
                    if (h.ToLower() == "чипсы")
                    {
                        if (RandomNumber > 90)
                        {
                            Console.WriteLine("вы купили чипсы");

                        }
                        else if (RandomNumber < 90)
                        {
                            Console.WriteLine("вы не смогли купить чипсы");
                        }
                        else
                        {
                            Console.WriteLine("вы купили чипсы");
                        }

                    }
                    else if (h.ToLower() == "чупа чупс")
                    {
                        if (RandomNumber > 85)
                        {
                            Console.WriteLine("вы купили чупа чупс");
                        }
                        else if (RandomNumber < 85)
                        {
                            Console.WriteLine("вы не смогли купить чупа чупс");
                        }
                        else
                        {
                            Console.WriteLine("вы купили чупа чупс");
                        }
                    }
                    else if (h.ToLower() == "дубайский шоколад")
                    {
                        if (RandomNumber > 170)
                        {
                            Console.WriteLine("вы купили дубайский шоколад");
                        }
                        else if (RandomNumber < 170)
                        {
                            Console.WriteLine("вы не смогли купить дубайский шоколад");
                        }
                        else
                        {
                            Console.WriteLine("вы купили дубайский шоколад");
                        }
                    }
                    Console.WriteLine("       Вы идёте и видите тир, решаете сыграть. Чтобы выиграть плюшевую корги, нужно правильно выстрелить. У вас есть 4 попытки.");

                    int maxAttempts = 4; // Максимальное количество попыток
                    Random random = new Random();
                    int targetNumber = random.Next(1, 8); // Случайное число от 1 до 7 (включительно)

                    for (int attempt = 1; attempt <= maxAttempts; attempt++)
                    {
                        Console.WriteLine($"     Попытка {attempt}: Угадайте число от 1 до 7:");
                        int playerGuess;

                        // Проверка корректности ввода
                        if (int.TryParse(Console.ReadLine(), out playerGuess) && playerGuess >= 1 && playerGuess <= 7)
                        {
                            if (playerGuess == targetNumber)
                            {
                                Console.WriteLine("        Правильно! Вы выиграли плюшевую корги!");
                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                                Console.WriteLine(" ");

                                Console.WriteLine("       вы идёте со своим корги домой, хоть вам тут и понравилось, но вы уже сюда не пойдете из за некоторых банд, You Win!!!");
                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                                Console.WriteLine("    CapybaraABC.NET inc., GoidaScript 2, 2025");

                                return; // Завершение программы
                               
                            }
                            else
                            {
                                Console.WriteLine("Нет, попробуйте снова.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 7.");
                            attempt--; // Не увеличиваем счетчик попыток при некорректном вводе
                        }
                    }

                    Console.WriteLine($"       Вы исчерпали все попытки. Корги был под номером {targetNumber}.");
                    Console.WriteLine("         вы теперь идете подкачаться, но чтобы зайти вам нужно решить пример, 333*562= ");
                    int m = int.Parse(Console.ReadLine());
                    if (m == 187146)
                    {
                        Console.WriteLine("    правильно, вы подкачались но видите одну банду, вы хотите от нее оборониться, но на вас нападют, бить правой или левой?");
                        string lev = Console.ReadLine();
                        if (lev == "левой")
                        {
                            Console.WriteLine("     правильно, так вы успели дать отпор, теперь вы уходите из этого парка, день выдался опасным, но весёлым, You Win!!!!!");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("    CapybaraABC.NET inc., GoidaScript 2, 2025");

                        }

                    }
                    else
                    {
                        Console.WriteLine("не правильно, Game over");
                    }


                }



            }
            // Здесь можно добавить логику игры
            else if (d.ToLower() == "3")
            {
                Console.WriteLine("Вы его разгневали, теперь он вас укусил, вы лежите в больнице. Game over");
            }
        }
        else
        {
            Console.WriteLine("Неверный ввод. Попробуйте снова.");
        }
    }
}

