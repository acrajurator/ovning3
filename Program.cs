using ovning3.Animals;
using ovning3.Errors;
using System;
using System.Collections.Generic;


// Svar på frågor
// 13. För att lägga till attribut till samtliga fåglar gör det i Bird klassen
//14. För att ge alla djur ett nytt attribut lägg det i animals.
//9. horse och dog klasserna är inte samma sak och har ingen direkt relation 
// så de skulle behöva en custom metod för att casta den ena till den andra  
// 10 både horse och dog är childs från animal så båda kan behandlas som animals
//13. Alla som ärver från animals har en stats() metod som de måste override. så när de behandlas
// som animals så spelar det ingen roll vilken klass de är men deras egen override kommer användas.
//17. animals känner inte till sina childrens metoder.



namespace ovning3
{
    class Program
    {
        static void Main(string[] args)
        {

            ErrorRun();



            PersonRun();

            AnimalRun();

        }

        private static void AnimalRun()
        {
            var animalList = new List<Animal>();
            animalList.Add(new Bird("Hyesu", 5, 22, 34));
            animalList.Add(new Dog("Gupie", 5, 22, "Pasta"));
            animalList.Add(new Flamingo("Taeyang", 5, 22, 34, 5321));
            animalList.Add(new Hedgehog("Sonic", 5, 22, 34));
            animalList.Add(new Horse("Eric", 5, 22, 34));
            animalList.Add(new Pelican("Edward", 5, 22, 34, "When doves cry", 12));
            animalList.Add(new Swan("Black", 5, 22, 34, true));
            animalList.Add(new Wolf("Kira", 5, 22, "Da West Staines Massif"));
            animalList.Add(new Wolfman("Jacob", 5, 22, "TheWolfPack"));
            animalList.Add(new Worm("Snake", 5, 22, 34));

            foreach (var x in animalList)
            {
                Console.WriteLine(x.GetType().Name);
                Console.WriteLine(x.stats());
                Console.WriteLine(x.DoSound());
                if (x is IPerson)
                    Console.WriteLine(((IPerson)x).Talk());
                //if I only want to print dogs use this part instead
              /*  if (x is Dog)
                {
               
                    Console.WriteLine("hi");
               }*/
            }
        }

        private static void PersonRun()
        {
            var persHandler = new PersonHandler();

            try
            {

                var pers = persHandler.CreatePerson(5, "Håkan", "Bråkan", 22.222, 22.222);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

        }

        private static void ErrorRun()
        {
            var errorList = new List<UserError>(){new LackOfPizzaError(), new MadeUpError(), new NumericInputError(), new SitTooMuchError(),
                new TextInputError()};
            foreach (var i in errorList)
            {
                Console.WriteLine(i.UEMessage());
            }
        }
    }

}

