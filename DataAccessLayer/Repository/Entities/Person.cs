using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NetCoreApiPractice.Repository.Entities
{
    [Table("Person")]
    public partial class Person
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("first_name")]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Column("last_name")]
        [StringLength(100)]
        public string LastName { get; set; }
        [Column("address")]
        [StringLength(100)]
        public string Address { get; set; }
        [Column("phone_number")]
        [StringLength(100)]
        public string PhoneNumber { get; set; }
        [Column("date_of_birth", TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }
    }
}
