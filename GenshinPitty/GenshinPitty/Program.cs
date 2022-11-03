
/*
class genshin
{
    
    public void Main(string[] args)
    {
       

            Console.WriteLine("strting Genshin pitty counter v1.2")
            Console.WriteLine("how many pulls?");
            string get = Console.ReadLine();
            int puls = Int32.Parse(get);

            int total = +puls;
            Console.WriteLine("thats " + total + " pulls");

        
    }
    public string test()
    {
 
        
        Console.WriteLine("how many pulls?");
        string get = Console.ReadLine();
        int puls = Int32.Parse(get);
       
        int total =+ puls;
        Console.WriteLine("thats " + total + " pulls");
        

        if (total == 9)
        {
            return "Next pull: 4-star or higher";
        }
        else if (total == 19)
        {
            return "Next pull: 4-star or higher";
        }
        else if (total == 29)
        {
            return "Next pull: 4-star or higher";
        }
        else if (total == 39)
        {
            return "Next pull: 4-star or higher";
        }
        else if (total == 49)
        {
            return "Next pull: 4-star or higher";
        }
        else if (total == 59)
        {
            return "Next pull: 4-star or higher";
        }
        else if (total == 69)
        {
            return "Next pull: 4-star or higher. Start single pulls";
        }
        else if (total == 75)
        {
            return "Getting close to 5-star";
        }
        else if (total == 79)
        {
            return "Next pull: 4-star or higher, closer";
        }
        else if (total == 89)
        {
            return "Next pull: 5-star";
        }
        else { return ""; }
        
       

        
        
       
    }
   

}
*/
/*
    public string Going(bool GoOn)
    {
        GoOn = false;
        Console.WriteLine("Please Write in All Lowecase");
        Console.WriteLine("Stat Program: 'Genshin Pitty Counter v2.8'?");
        string YesNo = Console.ReadLine();

        if (YesNo == "yes")
        {
            GoOn = true;
            return "Starting Program 'Genshing Pitty Counter'";
        }
        else
        {
            GoOn = false;
            return "Please Close Program";
        }
    }

    public void Test()
    {
        
            Console.WriteLine("test");
        
         
    }
       

}
    */
public class Genshin
{
    static void Main()
    {
        bool GoOn = false;
        bool Otherbaner = false;
        bool WepBaner = false;
        bool adddding = false;
        int NumOfPuls = 0;
        float six = .6f;
        int addign = 0;
        Random rng = new Random();
        int why = rng.Next(5,51);

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Please write in all lowecase  \n");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Stat program: 'Genshin Pitty Counter v3.5'? Yes or no");
        Console.ForegroundColor = ConsoleColor.White;
        string YesNo = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        if (YesNo == "yes" || YesNo == "q")
        {
            GoOn = true;
            Console.WriteLine("\n  .*'Starting program 'Genshing Pitty Counter''*.");

        }
        else if (YesNo == "no")
        {
           Console.Clear();


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Then why did you open this project? Please tell me");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine ();
            for (int i = 0; i < why; i++)
            {
               Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\n why");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
            }
            Console.Clear ();
            Console.ForegroundColor= ConsoleColor.Magenta;
            Console.WriteLine("\n     Okay! Love you! Bye-bye!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error. Please type in lowercase 'yes' or 'no'. Please close program");
        }

        while (GoOn == true)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("What banner are you on? Event or weapon?");
            Console.ForegroundColor = ConsoleColor.White;
            string banner = Console.ReadLine();


