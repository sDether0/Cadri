using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Cadri.DataLayer.DataBase
{
    public class TransferEmployeeInfo 
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        public int OfficeId { get; set; }
        [ForeignKey("OfficeId")]
        public virtual Office Office { get; set; }
        public DateOnly StartWork { get; set; }
        public DateOnly? EndWork { get; set; }
    }
}
