using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Program
    {
        private static Adopter adopter;
        private static Employee employee;

        static void Main(string[] args)
        {
            HumaneSocietyUI humaneSocietyUI = new HumaneSocietyUI();
            humaneSocietyUI.DetermineEmployeeOrAdopter(employee, adopter);
        }
    }
}