            if (banner == "event" || banner == "q")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Genshin Pitty Counter v3.5");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\nYou are now adding event banner pulls");

                Otherbaner = true;

                while (Otherbaner == true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nHow many times have you pulled so far? No more than 90");
                    Console.ForegroundColor = ConsoleColor.White;
                    string startingPuls = Console.ReadLine();
                    adddding = true;

                    try
                    {
                        NumOfPuls = Int32.Parse(startingPuls);
                    }

                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error. Please use a number. Please restart program");
                        GoOn = false; Otherbaner = false; adddding = false;
                    }

                    if (NumOfPuls < 91)
                    {
                        while (adddding == true)
                        {

                            Console.ForegroundColor = ConsoleColor.Cyan;

                            switch (NumOfPuls)
                            {
                                case 0:
                                    Console.WriteLine("You have a 0.6% to get a 5-star next pull");
                                    break;
                                case 1:
                                    six = six * 2;
                                    Console.WriteLine("You have a " + six + "% to get a 5-star next pull");
                                    break;
                                case 2:
                                    six = six * 3;
                                    Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 3: six = six * 4; Console.WriteLine("You have a " + six + "%  to get a 5-star next pull"); break;
                                case 4: six = six * 5; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 5: six = six * 6; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 6: six = six * 7; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 7: six = six * 8; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 8: six = six * 9; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 9: six = six * 10; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 10: six = six * 11; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 11: six = six * 12; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 12: six = six * 13; Console.WriteLine("You have a " + six + "%  to get a 5-star next pull"); break;
                                case 13: six = six * 14; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 14: six = six * 15; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 15: six = six * 16; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 16: six = six * 17; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 17: six = six * 18; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 18: six = six * 19; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 19: six = six * 20; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 20: six = six * 21; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 21: six = six * 22; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 22: six = six * 23; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 23: six = six * 24; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 24: six = six * 25; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 25: six = six * 26; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 26: six = six * 27; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 27: six = six * 28; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 28: six = six * 29; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 29: six = six * 30; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 30: six = six * 31; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 31: six = six * 32; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 32: six = six * 33; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 33: six = six * 34; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 34: six = six * 35; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 35: six = six * 36; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 36: six = six * 37; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 37: six = six * 38; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 38: six = six * 39; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 39: six = six * 40; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 40: six = six * 41; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 41: six = six * 42; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 42: six = six * 43; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 43: six = six * 44; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 44: six = six * 45; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 45: six = six * 46; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 46: six = six * 47; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 47: six = six * 48; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 48: six = six * 49; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 49: six = six * 50; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 50: six = six * 51; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 51: six = six * 52; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 52: six = six * 53; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 53: six = six * 54; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 54: six = six * 55; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 55: six = six * 56; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 56: six = six * 57; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 57: six = six * 58; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 58: six = six * 59; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 59: six = six * 60; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 60: six = six * 61; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 61: six = six * 62; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 62: six = six * 63; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 63: six = six * 64; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 64: six = six * 65; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 65: six = six * 66; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 66: six = six * 67; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 67: six = six * 68; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 68: six = six * 69; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 69: six = six * 70; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 70: six = six * 71; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 71: six = six * 72; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 72: six = six * 73; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 73: six = six * 74; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 74: six = six * 75; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 75: six = six * 76; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 76: six = six * 77; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 77: six = six * 78; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 78: six = six * 79; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 79: six = six * 80; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 80: six = six * 81; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 81: six = six * 82; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 82: six = six * 83; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 83: six = six * 84; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 84: six = six * 85; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 85: six = six * 86; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 86: six = six * 87; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 87: six = six * 88; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 88: six = six * 89; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 89: Console.WriteLine("You have a 100% to get a 5-star next pull"); break;
                                case 90: Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("You will get a 5-star"); break;
                                default:
                                  Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Number over 90"); Console.ForegroundColor = ConsoleColor.DarkCyan;
                                   Console.WriteLine("\n  .*'Restarting'*.  \n"); NumOfPuls = 0; break;


                            }
                          Console.WriteLine("You've pulled " + NumOfPuls + " times so far");

                            six = .6f;
                            if (NumOfPuls == 90)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\n\nPress 'Enter' to continue");
                                Console.ReadLine();
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Genshin Pitty Counter v3.5");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\n  .*'Restarting'*.  \n");
                                GoOn = false;
                                adddding = false;
                            }

                            Console.ForegroundColor = ConsoleColor.Blue;

                            Console.WriteLine("\nAdd how many? Type 'restart' to reset banner.");
                            Console.ForegroundColor = ConsoleColor.White;
                            string add = Console.ReadLine();

                            if (add == "restart" || add == "q")
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Genshin Pitty Counter v3.5");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\n  .*'Restarting'*.  \n");
                                GoOn = false;
                                adddding = false;
                            }
                            else
                            {
                                try
                                {
                                    addign = Int32.Parse(add);NumOfPuls += addign;
                                }
                                catch
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nError.  \n");
                                }
                                

                            }
                        }


                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n Error, number too high");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\n  .*'Restarting'*.  \n");
                    }


                    /* Console.WriteLine("Continue program?");
                     string Going = Console.ReadLine();

                         if (Going == "yes" || Going == "q")
                         {
                             Console.WriteLine("Continue with current stats?");
                             string stats = Console.ReadLine();

                             addign = NumOfPuls + addign;

                             if (stats == "yes" || stats == "q") { Otherbaner = true; NumOfPuls = 0; } // NumOfPuls += NumOfPuls; }
                             else if (stats == "no") { Otherbaner = true; six = 0.6f; NumOfPuls = 0; }
                         }

                         else { Otherbaner = false; Console.WriteLine("Restarting Program"); NumOfPuls = 0; }
                         */

                    //  if (Going == "yes" || Going == "q") Otherbaner = true;
                    // else Otherbaner = false;

                }


            }


            else if (banner == "weapon" || banner == "wepon" || banner == "w")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Genshin Pitty Counter v3.5");
                Console.WriteLine("\n\nYou are now adding Weapon banner pulls");

                WepBaner = true;

                while (WepBaner == true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nHow many times have you pulled so far? No more than 80");
                    Console.ForegroundColor = ConsoleColor.White;
                    string startingPuls = Console.ReadLine();
                    adddding = true;

                    try
                    {
                        NumOfPuls = Int32.Parse(startingPuls);
                    }

                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error. Please use a number. Please restart program");
                        GoOn = false; WepBaner = false; adddding = false;
                    }

                    if (NumOfPuls < 100)
                    {
                        while (adddding == true)
                        {
                            six = .7f;
                            Console.ForegroundColor = ConsoleColor.Cyan;

                            switch (NumOfPuls)
                            {
                                case 0:
                                    Console.WriteLine("You have a 0.7% to get a 5-star next pull");
                                    break;
                                case 1:
                                    six = six * 2;
                                    Console.WriteLine("You have a " + six + "% to get a 5-star next pull");
                                    break;
                                case 2:
                                    six = six * 3;
                                    Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 3: six = six * 4; Console.WriteLine("You have a " + six + "%  to get a 5-star next pull"); break;
                                case 4: six = six * 5; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 5: six = six * 6; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 6: six = six * 7; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 7: six = six * 8; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 8: six = six * 9; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 9: six = six * 10; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 10: six = six * 11; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 11: six = six * 12; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 12: six = six * 13; Console.WriteLine("You have a " + six + "%  to get a 5-star next pull"); break;
                                case 13: six = six * 14; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 14: six = six * 15; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 15: six = six * 16; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 16: six = six * 17; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 17: six = six * 18; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 18: six = six * 19; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 19: six = six * 20; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 20: six = six * 21; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 21: six = six * 22; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 22: six = six * 23; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 23: six = six * 24; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 24: six = six * 25; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 25: six = six * 26; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 26: six = six * 27; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 27: six = six * 28; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 28: six = six * 29; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 29: six = six * 30; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 30: six = six * 31; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 31: six = six * 32; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 32: six = six * 33; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 33: six = six * 34; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 34: six = six * 35; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 35: six = six * 36; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 36: six = six * 37; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 37: six = six * 38; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 38: six = six * 39; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 39: six = six * 40; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 40: six = six * 41; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 41: six = six * 42; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 42: six = six * 43; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 43: six = six * 44; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 44: six = six * 45; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 45: six = six * 46; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 46: six = six * 47; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 47: six = six * 48; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 48: six = six * 49; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 49: six = six * 50; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 50: six = six * 51; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 51: six = six * 52; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 52: six = six * 53; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 53: six = six * 54; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 54: six = six * 55; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 55: six = six * 56; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 56: six = six * 57; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 57: six = six * 58; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 58: six = six * 59; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 59: six = six * 60; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 60: six = six * 61; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 61: six = six * 62; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 62: six = six * 63; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 63: six = six * 64; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 64: six = six * 65; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 65: six = six * 66; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 66: six = six * 67; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 67: six = six * 68; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 68: six = six * 69; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 69: six = six * 70; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 70: six = six * 71; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 71: six = six * 72; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 72: six = six * 73; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 73: six = six * 74; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 74: six = six * 75; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 75: six = six * 76; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 76: six = six * 77; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 77: six = six * 78; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 78: six = six * 79; Console.WriteLine("You have a " + six + "% to get a 5-star next pull"); break;
                                case 79: six = six * 70; Console.WriteLine("You have a 100% to get a 5-star next pull"); break;
                                case 80: six = six * 80; Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("You will get a 5-star"); break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Number over 80"); Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.WriteLine("\n  .*'Restarting'*.  \n"); NumOfPuls = 0; break;


                            }
                          Console.WriteLine("You've pulled " + NumOfPuls + " times so far");

                            six = .7f;

                            Console.ForegroundColor = ConsoleColor.Blue;

                            Console.WriteLine("\nAdd how many? Type 'restart' to reset banner.");
                            Console.ForegroundColor = ConsoleColor.White;
                            string add = Console.ReadLine();

                            if (add == "restart" || add == "q")
                            {
                               Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Genshin Pitty Counter v3.5");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\n  .*'Restarting'*.  \n");
                                GoOn = false;
                                adddding = false;
                            }
                            else
                            {
                                try
                                {
                                    addign = Int32.Parse(add); NumOfPuls += addign;
                                }
                                catch
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nError.  \n");
                                }
                               

                            }
                        }


                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n Error, number too high");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\n  .*'Restarting'*.  \n");
                    }
                }
            }

            else { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Error. Please try again"); }
        }
    }
}
    