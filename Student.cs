using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAssignment
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public double Score { get; set; }


        public override string ToString()
        {
            return $"ID : {this.Id}, Name:{this.Name},Age:{this.Age}, Score:{this.Score}";
        }
    }
}
