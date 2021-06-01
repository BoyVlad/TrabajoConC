using System;


namespace  Deberes_3._1_21
{
    class Card
    {

        public string[,] DeckOfCard = new string[9, 4];
        public int[,] ForseOfCard = new int[9, 4];
        public string[] suit = new string[4] { " Пик|  ", " Треф|  ", " Бубен|  ", " Черви|  " };
        public string[] DeckOfCard1 = new string[36];
        public int[] ForseOfCard1 = new int[36];
        public int r = 0;

        public string[] OrdenDeck1(ref string[] Arr1)
        {
            return Arr1 = DeckOfCard1;
        }
        public int[] Forse1(ref int[] F1)
        {
            return F1 = ForseOfCard1;
        }
    }

    class Actions
    {
        public void Submit(ref int Index, ref int Orden, ref int[] IndexEnGamer, ref int summGamer, ref int[] ForseGame1)
        {
            if (Orden <= 1)
            {
                IndexEnGamer[Orden] = Index;
                Orden++;
                summGamer += ForseGame1[Index];
            }
            else
            {
                IndexEnGamer[Orden] = Index;
                Orden++;
                summGamer += ForseGame1[Index];
            }
        }
        public void SubmitСomp(ref int Index, ref int Orden, ref int[] IndexEnGamer, ref int summComp, ref int[] ForseGame1)
        {

            IndexEnGamer[Orden] = Index;
            Orden++;
            summComp += ForseGame1[Index];
        }
        public bool Check(ref int Index, ref int[] IndexEnGamer)
        {
            int j = 0;
            do
            {
                if (IndexEnGamer[j].Equals(Index))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            while (j < IndexEnGamer.Length);
        }
        public bool Check21(ref int summ)
        {
            if (summ == 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool MoreCheck21(ref int summ)
        {
            if (summ > 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ACheck(ref int Index)
        {
            switch (Index)
            {
                case 0:
                    return true;
                case 9:
                    return true;
                case 18:
                    return true;
                case 27:
                    return true;
                default:
                    return false;
            }

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Card obj = new Card();

            Actions obj2 = new Actions();

            for (int j = 0; j < 4; j++) //создаем колоду для игры (массив с картами и массив с их силой)
            {
                for (int i = 0; i < 9; i++)
                {
                    switch (i)
                    {
                        case 0:
                            obj.ForseOfCard[i, j] = 11;
                            obj.DeckOfCard[i, j] = "|A" + obj.suit[j];
                            obj.DeckOfCard1[obj.r] = obj.DeckOfCard[i, j];
                            obj.ForseOfCard1[obj.r] = obj.ForseOfCard[i, j];
                            obj.r++;
                            break;
                        case 1:
                            obj.ForseOfCard[i, j] = i + 1;
                            obj.DeckOfCard[i, j] = "|J" + obj.suit[j];
                            obj.DeckOfCard1[obj.r] = obj.DeckOfCard[i, j];
                            obj.ForseOfCard1[obj.r] = obj.ForseOfCard[i, j];
                            obj.r++;
                            break;
                        case 2:
                            obj.ForseOfCard[i, j] = i + 1;
                            obj.DeckOfCard[i, j] = "|D" + obj.suit[j];
                            obj.DeckOfCard1[obj.r] = obj.DeckOfCard[i, j];
                            obj.ForseOfCard1[obj.r] = obj.ForseOfCard[i, j];
                            obj.r++;
                            break;
                        case 3:
                            obj.ForseOfCard[i, j] = i + 1;
                            obj.DeckOfCard[i, j] = "|K" + obj.suit[j];
                            obj.DeckOfCard1[obj.r] = obj.DeckOfCard[i, j];
                            obj.ForseOfCard1[obj.r] = obj.ForseOfCard[i, j];
                            obj.r++;
                            break;
                        case 4:
                            obj.ForseOfCard[i, j] = i + 2;
                            obj.DeckOfCard[i, j] = "|" + Convert.ToString(obj.ForseOfCard[i, j]) + obj.suit[j];
                            obj.DeckOfCard1[obj.r] = obj.DeckOfCard[i, j];
                            obj.ForseOfCard1[obj.r] = obj.ForseOfCard[i, j];
                            obj.r++;
                            break;
                        case 5:
                            obj.ForseOfCard[i, j] = i + 2;
                            obj.DeckOfCard[i, j] = "|" + Convert.ToString(obj.ForseOfCard[i, j]) + obj.suit[j];
                            obj.DeckOfCard1[obj.r] = obj.DeckOfCard[i, j];
                            obj.ForseOfCard1[obj.r] = obj.ForseOfCard[i, j];
                            obj.r++;
                            break;
                        case 6:
                            obj.ForseOfCard[i, j] = i + 2;
                            obj.DeckOfCard[i, j] = "|" + Convert.ToString(obj.ForseOfCard[i, j]) + obj.suit[j];
                            obj.DeckOfCard1[obj.r] = obj.DeckOfCard[i, j];
                            obj.ForseOfCard1[obj.r] = obj.ForseOfCard[i, j];
                            obj.r++;
                            break;
                        case 7:
                            obj.ForseOfCard[i, j] = i + 2;
                            obj.DeckOfCard[i, j] = "|" + Convert.ToString(obj.ForseOfCard[i, j]) + obj.suit[j];
                            obj.DeckOfCard1[obj.r] = obj.DeckOfCard[i, j];
                            obj.ForseOfCard1[obj.r] = obj.ForseOfCard[i, j];
                            obj.r++;
                            break;
                        case 8:
                            obj.ForseOfCard[i, j] = i + 2;
                            obj.DeckOfCard[i, j] = "|" + Convert.ToString(obj.ForseOfCard[i, j]) + obj.suit[j];
                            obj.DeckOfCard1[obj.r] = obj.DeckOfCard[i, j];
                            obj.ForseOfCard1[obj.r] = obj.ForseOfCard[i, j];
                            obj.r++;
                            break;
                    }
                }
            }

            int score = 100, Index;

            bool EndGame = false;

            int[] IndexEnGamer = new int[36];

            Random rand = new Random();

            try
            {


                string[] DeckGame1 = new string[36];


                obj.OrdenDeck1(ref DeckGame1);

                int[] ForseGame1 = new int[36];

                obj.Forse1(ref ForseGame1);

                Console.WriteLine("Добро пожаловать в игру 21!! Сыграем...");

                Console.WriteLine("Вам выдано 100 очков для игры. В игре не действуют правила города и пяти картинок");

                Console.ReadLine();

                do //игра
                {
                    string Entre = " ", CardGamer = " ", CardComp = " ", TrueCardComp = " ";

                    int summGamer = 0, summComp = 0, Orden = 0, rate;

                    bool EndComp = false, FinGamer = false, A11 = false, incCorrect = false, EndParte = false, WinGamer = false;

                    do//партия
                    {
                        Console.Clear();

                        for (int i = 0; i < 35; i++)
                        {
                            IndexEnGamer[i] = -1;
                        }

                        rate = 10;

                        Console.WriteLine("У вас {0} очков. Начальная ставка - 10 очков", score);//сдача

                        score -= rate;

                        Console.WriteLine("Выдаються карты...");

                        Index = rand.Next(0, 35);//первая карта игрока при сдаче

                        obj2.Submit(ref Index, ref Orden, ref IndexEnGamer, ref summGamer, ref ForseGame1);

                        if (obj2.ACheck(ref Index))
                        {
                            A11 = true;
                        }

                        CardGamer = DeckGame1[Index];

                        do //вторая карта 
                        {
                            Index = rand.Next(0, 35);
                        }
                        while (obj2.Check(ref Index, ref IndexEnGamer));//проверка на повтор

                        obj2.Submit(ref Index, ref Orden, ref IndexEnGamer, ref summGamer, ref ForseGame1);

                        if (obj2.ACheck(ref Index))
                        {
                            A11 = true;
                        }

                        CardGamer += DeckGame1[Index];

                        do //первая карта для комп
                        {
                            Index = rand.Next(0, 35);
                        }
                        while (obj2.Check(ref Index, ref IndexEnGamer));

                        obj2.SubmitСomp(ref Index, ref Orden, ref IndexEnGamer, ref summComp, ref ForseGame1);

                        Console.WriteLine();
                        Console.Write("У вашего противника на руках на руках: {0}", DeckGame1[Index]);

                        CardComp = DeckGame1[Index];

                        do //вторая карта для комп
                        {
                            Index = rand.Next(0, 35);
                        }
                        while (obj2.Check(ref Index, ref IndexEnGamer));

                        obj2.SubmitСomp(ref Index, ref Orden, ref IndexEnGamer, ref summComp, ref ForseGame1);

                        Console.Write("  ? ?  ");

                        TrueCardComp = CardComp + DeckGame1[Index];

                        CardComp += "  ? ?  ";

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("У вас на руках: {0} c cилой {1}", CardGamer, summGamer);

                        if (A11)//если был хотя бы один туз
                        {
                            do
                            {
                                Console.WriteLine();
                                Console.Write("Туз младший или старший? Введите 1 для младшего или 11 для старшего: ");

                                Entre = Console.ReadLine();

                                if (Entre == "1" || summGamer == 22)
                                {
                                    summGamer -= 10;
                                    Console.WriteLine("Туз младший");
                                    A11 = false;
                                }
                                else if (Entre == "11")
                                {
                                    Console.WriteLine("Туз старший");
                                    A11 = false;
                                }
                                else
                                {
                                    Console.WriteLine("Нужно ввести только 1 или 11");
                                }
                            }
                            while (A11);
                        }

                        do//ход игрока
                        {
                            if (obj2.Check21(ref summGamer))
                            {
                                EndParte = true;
                                WinGamer = true;
                                break;
                            }
                            if (obj2.MoreCheck21(ref summGamer))
                            {
                                EndParte = true;
                                WinGamer = false;
                                break;
                            }
                            Console.WriteLine("Взять еще карту (sub), повысить ставку(inc) или передать ход(иные команды)?");

                            Entre = Console.ReadLine();

                            if (Entre == "sub")
                            {

                                do
                                {
                                    Index = rand.Next(0, 35);
                                }
                                while (obj2.Check(ref Index, ref IndexEnGamer));

                                obj2.Submit(ref Index, ref Orden, ref IndexEnGamer, ref summGamer, ref ForseGame1);

                                Console.Write(DeckGame1[Index]);

                                if (obj2.ACheck(ref Index))
                                {
                                    if (summGamer > 10)
                                    {
                                        summGamer -= 10;
                                    }
                                    else
                                    {
                                        A11 = true;
                                        do
                                        {
                                            Console.WriteLine();
                                            Console.Write("Туз младший или старший? Введите 1 для младшего или 11 для старшего: ");

                                            Entre = Console.ReadLine();

                                            if (Entre == "1" || summGamer == 22)
                                            {
                                                summGamer -= 10;
                                                Console.WriteLine("Туз младший");
                                                A11 = false;
                                            }
                                            else if (Entre == "11")
                                            {
                                                Console.WriteLine("Туз старший");
                                                A11 = false;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Нужно ввести только 1 или 11");
                                            }
                                        }
                                        while (A11);

                                    }

                                }

                                CardGamer += DeckGame1[Index];

                                Console.Clear();

                                Console.WriteLine("У опонента на руках: {0}", CardComp);
                                Console.WriteLine();
                                Console.WriteLine("У вас на руках: {0} c cилой {1}", CardGamer, summGamer);
                            }
                            else if (Entre == "inc" && rate != 30)
                            {
                                do
                                    try
                                    {
                                        Console.WriteLine("На сколько вы хотите повысить ставку (сейчас {0}) (ставка не может быть больше 30): ", rate);

                                        Entre = Console.ReadLine();

                                        int rate1 = Convert.ToInt32(Entre);

                                        if (rate1 + rate <= 30 && rate1 > 0 && rate <= 20)
                                        {
                                            rate += Convert.ToInt32(rate1);

                                            score -= Convert.ToInt32(rate1);

                                            incCorrect = true;

                                            Console.WriteLine("Нынешняя ставка - {0}", rate);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ставка не подходит");
                                        }

                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Ставка должна быть целым числом от 1 до 20");
                                    }
                                while (!incCorrect);
                            }
                            else
                            {
                                FinGamer = true;
                            }
                        }
                        while (!FinGamer);

                        CardComp = TrueCardComp;

                        Console.WriteLine("Вы окончили свой ход");

                        Console.ReadLine();

                        Console.Clear();

                        Console.WriteLine("У опонента на руках: {0} c cилой {1}", CardComp, summComp);

                        Console.WriteLine();

                        Console.WriteLine("У вас на руках: {0} c cилой {1}", CardGamer, summGamer);

                        Console.ReadLine();

                        if (summComp == 22)
                        {
                            summComp = 12;
                        }

                        if (!EndParte)
                            do
                            {
                                if (obj2.MoreCheck21(ref summComp))
                                {
                                    EndParte = true;
                                    WinGamer = true;
                                    break;
                                }

                                if (summComp > summGamer)
                                {
                                    EndComp = true;
                                    EndParte = true;
                                    WinGamer = false;
                                    break;
                                }
                                else if (summComp < 17)
                                {
                                    do
                                    {
                                        Index = rand.Next(0, 35);
                                    }
                                    while (obj2.Check(ref Index, ref IndexEnGamer));

                                    obj2.SubmitСomp(ref Index, ref Orden, ref IndexEnGamer, ref summComp, ref ForseGame1);

                                    Console.Clear();

                                    Console.WriteLine("Противник берет карту");

                                    CardComp += DeckGame1[Index];

                                    Console.WriteLine("У опонента на руках: {0} c cилой {1}", CardComp, summComp);

                                    Console.WriteLine();

                                    Console.WriteLine("У вас на руках: {0} c cилой {1}", CardGamer, summGamer);

                                    if (obj2.ACheck(ref Index) && summComp > 10)
                                    {
                                        summComp -= 10;
                                    }
                                    if (obj2.MoreCheck21(ref summComp))
                                    {
                                        EndComp = true;
                                        WinGamer = true;
                                        EndParte = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    EndParte = true;
                                    EndComp = true;
                                    if (!(summGamer == summComp))
                                    {
                                        WinGamer = true;
                                    }
                                }
                                Console.ReadLine();
                            }
                            while (!EndComp);

                        Console.WriteLine("Опонент закончил свой ход");
                        Console.ReadLine();
                    }
                    while (!EndParte);

                    Console.Clear();
                    Console.WriteLine("К концу игры у вас на руках карты");
                    Console.WriteLine();
                    Console.WriteLine("У опонента на руках: {0} c cилой {1}", CardComp, summComp);
                    Console.WriteLine();
                    Console.WriteLine("У вас на руках: {0} c cилой {1}", CardGamer, summGamer);
                    Console.WriteLine();

                    if (WinGamer)
                    {
                        score += rate * 2;
                        Console.WriteLine("Вы победили и выиграли ставку в размере {0}. У вас {1}", rate, score);
                        Console.WriteLine("Вы набрали {0}, противник - {1}", summGamer, summComp);
                    }
                    else if (summComp == summGamer)
                    {
                        score += rate;
                        Console.WriteLine("Ничья. Вы набрали и противник набрали по {0}", summGamer, summComp);
                    }
                    else
                    {
                        Console.WriteLine("Вы проиграли эту партию. Вы набрали {0}, противник - {1}", summGamer, summComp);
                    }
                    if (score <= 0)
                    {
                        Console.WriteLine("Игра окончена");
                        EndGame = true;
                        break;
                    }
                    Console.WriteLine("Если вы хотите закончить игру, закройте приложение нажав на крестик в правом верхнем углу или введите (End)");
                    string Enter1 = Console.ReadLine();
                    if (Enter1 == "End")
                    {
                        EndGame = true;
                    }
                }
                while (!EndGame);
            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
            }
        }
    }
}




