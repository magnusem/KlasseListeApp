using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Windows.Storage;
using System.Threading.Tasks;

namespace KlasseListeApp.Model
{
    public class KlasseInfo
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string MobNummer { get; set; }
        public string Email { get; set; }
        public string GitHub { get; set; }

        StorageFolder localfolder = null;


        public override string ToString()
        {
            return Firstname + " " + Surname + " " + MobNummer + " " + Email + " " + GitHub + " ";
        }

    }
  
}
