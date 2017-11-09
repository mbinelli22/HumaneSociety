using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Rabbits : Animal
    {
        //member variables

        //constructor
        public Rabbits(string Name, string Breed, string Gender, int Age, int Weight, int RoomNumber, bool VacinationStatus, double FoodAmount, bool AdoptionStatus)
        {
            name = Name;
            type = "Rabbit";
            breed = Breed;
            gender = Gender;
            age = Age;
            weight = Weight;
            roomNumber = RoomNumber;
            vacinationStatus = VacinationStatus;
            foodType = "Rabbit Food";
            foodAmount = FoodAmount;
            adoptionStatus = AdoptionStatus;
        }

        //member methods
        public override string AnimalArray()
        {
            throw new NotImplementedException();
            string[] rabbitArray = new string[10];
            rabbitArray[0] = name;
            rabbitArray[1] = type;
            rabbitArray[2] = breed;
            rabbitArray[3] = gender;
            rabbitArray[4] = age;
            rabbitArray[5] = weight;
            rabbitArray[6] = roomNumber;
            rabbitArray[7] = vacinationStatus;
            rabbitArray[8] = foodType;
            rabbitArray[9] = foodAmount;
            rabbitArray[10] = adoptionStatus;

        }
    }
}
