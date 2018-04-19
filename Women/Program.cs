using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Women
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StudentGirl student = new StudentGirl();
            student.Name = "Katty";
            student.Age = 18;            
            BusinessWoman bwoman = new BusinessWoman();
            bwoman.Name = "Rachel";
            bwoman.Age = 35;
            HouseWife houseWife = new HouseWife();
            houseWife.Name = "Sarah";
            houseWife.Age = 28;
            LittleGirl littleGirl = new LittleGirl();
            littleGirl.Name = "Ann";
            littleGirl.Age = 6;

            List<Woman> ourWomen = new List<Woman>();
            ourWomen.Add(student);
            ourWomen.Add(bwoman);
            ourWomen.Add(houseWife);
            ourWomen.Add(littleGirl);

            ourWomen.Add (new StudentGirl() { Name = "Triss", Age = 20});

                //упорядочивание коллекции с помощью экземпляра класса WomanComparerByAge
            WomanComparerByAge ageComparer = new WomanComparerByAge();
            ourWomen.Sort(ageComparer);
            Woman.showNameAgeFromList(ourWomen);
            Console.Write("\n");

                //запрос с использованием Lambda
            Woman.selectYoungFromList(ourWomen);
            Console.Write("\n");

            //запрос с использованием LINQ
            Woman.selectAdultFromList(ourWomen);
                        
            Console.ReadKey();
            
        }
       
    }
}
