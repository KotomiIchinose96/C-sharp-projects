using System;

namespace learning
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            byte value = GetMenuResponse("What would you like to play?", "Singleplayer|Local Multiplayer|Online Multiplayer|Quit");
            switch (value)
            {
                case 1:
                    Console.WriteLine("You selected Singleplayer");
                    //code for singleplayer
                    break;
                case 2:
                    Console.WriteLine("Local Multiplayer");
                    // code for local multiplayer
                    break;
                case 3:
                    switch (GetMenuResponse("What part of Online Multiplayer would you like to play?","Host Game|Connect to Game"))
                    {
                        case 1:
                            //Call Start online multiplayer code
                            break;
                        case 2:
                            //Call connect to an online game code
                            break;
                        default:
                            break;
                    }
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine(value);
                    break;

            }
        }

        public static byte GetMenuResponse(String pQuestion,String pItems)
        {
            int selection = 0;
            string[] items = pItems.Split('|');
            byte indexValue = 1;

            Console.WriteLine(pQuestion);
            foreach(string item in items)
            {
                Console.WriteLine("{0}.{1}",indexValue++, item);
            }

            bool invalidInput = true;
            //Console.WriteLine("items = {0}",items.Length);
            do
            {
                invalidInput = !int.TryParse(Console.ReadLine(),out selection);
                invalidInput |= (selection < 1 || selection > items.Length);
            } while (invalidInput);

            return (byte)selection;
        }
    }
}

