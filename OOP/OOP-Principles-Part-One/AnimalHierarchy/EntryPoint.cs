namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EntryPoint
    {
        static void Main()
        {
            var animalKingdom = new List<Animal>();
            animalKingdom.Add(new Cat("Charlie", 6, Gender.Male));
            animalKingdom.Add(new Kitten("Suzan", 1, Gender.Female));
            animalKingdom.Add(new Dog("Chochko", 2, Gender.Male));
            animalKingdom.Add(new Frog("Wabit", 1, Gender.Female));

            float averageAnimalAge = CalculateAverageAge(animalKingdom);

            Console.WriteLine("Average animal age is: " + averageAnimalAge);
        }
        public static float CalculateAverageAge<T>(List<T> animalKingdom) where T : Animal
        {
            float average = 0;
            foreach (var animal in animalKingdom)
            {
                average += animal.Age;
            }
            average /= animalKingdom.Count;
            return average;
        }
    }
}
