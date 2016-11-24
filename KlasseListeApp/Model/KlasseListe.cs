using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using System.IO;

namespace KlasseListeApp.Model
{
    public class KlasseListe : ObservableCollection<KlasseInfo>
    {



        public KlasseListe() : base()
        {
            this.Add(new KlasseInfo() { Firstname = "Fornavn", Surname = "Efternavn", MobNummer = "12345678", Email = "mail@mail.dk", GitHub = "Github brugernavn" });
            this.Add(new KlasseInfo() { Firstname = "Fornavn2", Surname = "Efternavn2", MobNummer = "123456782", Email = "mail@mail.dk2", GitHub = "Github brugernavn2" });
            this.Add(new KlasseInfo() { Firstname = "Fornavn3", Surname = "Efternavn3", MobNummer = "123456783", Email = "mail@mail.dk3", GitHub = "Github brugernavn3" });
            this.Add(new KlasseInfo() { Firstname = "Fornavn4", Surname = "Efternavn4", MobNummer = "123456784", Email = "mail@mail.dk4", GitHub = "Github brugernavn4" });
        }


        public string GetJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }
    }
}
