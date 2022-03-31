using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Cadri.DataLayer.DataBase
{
    public class TransferEmployeeInfo 
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        [JsonIgnore]
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        public int OfficeId { get; set; }
        [ForeignKey("OfficeId")]
        [JsonIgnore]
        public virtual Office Office { get; set; }
        public DateOnly StartWork { get; set; }
        public DateOnly? EndWork { get; set; }
    }
}
