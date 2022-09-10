using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AddClass
{
    class Employee
    {
        private string _firstName;
        private string _lastName;  //ctrl ve . tuşlarına nasılır , kapsülle..
        public string FirstName
        {
            set 
            {
                _firstName = value;
            }
            get 
            {
                return _firstName;
            }
        }

        private List<Employee> _lists;

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }
        public int Age { get; set; }

        public Employee()  
        {

        }



        // Overloading  ----- Opsiyon 2
        public Employee(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            // this ifadesi zorunlu değil.
        }

        // Overloading  ----- Opsiyon 1 
        //public Employee(string firstName, string lastName, int age)  
        //{
        //    this.FirstName = firstName;
        //    this.LastName = lastName;   
        //    this.Age = age;



       
    }
}

