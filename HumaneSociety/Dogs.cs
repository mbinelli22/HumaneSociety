using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Dogs : Animal
    {
        //member variables


        //constructor
        public Dogs(string Name, string Breed, string Gender,int Age, int Weight, int RoomNumber, bool VacinationStatus, double FoodAmount, bool AdoptionStatus)
        {
            name = Name;
            type = "Dog";
            breed = Breed;
            gender = Gender;
            age = Age;
            weight = Weight;
            roomNumber = RoomNumber;
            vacinationStatus = VacinationStatus;
            foodType = "Dog Food";
            foodAmount = FoodAmount;
            adoptionStatus = AdoptionStatus;
        }

        //member methods
        public override string AnimalArray()
        {
            throw new NotImplementedException();
            string[] dogArray = new string[10];
            dogArray[0] = name;
            dogArray[1] = type;
            dogArray[2] = breed;
            dogArray[3] = gender;
            dogArray[4] = age;
            dogArray[5] = weight;
            dogArray[6] = roomNumber;
            dogArray[7] = vacinationStatus;
            dogArray[8] = foodType;
            dogArray[9] = foodAmount;
            dogArray[10] = adoptionStatus;

        }
    }
}
