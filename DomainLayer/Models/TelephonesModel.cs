using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class TelephonesModel : BaseEntity
    {
        public string Telephone { get; set; }
        public TypeTelephoneModel TypeTelephone { get; set; }
    }
}
