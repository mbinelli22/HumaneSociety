using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Ferrits : Animal
    {
        //member variables

        //constructor
        public Ferrits(string Name, string Gender, int Age, int Weight, int RoomNumber, bool VacinationStatus, double FoodAmount, bool AdoptionStatus)
        {
            name = Name;
            type = "Ferrit";
            breed = "Ferrit";
            gender = Gender;
            age = Age;
            weight = Weight;
            roomNumber = RoomNumber;
            vacinationStatus = VacinationStatus;
            foodType = "Ferrit Food";
            foodAmount = FoodAmount;
            adoptionStatus = AdoptionStatus;
        }

        //member methods
        public override string AnimalArray()
        {
            throw new NotImplementedException();
            string[] ferritArray = new string[10];
            ferritArray[0] = name;
            ferritArray[1] = type;
            ferritArray[2] = breed;
            ferritArray[3] = gender;
            ferritArray[4] = age;
            ferritArray[5] = weight;
            ferritArray[6] = roomNumber;
            ferritArray[7] = vacinationStatus;
            ferritArray[8] = foodType;
            ferritArray[9] = foodAmount;
            ferritArray[10] = adoptionStatus;

        }


    }
}
