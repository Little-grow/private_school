﻿using System.ComponentModel.DataAnnotations;

namespace Private_School.Data
{
    public class Employee
    {
        [Key]
        public  int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required int PhoneNumber { get; set; }
        public required string _Role { get; set; }
        public required string _address { get; set; }
        public required float Salary { get; set; }
    }
}
