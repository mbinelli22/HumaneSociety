using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Birds : Animal
    {
        //member variables

        //constructor
        public Birds(string Name, string Breed, string Gender, int Age, int Weight, int RoomNumber, bool VacinationStatus, double FoodAmount, bool AdoptionStatus)
        {
            name = Name;
            type = "Bird";
            breed = Breed;
            gender = Gender;
            age = Age;
            weight = Weight;
            roomNumber = RoomNumber;
            vacinationStatus = VacinationStatus;
            foodType = "Bird Food";
            foodAmount = FoodAmount;
            adoptionStatus = AdoptionStatus;
        }

        //member methods
        public override string AnimalArray()
        {
            throw new NotImplementedException();
            string[] birdArray = new string[10];
            birdArray[0] = name;
            birdArray[1] = type;
            birdArray[2] = breed;
            birdArray[3] = gender;
            birdArray[4] = age;
            birdArray[5] = weight;
            birdArray[6] = roomNumber;
            birdArray[7] = vacinationStatus;
            birdArray[8] = foodType;
            birdArray[9] = foodAmount;
            birdArray[10] = adoptionStatus;

        }
    }
}
