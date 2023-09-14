﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.EntityModels
{
    public enum Gender {
        [Description("Мужской")]
        Male,
        [Description("Женский")]
        Female
    };
    public class PatientCard
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public Gender Gender { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime DateOfBirth { get; set; }
        public Int32 Age { get; set; } 
        public String Address { get; set; }
        public String PhoneNumber { get; set; }
        public List<Request> Requests { get; set; }
    }
}
