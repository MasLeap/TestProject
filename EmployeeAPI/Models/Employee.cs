using EmployeeAPI.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeAPI.Models
{
    public class Employee : IBaseEntity
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string MidleName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
    }
}
