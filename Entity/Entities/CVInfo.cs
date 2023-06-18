using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class CVInfo:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public SexType SexType { get; set; }
        public Education Education { get; set; }
        public string EducationInfo { get; set; }
        public Experience Experience { get; set; }
        public string ExperienceInfo { get; set; }
        public JobCategories JobCategories { get; set; }
        public string Position { get; set; }
        public int MinSalary { get; set; }
        public Cities Cities { get; set; }  
        public string Skills { get; set; }
        public string AdditionalInfo { get; set;}
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        
    }
}
