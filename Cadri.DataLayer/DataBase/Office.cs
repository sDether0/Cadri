using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cadri.DataLayer.DataBase
{
    public class Office
    {
        [Key]
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public virtual Office ParentOffice { get; set; }
        [ForeignKey("ParentId")]
        public virtual ICollection<Office> ChildOffices { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Closed { get; set; } = false;

        public string IsClosed
        {
            get => Closed ? "Закрыто" : "Работает";
        }
        public string ParentOfficeName
        {
            get { return ParentOffice?.Name; }
        }
    }
}
