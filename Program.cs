using System;
using System.Threading;

namespace Try1
{
    class Program
    {

        static void Main(string[] args)
        {
            
            int imp, edu, heal, mood;
            Console.SetWindowSize(130, 40);
            start();

            void start()
            {
                imp = 5;
                edu = 5; 
                heal = 5;
                mood = 5;
            

                Console.WriteLine("Вы попали в мини-рпг игру, где ваша единственная цель: выжить на территории студгородка КПИ.\n\nУ вас есть базовые характеристики, которые вы можете изменять с помощью действий.\nЕсли показатель Образованность упадет до нуля, вы вылетели из КПИ и проиграли.\nЕсли показатель Здоровье упадет до нуля, вы попали в госпиталь и проиграли.\nЕсли показатель Настроение упал до нуля, пока он равен нулю — ваше здоровье будет уменьшаться на 1 с каждым ходом.\nПоказатель Наглость поможет вам легче справляться с тягостями студенческой жизни.\nУдачи! Да прибудет с вами гранит науки.");
             
                Console.WriteLine("\n**********\nДля начала игры, нажмите s\n**********\n");
         
                for (bool i = true; i;)
                {
                    char start = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Неверная команда. Введите s для старта");

                    if (start == 's')
                        i = false;
                }
                specifications();
                Console.Read();
                Console.ReadKey();

            }

            void specifications() 
            {
                Console.Clear();
                if (mood <= 0)
                { heal--; }
                if ((heal <= 0)|(edu <= 0))
                { lose(); }
                else  if (edu >= 10)
                { win(); }
                       else { contin(); }
                
        
            }
            void win()
            { Console.WriteLine("Ничего себе! Вы победили и получили диплом. Рискнете попробовать еще раз?\n**********\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[Y/N]\n");
                Console.ResetColor();
                Console.WriteLine("**********\n");
                bool i = false;
                char contin1 = Convert.ToChar(Console.ReadLine());
                if ((contin1 == 'Y') | (contin1 == 'N'))
                  i = true;
                while (i == false)
                {
                  Console.WriteLine("Неверная команда. Попробуйте еще раз");
                    contin1 = Convert.ToChar(Console.ReadLine());
                    if ((contin1 == 'Y') | (contin1 == 'N'))
                         i = true;
                        }

                if (contin1 == 'Y')
                {
                    Console.Clear();
                    start(); }
                if (contin1 == 'N')
                { Environment.Exit(0); }
            }
            void lose()
            {
                if (edu <= 0)
                {
                    Console.WriteLine("К сожалению, лень и дедлайны победили ваше желание учиться. Вас отчислили. Хотите попробовать еще раз?\n**********\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[Y/N]\n");
                    Console.ResetColor();
                    Console.WriteLine("**********\n");
                    bool i = false;
                    char contin1 = Convert.ToChar(Console.ReadLine());
                    if ((contin1 == 'Y') | (contin1 == 'N'))
                        i = true;
                    while (i == false)
                    {
                        Console.WriteLine("Неверная команда. Попробуйте еще раз");
                        contin1 = Convert.ToChar(Console.ReadLine());
                        if ((contin1 == 'Y') | (contin1 == 'N'))
                            i = true;
                    }

                    if (contin1 == 'Y')
                    {
                        Console.Clear();
                        start(); }
                    if (contin1 == 'N')
                    { Environment.Exit(0); }
                }
                if (heal <= 0)
                {
                    Console.WriteLine("Ваше здоровье совсем подкосилось, и вы попали в госпиталь. Хотите попробовать еще раз?\n**********\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[Y/N]\n");
                    Console.ResetColor();
                    Console.WriteLine("**********\n");
                    bool i1 = false;
                    char contin2 = Convert.ToChar(Console.ReadLine());
                    if ((contin2 == 'Y') | (contin2 == 'N'))
                        i1 = true;
                    while (i1 == false)
                    {
                        Console.WriteLine("Неверная команда. Попробуйте еще раз");
                        contin2 = Convert.ToChar(Console.ReadLine());
                        if ((contin2 == 'Y') | (contin2 == 'N'))
                            i1 = true;
                    }

                    if (contin2 == 'Y')
                    {
                        Console.Clear();
                        start(); }
                    if (contin2 == 'N')
                    { Environment.Exit(0); }
                }
            }
                void contin()
               {
                Console.WriteLine("**********\nВы в игре!\n\nВаши характеристики:\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Наглость — {imp}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Образованность — {edu}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"Здоровье — {heal}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Настроение — {mood}");
                Console.ResetColor();
                Console.WriteLine("\n**********\n");
                Console.WriteLine("Возможные действия и их результаты:\n1. Сдать лабораторную\n2. Попробовать скатать лабораторную\n3. Попробовать выпросить перенос дедлайна\n4. Готовиться к лабораторной\n5. Приготовить поесть\n6. Погулять с друзьями\n7. Сходить в спортзал\n*************\nДля совершения действия введите его номер");
                actions();
            }

        
            void one()
            {
                Random rnd = new Random();
                int сhanсe1 = rnd.Next(1, 100);
                if (сhanсe1 > 45)
                {
                    oneSuccess();

                }
                else
                oneNoSuccess();
                
            }
            void oneSuccess()
            {
                edu = edu + 2;
                heal--;
                mood++;
                TextOneSuccess();
                specifications();
                
            }
            
            void oneNoSuccess()
            {
                edu = edu - 2;
                heal--;
                mood--;
                TextOneNoSuccess();
                specifications();
            }
            void two()
            {
                Random rnd = new Random();
                int сhanсe2 = rnd.Next(1, 10);
                if (сhanсe2 <= (imp-2))
                {
                    twoSuccess();
                }
                else
                {
                    twoNoSuccess();
                }
            }
            void twoSuccess()
            {
                imp++;
                edu++;
                mood++;
                TextTwoSuccess();
                specifications();
            }
            void twoNoSuccess()
            {
                imp--;
                edu--;
                mood = mood - 2;
                TextTwoNoSuccess();
                specifications();
            }
            void three()
            {
                Random rnd = new Random();
                int сhanсe3 = rnd.Next(1, 10);
                if (сhanсe3 <= (imp-2))
                {
                    threeSuccess();
                }
                else
                {
                    threeNoSuccess();
                }
            }
            void threeSuccess()
            {
                imp++;
                edu++;
                heal++;
                mood++;
                TextThreeSuccess();
                specifications();
            }
            void threeNoSuccess()
            {
                imp = imp - 2;
                heal--;
                mood--;
                TextThreeNoSuccess();
                specifications();
            }
          
            void four()
            {
                edu++;
                heal--;
                mood--;
                TextFour();
                specifications();
                
            }
            void five()
            {
                heal++;
                mood--;
                TextFive();
                specifications();
               
            }
            void six()
            {
                edu--;
                heal--;
                mood = mood + 2;
                TextSix();
                specifications();
            }
            void seven()
            {
                edu--;
                heal++;
                mood++;
                TextSeven();
                specifications();
            }

            void TextOneSuccess()
            {
                Console.Clear();
                Console.WriteLine("Произошло чудо, звезды сошлись и студент смог сдать лабораторную.\nНедоспанные ночи не прошли зря, хотя здоровье и подкосилось. \nСейчас вы увидите свои новые характеристики.");
                Thread.Sleep(1500);
            }
            void TextOneNoSuccess()

            {
                Console.Clear();
                Console.WriteLine("Меркурий был не в своем доме, а халява на пришла: вы не смогли защитить лабу.\nВам стало действительно плохо из-за этого. \nСейчас вы увидите свои новые характеристики.");
                Thread.Sleep(1500);
            }
            void TextTwoSuccess()
            {
                Console.Clear();
                Console.WriteLine("Вы смогли незаметно переписать лабораторную у старосты, никто этого не заметил.\nВы горды собой и даже узнали что-то новое. \nСейчас вы увидите свои новые характеристики.");
                Thread.Sleep(1500);
            }
            void TextTwoNoSuccess()
            {
                Console.Clear();
                Console.WriteLine("Преподаватель поймал вас на плагиате.\nВас выгнали из аудитории и не приняли работу.\nСейчас вы увидите свои новые характеристики.");
                Thread.Sleep(1500);
            }
            void TextThreeSuccess()
            {
                Console.Clear();
                Console.WriteLine("Вы настоящий дипломат - теперь у вас больше времени на подготовку.\nПоздравляю!\nСейчас вы увидите свои новые характеристики.");
                Thread.Sleep(1500);
            }
            void TextThreeNoSuccess()
            {
                Console.Clear();
                Console.WriteLine("Вас жестко осадили. \nЛабу придется сдавать вовремя, а вы теперь чувствуете себя совсем неуверенно. \nСейчас вы увидите свои новые характеристики.");
                Thread.Sleep(1500);
            }
            void TextFour()
            {
                Console.Clear();
                Console.WriteLine("Всю ночь вы сидели за конспектами и видосами индуса с ютуба.\nВы узнали много нового, но теперь вы хотите спать и убивать. \nСейчас вы увидите свои новые характеристики.");
                Thread.Sleep(1500);
            }
            void TextFive()
            {
                Console.Clear();
                Console.WriteLine("Вы порадовали ваш желудок и улучшили здоровье отменной яичницей.\nНо все же процесс готовки вам не нравится. \nСейчас вы увидите свои новые характеристики.");
                Thread.Sleep(1500);
            }
            void TextSix()
            {
                Console.Clear();
                Console.WriteLine("Вы отлично потусили вместо пар. С чего бы вас теперь тошнило бы?\nСейчас вы увидите свои новые характеристики.");
                Thread.Sleep(1500);
            }
            void TextSeven()
            {
                Console.Clear();
                Console.WriteLine("Вы потаскали железо в качалке и даже получили респект от однокурсников.\nНо при этом забыли отметиться на конференции. \nСейчас вы увидите свои новые характеристики.");
                Thread.Sleep(1500);
            }



            void actions()
            {
                bool i = false;
                int active = Convert.ToInt32(Console.ReadLine());
                if ((active > 0) & (active < 8))
                    i = true;
                while (i==false)
                { Console.WriteLine("Неверная команда. Попробуйте еще раз");
                    active = Convert.ToInt32(Console.ReadLine());
                    if ((active > 0) & (active < 8))
                        i = true;
                }
                if (active == 1)
                    { one(); }
                    if (active == 2)
                    { two(); }
                    if (active == 3)
                    { three(); }
                    if (active == 4)
                    { four(); }
                    if (active == 5)
                    { five(); }
                    if (active == 6)
                    { six(); }
                    if (active == 7)
                    { seven(); }
                   
                }
            }
        }
    }

