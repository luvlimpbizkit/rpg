using System;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int h;

          h = (int)inputValue();


            //Display a welcome screen
            WelcomeScreen();
            //Continue game
            string colouredDoora;
            string choice2;
            string choice = "";
            string myName;
            string pathDirection;
            string colouredDoor;
            string crucifixPickup = "no";

            Console.WriteLine("what is your name");
            //Console.ReadLine();
            myName = Console.ReadLine();
            Console.WriteLine("welcome " + myName);



            Console.WriteLine("you see 2 paths type left or right");
            //Console.ReadLine();
            pathDirection = Console.ReadLine();
            Console.WriteLine("you go " + pathDirection);
            if (pathDirection.Equals("left"))
            {
                Console.WriteLine("on the left you see someone");
            }
            else
            {
                Console.WriteLine("on the right you see a house");
            }

            Console.WriteLine("you see a shadow that leads you to 3 doors");
            Console.WriteLine("theres a red door, a blue door and a green door");
            //Console.ReadLine();
            colouredDoor = Console.ReadLine();
            if (colouredDoor.Equals("red"))
            {
                Console.WriteLine("you go into the red door and see a crucifix");
                Console.WriteLine("pick it up?");
                //Console.ReadLine();
                crucifixPickup = Console.ReadLine();
                if (crucifixPickup.Equals("yes"))
                {
                    Console.WriteLine("added to backpack");


                }
                else if (crucifixPickup.Equals("no"))
                {
                    Console.WriteLine("not picked up");

                }
                Console.WriteLine("pick another door, blue or green");
                //Console.ReadLine();
                colouredDoora = Console.ReadLine();
                if (colouredDoora.Equals("blue"))
                {
                    Console.WriteLine("you go into the blue door and see a person");
                    Console.WriteLine("stranger: hello officer what can i do for you today");
                    Console.WriteLine("option1: can i see your id. option2: analyse looks. option3: use different items picked up or option4: leave");

                    //Console.ReadLine();
                    bool isValidChoice = false;

                    while (isValidChoice == false)
                    {


                        choice2 = Console.ReadLine();



                        if (choice2.Equals("1"))
                        {
                            Console.WriteLine("it is a normal id");
                        }
                        else if (choice2.Equals("2"))
                        {
                            Console.WriteLine("he looks normal");
                        }
                        else if (choice2.Equals("3"))
                        {
                            Console.WriteLine("checking if you have any equipment");
                            if (crucifixPickup.Equals("yes"))
                            {
                                Console.WriteLine("you use a crucifix and it does not effect him");
                            }
                            else if (crucifixPickup.Equals("no"))
                            {
                                Console.WriteLine("you do not have any equipment to use on him");
                            }
                        }
                        else if (choice2.Equals("4"))
                        {
                            Console.WriteLine("you left");
                            isValidChoice = true;

                        }
                        else
                        {
                            Console.WriteLine("not a valid number");
                        }
                    }


                    }
                else if (colouredDoor.Equals("blue"))
                    {
                        Console.WriteLine("you go into the blue door and see a person");
                        Console.WriteLine("stranger: hello officer what can i do for you today");
                        Console.WriteLine("option1: can i see your id. option2: analyse looks. option3: use different items picked up or option4: leave");

                        //Console.ReadLine();
                        bool isValidChoice = false;

                        while (isValidChoice == false)
                        {


                            choice = Console.ReadLine();



                            if (choice.Equals("1"))
                            {
                                Console.WriteLine("it is a normal id");
                            }
                            else if (choice.Equals("2"))
                            {
                                Console.WriteLine("he looks normal");
                            }
                            else if (choice.Equals("3"))
                            {
                                Console.WriteLine("checking if you have any equipment");
                                if (crucifixPickup.Equals("yes"))
                                {
                                    Console.WriteLine("you use a crucifix and it does not effect him");
                                }
                                else if (crucifixPickup.Equals("no"))
                                {
                                    Console.WriteLine("you do not have any equipment to use on him");
                                }
                            }
                            else if (choice.Equals("4"))
                            {
                                Console.WriteLine("you left");
                                isValidChoice = true;

                            }


                            else
                            {
                                Console.WriteLine("not a valid number");
                            }
                        }



                }

                else if (colouredDoor.Equals("green"))
                    {
                        Console.WriteLine("you go into the green door and see nothing, try somewhere else");
                    }

                else
                    {
                        Console.WriteLine("no such door colour");
                    }
             

            }
        }

        // .NET can only read single characters or entire lines from the
        // console. The following function safely reads a double value.
        private static double inputValue()
        {
            double result;
            while (!double.TryParse(Console.ReadLine(), out result)) ;
            return result;
        }



        public static int AddNumbers(int n1, int n2)
        {
            int result = n1 + n2;
            if (result <= 10)
            {
                result = 0;
            }
            return result;
        }

        public static void h(int j)
        {
            Console.WriteLine("hi" + j);
            Console.WriteLine("e");
            Console.WriteLine("w");
        }

        public static void WelcomeScreen()
        {
            // Output your image
            // clear the screen 
            Console.Clear();
            Console.WriteLine("Welcome");
            Console.WriteLine(@"~         ~~          __
       _T      .,,.    ~--~ ^^
 ^^   // \                    ~
      ][O]    ^^      ,-~ ~
   /''-I_I         _II____
__/_  /   \ ______/ ''   /'\_,__
  | II--'''' \,--:--..,_/,.-{ },
; '/__\,.--';|   |[] .-.| O{ _ }
:' |  | []  -|   ''--:.;[,.'\,/
'  |[]|,.--'' '',   ''-,.    |
  ..    ..-''    ;       ''. '");
        }

    }




}
   
