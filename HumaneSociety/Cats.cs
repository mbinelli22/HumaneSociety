using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Cats : Animal
    {
        //member variables

        //constructor
        public Cats(string Name, string Breed, string Gender, int Age, int Weight, int RoomNumber, bool VacinationStatus, double FoodAmount, bool AdoptionStatus)
        {
            name = Name;
            type = "Cat";
            breed = Breed;
            gender = Gender;
            age = Age;
            weight = Weight;
            roomNumber = RoomNumber;
            vacinationStatus = VacinationStatus;
            foodType = "Cat Food";
            foodAmount = FoodAmount;
            adoptionStatus = AdoptionStatus;
        }

        //member methods
        


    }
}
