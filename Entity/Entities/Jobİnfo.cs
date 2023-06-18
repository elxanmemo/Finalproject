using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Jobİnfo:BaseEntity
    {
       public JobCategories WorkCategories { get; set; }
        public int WorkCatagoriesId { get; set; }
        public Cities Cities { get; set; }
        public string Position { get; set; }
        public int? MaxSalary { get; set; }
        public int? MinSalary { get; set;}
        public Education Education { get; set; }
        public Experience Experience { get; set; }
        public string Requirements { get; set; }
        public string WorkInfo { get; set;}
        public string CompanyName { get; set; }
        public string RelatedPerson { get; set;}
        public DateTime DateAndTime { get; set; }



    }
}
