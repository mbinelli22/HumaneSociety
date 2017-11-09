using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class HumaneSocietyUI
    {
        //member variables
        public static Employee employee;
        public static Adopter adopter;
        
        

        //constructor
        public HumaneSocietyUI()
        {
            Employee employee = new Employee();
            Adopter adopter = new Adopter();
        }

        //member methods


        public void DetermineEmployeeOrAdopter(Employee employee, Adopter adopter)
        {
            Console.WriteLine("Are you an employee or potential adopter?");
            Console.WriteLine("Employee: '1'");
            Console.WriteLine("Adopter: '2'");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    StartProgramEmployee(employee);
                    break;
                case "2":
                    StartProgramAdopter(adopter);
                    break;
                default:
                    DetermineEmployeeOrAdopter(employee, adopter);
                    break;
                
            }
        }

        public void StartProgramEmployee(Employee employee)
        {
            Console.WriteLine("Hello! Please enter the number that corresponds to what you wish to do.");
            Console.WriteLine("Add an animal to database: '1'");
            Console.WriteLine("Find room number for animal: '2'");
            Console.WriteLine("Change adoption status for animal: '3'");
            Console.WriteLine("Collect money from an adopter: '4'");
            Console.WriteLine("Search vacination status for an animal: '5'");
            Console.WriteLine("Change vacination status for an animal: '6'");
            Console.WriteLine("Catogorize different types of animals: '7'");
            Console.WriteLine("Search animals food needs: '8'");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    if(userInput != null)
                    {
                        employee.AddAnimaltoDatabase();
                    }
                    break;
                case "2":
                    if (userInput != null)
                    {
                        employee.FindRoomNumberForAnimal();
                    }
                    break;
                case "3":
                    if (userInput != null)
                    {
                        employee.ChangeAdoptionStatus();
                    }
                    break;
                case "4":
                    if (userInput != null)
                    {
                        employee.CollectMoney();
                    }
                    break;
                case "5":
                    if (userInput != null)
                    {
                        employee.CheckAnimalVacinationStatus();
                    }
                    break;
                case "6":
                    if (userInput != null)
                    {
                        employee.ChangeAnimalVacinationStatus();
                    }
                    break;
                case "7":
                    if (userInput != null)
                    {
                        employee.SearchForAnimal();
                    }
                    break;
                case "8":
                    if (userInput != null)
                    {
                        employee.FeedAnimal();
                    }
                    break;
                default:
                    StartProgramEmployee(employee);
                    break;
                  
            }            
        }

        public void StartProgramAdopter(Adopter adopter)
        {
            Console.WriteLine("Hello! Please enter the number that corresponds to what you wish to do.");
            Console.WriteLine("Create new profile: '1'");
            Console.WriteLine("Search for a new pet!: '2'");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    adopter.CreateProfile();
                    break;
                case "2":
                    adopter.SearchForAnimal();
                    break;
                default:
                    StartProgramAdopter(adopter);
                    break;
            }
        }


    }
}
