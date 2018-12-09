using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void PrintAnimals(Animal[] array)
        {
            for(int i = 0;i<array.Length;i++)
            {
                array[i].PrintAnimal();
                Console.WriteLine();
            }
        }

        static int FindAvilableIndexInArray(Animal[] array)
        {
            int i;
            for ( i = 0; i < array.Length; i++)
            {
                if(array[i] == )
            }
        }
    }
    class Animal
    {
        
        private string Name { get; set; }
        private string AnimalType { get; set; }
        private bool IsMale { get; set; }
        private double Height { get; set; }
        private int Age { get; set; }
        private string BestFood { get; set; }

        public Animal(string name , string animalType,bool isMale, double height,int age,string bestFood)
        {
            Name = name;
            AnimalType = animalType;
            IsMale = isMale;
            Height = height;
            Age = age;
            BestFood = bestFood;
        }

        public void PrintAnimal()
        {
            Console.Write("Animal name = "+Name + " ,");
            Console.Write("Animal type = "+AnimalType + " ,");
            Console.Write("Animal is male = "+ IsMale + " ,");
            Console.Write("Animal height = "+Height + " ,");
            Console.Write("Animal age = "+Age + " ,");
            Console.WriteLine("Animal best food = "+BestFood);
            
        }

    }
}
