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
        public override string AnimalArray()
        {
            throw new NotImplementedException();
            string[] catArray = new string[10];
            catArray[0] = name;
            catArray[1] = type;
            catArray[2] = breed;
            catArray[3] = gender;
            catArray[4] = age;
            catArray[5] = weight;
            catArray[6] = roomNumber;
            catArray[7] = vacinationStatus;
            catArray[8] = foodType;
            catArray[9] = foodAmount;
            catArray[10] = adoptionStatus;

        }



    }
}
