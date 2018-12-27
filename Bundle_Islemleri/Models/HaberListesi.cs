using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bundle_Islemleri.Models
{
    public class HaberListesi:List<Haber>
    {
        public HaberListesi()
        {
            this.Add(new Haber { Id = 1, Adi = "2-gundur-devam-ediyor-otomobiller-kayboldu", Url = "http://i.hurimg.com/i/hurriyet/75/590x0/5c237eedc03c0e0cc0551217.jpg", YayinlanmaTarihi = DateTime.Now });
            this.Add(new Haber { Id = 2, Adi = "hastaneye-goturulunce-sacmayla-yaralandiklarini-ogrendiler", Url = "http://i.hurimg.com/i/hurriyet/75/750x422/5c223e9a0f25440c7cd5ea60.jpg", YayinlanmaTarihi = DateTime.Now });

        }

    }
}