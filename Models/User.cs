using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GeosemanticTest.Models {
    public class User {

        public int Id { get; set; }

        // Login Information

        [Required]
        public string Email { get; set; }

        [Required]  
        [DataType(DataType.Password)]
        public string Password { get; set; }

        // Personal Information
        public string Name { get; set; }
        public int DateOfBirth { get; set; }
        public string Gender { get; set; }

        // Professional Information
        public int YearsOfExperience { get; set; }
        public string LastEmployerName { get; set; }
        public string LastEmployerTell { get; set; }
        public string LastEmployerEmail { get; set; }

        // Education Information
        public string Education { get; set; }
        public int PassYear { get; set; }
        public int Percentage { get; set; }

    }
}