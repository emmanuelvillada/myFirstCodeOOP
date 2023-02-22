using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Employee
    {
        #region Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }
        #endregion

        #region Methods
        public abstract decimal GetValueToPay();
        
        public override string ToString()
        {
            return String.Format(
                "-------EMPLOYEE-------\n\t" +
                "Id.................{0}\n\t" +
                "Last Name..........{2}\n\t" +
                "First Name.........{1}\n\t" +
                "Birth Day..........{3}\n\t" +
                "Hiring Date........{4}\n\t" +
                "Is Active?.........{5}",
                Id,
                FirstName,
                LastName,
                BirthDate,
                HiringDate,
                IsActive);
        }
        #endregion
    }
}

