using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Tutorial1
{
    class Program
    {
        //initialize play again
        static bool again;


        static void Main(string[] args)
        {
            Game();

            while (again == true)
            {
                Game();
            }
        }

        static void Game()
        {
            //heather
            Console.WriteLine("                                                    Eustakios[TM]");
            Console.WriteLine();

            //state names
            string[] names = { "Nahuel", "Cody", "Alex", "Justin", "Theo", "Christian" };

            //ask for names
            Console.WriteLine("If you wanna see the names aviables in the program type 1, if you don't want so, type anything.");
            Console.WriteLine();

            //creates object list
            List<string> namelist = new List<string>();

            //creates actual list
            foreach (string name in names)
            {
                namelist.Add(name);
            }

            //show names
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine();
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            }
            Console.WriteLine();

            //ask for a name
            Console.WriteLine("Write your name:");
            string input = Console.ReadLine();
            Console.WriteLine();

            //says that the name isnt in the data base ---> Random sentence
            if (!namelist.Contains(input))
            {
                Console.WriteLine("The name isn't in the data base, a random sentence will be displayed");
                Console.WriteLine();
            }

            //declare all the basic sentences
            string[] sentences = {
            //Justin and Alex
            /*0*/"I get it, you are waiting 4 your GF to be 16, so you can insert dick in pussy",
            /*1*/"WTF, why do you even bother playing that game if you have gf?",
            /*2*/"You might be depressed but at least you have someone to share saliva with.",
            /*3*/"I hope you don't leave the bois for a girl.",
            /*4*/"What you gonna do after you break with her?",
            //Christian
            /*5*/"By cuddling under the table on physics you wont get anything. Ask her out.",
            /*6*/"You have red hair, she has red menstruation. It is an EPIC VICTORY ROYALE",
            /*7*/"That tomato sauce-colored hair is kinda hot, I would smash.",
            /*8*/"There has to be a fetish for fermenting cheese in a bad circumcition",
            /*9*/"Do you have a fetish for people with horse teeth?",
            /*Random pool*/
            /*10*/"Why don't you go for that cute little 5yo that has the perfect blowjob height?",
            /*11*/"I am sure that if you stopped watching Big Bird hentai you would have someone.",
            /*12*/"Why would you bother looking for a GF if you can ask Cody to send you nasty porn?",
            /*13*/"I am sure that if you were gay, you woudn't have to worry about being single.",
            /*14*/"Have you ever thought about being gay? I don't think that girls are interested in a fucking piece of trash with legs",
            /*15*/"Well... Animals are always a good alternative, just don't get caught.",
            /*16*/"Bro, have you ckecked the deep web? Those Mongolians are kinda hot TBH",
            /*17*/"Step1: Buy a black Van. Step2: 'Free Candy'. Step 3: Profit.",
            /*18*/"Please, close your 147 tabs of 'hot ebony teens squirt on daddy's mouth with a huge bonner 100% real, no fake, no virus, use that gel to +5 inches of dick'. It wont impress any girl.",
            /*19*/"C'mon " + input + ", you should ask her, what can go wrong?",
            /*20*/"Do you think that you have chances with her? WTF is wrong with you, Have you seen yourself in the mirror? Anyone would be ashamed of dating you ",
            /*21*/"VR is evolving pretty fast, why don't you wait until you have virtual waifus connected via bluetooth to a smart pocket pussy?",
            /*22*/"Imagine that, you and her, sitting on the shore line, on a warm day of summer... You are about to kiss her when THE FUCKING ALARM RINGS.",
            /*23*/"A quick recomendation: go to your crush and tell her that: Are you retarded? because you are pretty special to me. She will instantly ask you for a date ;)",
            /*24*/"So innocent are you that you thing that she might not like you? My grandma would fuck you if you asked her out",
            /*25*/"How did you think she was going to love you if even your mother abandoned you?",
            /*26*/"Perhaps she thinks that you are gay because all the dicks you ate fucking faggot",
            /*27*/"Did your uncle put all that delusions in your ass after a 'busy' afternoon?",
            /*28*/"Don't worry, robots are the future, eventually they will also have feelings.",
            /*29*/"I am not Dwayne the Rock, but I am rock hard when I see you :3",
            // additional sentences
            };

            //create object sentencelist
            List<string> sentencelist = new List<string>();

            //add all basic sentences into sentencelist
            foreach (string sentence in sentences)
            {
                sentencelist.Add(sentence);
            }

            //initiate boolean sentenceAdding
            bool sentenceAdding;

            //ask if you want to add sentences
            Console.WriteLine("If you want to add more sentences, input 1, if you want to play with the basic sentences input something.");
            if (Console.ReadLine() == "1")
            {
                sentenceAdding = true;
                Console.WriteLine();
                Console.WriteLine("Write your sentence:");
                Console.WriteLine();
            }
            else
            {
                sentenceAdding = false;
            }

            while (sentenceAdding == true)
            {
                sentencelist.Add(Console.ReadLine());

                Console.WriteLine("Do you want to add more sentences? 1 = yes");

                if (Console.ReadLine() != "1")
                {
                    sentenceAdding = false;
                }
            }

            //creates random object
            Random rnd = new Random();

            //gets a random number depending of the name
            int sent;

            //count quantity of sentences
            int numberofSentences = sentencelist.Count;

            if (input == "Justin" || input == "Alex")
            {
                sent = rnd.Next(0, 5);
            }
            else if (input == "Christian")
            {
                sent = rnd.Next(5, 10);
            }
            else
            {
                sent = rnd.Next(10, numberofSentences);
            }

            //print the sentence
            Console.WriteLine(sentencelist.ElementAt(sent));

            //play again
            Console.WriteLine();
            Console.WriteLine("Do you want to play again? 1 = Yes");
            if(Console.ReadLine() == "1")
            {
               again = true;
            }
            else
            {
               again = false;
            }
            Console.WriteLine();

            //wait
            Console.ReadKey();
        }
    }
}