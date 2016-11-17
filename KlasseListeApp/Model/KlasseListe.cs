using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace KlasseListeApp.Model
{
    public class KlasseListe : ObservableCollection<KlasseInfo>
    {



        public KlasseListe() : base()
        {
            this.Add(new KlasseInfo() { Firstname = "Fornavn", Surname = "Efternavn", MobNummer = 12345678, Email = "mail@mail.dk", GitHub = "Github brugernavn" });
        }

    }
}
