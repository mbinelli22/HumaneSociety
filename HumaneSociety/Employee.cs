using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Employee
    {
        //member variables

        //constructor
        public Employee()
        {

        }

        //member methods
        public void AddAnimaltoDatabase()
        {
            Console.WriteLine("Please enter the following information: Animal Name, Type, Breed, Gender, Age, Weight, Room #, Vacination Status, Food Type, Food Amount, Adoption Status.");
            string animalInfo = Console.ReadLine();

        }

        public void FindRoomNumberForAnimal()
        {
            Console.WriteLine("Please enter the ID number for the animal you wish to search for: ");
            string userInput = Console.ReadLine();
            int animalID = Convert.ToInt32(userInput);

            
        }


        public void ChangeAdoptionStatus()
        {

        }

        public void CollectMoney()
        {

        }

        public void CheckAnimalVacinationStatus()
        {

        }

        




    }
}
