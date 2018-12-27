using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bundle_Islemleri.Models
{
    public class Haber
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Url { get; set; }
        public DateTime YayinlanmaTarihi { get; set; }

    }
}