using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
   public class Persona
    {
        private string name;
        private int age;
        private string datebirth;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string DateBirth { get => datebirth; set => datebirth = value; }

        public void createPerson(string _name, int _age, string _datebirth) 
        {
            this.name = _name;
            this.age = _age;
            this.DateBirth = _datebirth;
        }
    }
}
