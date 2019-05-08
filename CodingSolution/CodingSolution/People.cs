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

       public People(string nameOne)
        {
            lastName = nameOne;
        }

       public People(string nameOne, string nameTwo)
        {
            firstName = nameOne;
            lastName = nameTwo;
        }
       public People(string nameOne, string nameTwo, string nameThree)
        {
            firstName = nameOne;
            middleName = nameTwo;
            lastName = nameThree;
        }

        public string getLastName()
        {
            return lastName;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getMiddleName()
        {
            return middleName;
        }

        public string toString()
        {
            string result = "";

            if(firstName == null)
            {
                result = getLastName();
            }
            else if(getMiddleName() == null)
            {
                result = getFirstName() + " " + getLastName();
            }
            else
            {
                result = getFirstName() + " "  + getMiddleName() + " " + getLastName();
            }
            return result;
        }
    }

}
