using System;

namespace PlayAround
{
    class Program
    {
        static void Main(string[] args)
        {

            int HandelsPengar = 3500;
            int LitenLeksak = 200;
            int MediumLeksak = 500;
            int StorLeksak = 1000;
            int PlayStation = 2000;

            while (HandelsPengar > 0)
            {
                int CaseSwitch = 1
                Console.WriteLine("Du har fortfarande pengar! Köp något!");
                Console.WriteLine("Du har " + HandelsPengar + "Kr kvar!");
                Console.WriteLine("1 Liten Leksak = 200 Kr");
                Console.WriteLine("2 Medium Leksak = 500 Kr");
                Console.WriteLine("3 Stor Leksak = 1000 Kr");
                Console.WriteLine("4 PlayStation = 2000 Kr");

                switch (CaseSwitch)
                {
                    case 1:
                        HandelsPengar - LitenLeksak
                            break;
                    case 2:
                        HandelsPengar - MediumLeksak
                            break;

                }



                
            }
           
            
            
        }
    }
}
