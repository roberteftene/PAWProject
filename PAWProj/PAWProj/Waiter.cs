using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAWProj
{
    [Serializable]
    class Waiter
    {

        private string firstName;
        private string lastName;
        private int age;
        private string experince;


        public Waiter(string firstName, string lastName, int age, string experience)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.experince = experience;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Experience
        {
            get { return experince; }
            set { experince = value; }
        }

        public override string ToString()
        {
            string toPrint = null;
            toPrint += "First name: " + this.firstName
                + ", Last name: " + this.lastName
                + ", Age: " + this.age
                + ", Experience: " + this.experince;
            return toPrint;
        }

    }
}
