using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Cadri.DataLayer.DataBase
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ThirdName { get; set; }
        public bool WorkNow { get; set; } = true;
        public int? CurrentOfficeId { get; set; }
        [JsonIgnore]
        [ForeignKey("CurrentOfficeId")]
        public virtual Office? CurrentOffice { get; set; }
        [JsonIgnore]
        public virtual ICollection<TransferEmployeeInfo> Infos { get; set; }


        public string CurrentOfficeName => CurrentOffice?.Name;

    
        public string WorkNowString => WorkNow? "Да" : "Нет"; 
        

        public string FIO => LastName + " " + FirstName + " " + ThirdName; 
        
    }
}
