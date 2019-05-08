using System;
using System.Collections.Generic;
using System.Text;

namespace CodingSolution
{
    class People
    {
        private string firstName;
        private string middleName;
        private string lastName;

        People(string nameOne)
        {
            lastName = nameOne;
        }

        People(string nameOne, string nameTwo)
        {
            firstName = nameOne;
            lastName = nameTwo;
        }
        People(string nameOne, string nameTwo, string nameThree)
        {
            firstName = nameOne;
            middleName = nameTwo;
            lastName = nameThree;
        }
    }
}
