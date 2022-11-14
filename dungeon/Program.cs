using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            GameTitle();
        }

        public static void GameTitle()
        {
            Console.WriteLine("Unknown Dungeon");
            Console.WriteLine("press enter to begin.");
            Console.ReadLine();
            Console.Clear();
            first();

        }

        public static void first()
        {
            string choice;

            Console.WriteLine("You woke up in a dark room.");
            Console.WriteLine("You can barely see but you can make out two doors on the left and right side of the room.");
            Console.WriteLine("What do you do?");
            Console.WriteLine("1. Go to the left side door");
            Console.WriteLine("2. Go to the right side door");
            Console.WriteLine("3. Do Nothing");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "left":
                case "left door":
                    {
                        Console.WriteLine("You open the door");
                        Console.WriteLine("You found a chest in the middle of the room.");
                        Console.WriteLine("There is a old rusty metal sword in the chest.");
                        Console.WriteLine("You picked up the sword.");
                        Console.WriteLine("You searched around the room but found nothing.");
                        Console.WriteLine("You exit the room.");
                        Console.ReadLine();
                        second();
                        break;

                    }
                case "2":
                case "right":
                case "right door":
                    {
                        Console.WriteLine("When you opened the door");
                        Console.WriteLine("A giant reptile lunges at you face!");
                        Console.WriteLine("With nothing to protect you the lizard mauled you face.");
                        Console.WriteLine("You died a painful death");
                        Console.ReadLine();
                        GameOver();
                        break;
                    }
                case "3":
                case "Nothing":
                case "Do Nothing":
                    {
                        Console.WriteLine("What? You can't do that.");
                        Console.WriteLine("Come on get your lazy butt up and do something");
                        Console.ReadLine();
                        first();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("I think you mistyped..");
                        Console.WriteLine("Press Enter to try again.");
                        Console.ReadLine();
                        first();
                        break;
                    }

            }



        }

        public static void second()
        {
            string choice;


            Console.WriteLine("As you exited the room you went straight to the other room. ");
            Console.WriteLine("As you entered the room a Reptile lunged at you but luckily you a sword");
            Console.WriteLine("One slash was enough to take down the reptile but the sword broke from that hit");
            Console.WriteLine("As you took care of the Reptile with your now broken sword you scan the area you see 3 hallways");
            Console.WriteLine("Which one do you choose");
            Console.WriteLine("Left hallway");
            Console.WriteLine("Middle hallway");
            Console.WriteLine("Right hallway");
            Console.WriteLine("Do Nothing");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();


            switch (choice)
            {
                case "1":
                case "left":
                case "left hallway":
                    {
                        Console.WriteLine("As you walked in the dark hallway.");
                        Console.WriteLine("You hear a click on the ground when you stepped your foot on the ground.");
                        Console.WriteLine("Without any time to react a arrow went straight to your head.");
                        Console.WriteLine("Your death was quick and painless");
                        Console.ReadLine();
                        GameOver2();
                        break;

                    }
                case "2":
                case "middle":
                case "middle hallway":
                    {
                        Console.WriteLine("As you walked in the dim hallway.");
                        Console.WriteLine("You feel your foot tugging on waht feels like a string.");
                        Console.WriteLine("Before reacting a explosion from a hidden bomb went off");
                        Console.WriteLine("Instantly killing you");
                        Console.ReadLine();
                        GameOver3();
                        break;
                    }
                case "3":
                case "right":
                case "right hallway":
                    {
                        Console.WriteLine("As you walked in the partially hallway.");
                        Console.WriteLine("You find a swith at the end");
                        Console.WriteLine("As you pull the lever you hear a bunch of gear noises");
                        Console.WriteLine("You exited the hallway when the gear noises stopped");
                        Console.ReadLine();
                        third();
                        break;
                    }
                case "4":
                case "Nothing":
                case "Do Nothing":
                    {
                        Console.WriteLine(".......");
                        Console.WriteLine("You're gonna keep doing this aren't you.");
                        Console.ReadLine();
                        second();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("I think you mistyped...");
                        Console.WriteLine("Press Enter to try again.");
                        Console.ReadLine();
                        second();
                        break;
                    }
            }
        }

        public static void third()
        {

            string choice;

            Console.WriteLine("As you exited the hallway you didn't see any changes in the hallways.");
            Console.WriteLine("You can't tell through the dark hallways.");
            Console.WriteLine("So you are left with two hallways to choose.");
            Console.WriteLine("1. Left hallway");
            Console.WriteLine("2. Middle hallway");
            Console.WriteLine("3. Do nothing");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "left":
                case "left hallway":
                    {
                        Console.WriteLine("As you walked down the dark hallway you hear a click on the ground.");
                        Console.WriteLine("But nothing happened.");
                        Console.WriteLine("So you proceeded through");
                        Console.WriteLine("Then you see a door in the distance");
                        Console.ReadLine();
                        fourth();
                        break;

                    }

                case "2":
                case "middle":
                case "middle hallway":
                    {
                        Console.WriteLine("You walked down the dim hallway");
                        Console.WriteLine("When walking through you tripped on a string on the ground");
                        Console.WriteLine("But nothing happened");
                        Console.WriteLine("When proceeding through it started to get darker");
                        Console.WriteLine("Then the ground started to shift");
                        Console.WriteLine("The ground opened up taking you down to a pitfall");
                        Console.WriteLine("You died shortly after you hit the ground");
                        Console.ReadLine();
                        GameOver4();
                        break;

                    }

                case "3":
                case "nothing":
                case "do nothing":
                    {
                        Console.WriteLine("You do this one more time.");
                        Console.WriteLine("You will die");
                        Console.WriteLine("I'm serious.");
                        Console.WriteLine("DON'T DO IT AGAIN!");
                        Console.ReadLine();
                        third();
                        break;

                    }

                default:
                    {
                        Console.WriteLine("Sorry I cannot compute...");
                        Console.WriteLine("Press Enter to try again.");
                        Console.ReadLine();
                        third();
                        break;
                    }
            }

        }

        public static void fourth()
        {
            string choice;

            Console.WriteLine("When you came across the door it had something on it.");
            Console.WriteLine("And on the it says...");
            Console.WriteLine("What was the EXACT saying of the weapon you found in the chest.");
            Console.WriteLine("You Hear a clock start ticking");
            Console.WriteLine("Choose ");
            Console.WriteLine(".......");
            Console.WriteLine("........");
            Console.WriteLine(".........");
            Console.WriteLine("...........");
            Console.WriteLine("............");
            Console.WriteLine(".............");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "metal rusty old sword":
                    {
                        Console.WriteLine("as you said the words.");
                        Console.WriteLine("you hear something coming from above.");
                        Console.WriteLine(".............");
                        Console.ReadLine();
                        GameOver5();
                        break;

                    }

                case "rusty old metal sword ":
                    {
                        Console.WriteLine("as you said the words.");
                        Console.WriteLine("You hear something on you left.");
                        Console.WriteLine("..........");
                        Console.ReadLine();
                        GameOver6();
                        break;

                    }

                case "old rusty metal sword":
                    {
                        Console.WriteLine("as you said the words");
                        Console.WriteLine("everything went quiet");
                        Console.WriteLine("then the door opened up");
                        Console.WriteLine("A Shine of light comes through the crack of the door");
                        Console.ReadLine();
                        youwin();
                        break;

                    }

                case "Nothing":
                case "Do Nothing":
                    {
                        Console.WriteLine("........");
                        Console.WriteLine("....");
                        Console.WriteLine("..");
                        Console.WriteLine("I warned you..............................");
                        Console.ReadLine();
                        youwin();
                        break;

                    }

                default:
                    {
                        Console.WriteLine("WRONG");
                        Console.ReadLine();
                        GameOver7();
                        break;
                    }
            }
        }

        public static void GameOver()
        {
            Console.Clear();
            Console.WriteLine("Pieces of your body were found by a search party.");
            Console.WriteLine("But the rest was never found.");
            Console.WriteLine("Death 1:unprepared");
            Console.ReadLine();
            Console.Clear();
            first();
        }

        public static void GameOver2()
        {
            Console.Clear();
            Console.WriteLine("Your Body was discovered in the hallway");
            Console.WriteLine("With a arrow straight through you skull ");
            Console.WriteLine("Death 2:ArrowHead");
            Console.ReadLine();
            Console.Clear();
            second();
        }

        public static void GameOver3()
        {
            Console.Clear();
            Console.WriteLine("Only small pieces of you body was found.");
            Console.WriteLine("but the rest was never found only all that was left was a hole in the ground.");
            Console.WriteLine("Death 3:Death to bomb");
            Console.ReadLine();
            Console.Clear();
            second();
        }

        public static void GameOver4()
        {
            Console.Clear();
            Console.WriteLine("No One found your body");
            Console.WriteLine("all they found was a dark pit");
            Console.WriteLine("Death 4:Fallen");
            Console.ReadLine();
            Console.Clear();
            third();
        }

        public static void GameOver5()
        {
            Console.Clear();
            Console.WriteLine("your body was never found");
            Console.WriteLine("all there was a giant metal block");
            Console.WriteLine("Death 5:Death to Metal");
            Console.ReadLine();
            Console.Clear();
            first();
        }

        public static void GameOver6()
        {
            Console.Clear();
            Console.WriteLine("your body was discovered pierced to the wall");
            Console.WriteLine("what pierced you were rusty metal spears.");
            Console.WriteLine("Death 6:stabbed by rust");
            Console.ReadLine();
            Console.Clear();
            first();
        }

        public static void GameOver7()
        {
            Console.Clear();
            Console.WriteLine("you will never be found, You will never be found, YOU WILL NEVER BE FOUND");
            Console.WriteLine("YOU WILL NEVER BE FOUND YOU WILL NEVER BE FOUND YOU WILL NEVER BE FOUND YOU WILL NEVER BE FOUND YOU WILL NEVER BE FOUND YOU WILL NEVER BE FOUND YOU WILL NEVER BE FOUND YOU WILL NEVER BE FOUND YOU WILL NEVER BE FOUND YOU WILL NEVER BE FOUND YOU WILL NEVER BE FOUND YOU WILL NEVER BE FOUND YOU WILL NEVER BE FOUND YOU WILL NEVER BE FOUND YOU WILL NEVER BE FOUND YOU WILL NEVER BE FOUND YOU WILL NEVER BE FOUND");
            Console.WriteLine("Death 7:I WARNED YOU!");
            Console.ReadLine();
            Console.Clear();
            first();
        }

        public static void youwin()
        {
            Console.Clear();
            Console.WriteLine("As you walked out the door you let your eyes adjust to the light.");
            Console.WriteLine("when your eyes adjusted to the sunlight you were greeted to a forest.");
            Console.WriteLine("there was nothing around the forest area no village, no civilzation only a dirt trail");
            Console.WriteLine("You walked down the trail and started to wonder why you were in that dungeon.");
            Console.WriteLine("You don't know who,what, or how you got there.");
            Console.WriteLine("But all you know is that you are out of that dungeon and now the only thing to do is to find a village.");
            Console.WriteLine("Thank you for playing my Game.");
            Console.WriteLine("Press Enter to return to Game Title");
            Console.ReadLine();
            Console.Clear();
            GameTitle();
        }





    }
}
