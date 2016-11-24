using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Windows.Storage;

namespace KlasseListeApp.ViewModel
{
    class KlasseViewModel : INotifyPropertyChanged
    {
        public Model.KlasseListe KListe { get; set; }
        public RelayCommand SaveCommand { get; set; }
        public SletElevCommand SletElevCommand { get; set; }
        public AddElevCommand AddElevCommand { get; set; }
        public Model.KlasseInfo NewElev { get; set; }
        public RelayCommand HentDataCommand { get; set; }

        private StorageFolder localfolder;
        private Model.KlasseInfo SelectedElev;

        private readonly string filnavn = "Jsontext.json";
        public event PropertyChangedEventHandler PropertyChanged;

        public Model.KlasseInfo selectedElev
        {
            get { return SelectedElev; }
            set { SelectedElev = value;
                OnPropertyChanged(nameof(selectedElev));
            }
        }


        public KlasseViewModel()
        {
            KListe = new Model.KlasseListe();
            AddElevCommand = new AddElevCommand(AddNewElev);
            NewElev = new Model.KlasseInfo();
            SletElevCommand = new SletElevCommand(SletElev);
            localfolder = ApplicationData.Current.LocalFolder;
            SaveCommand = new RelayCommand(GemDataTilDiskenAsync);
            HentDataCommand = new RelayCommand(HentDataFraDiskenAsync);
        }



        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }



        public void AddNewElev()
        {
            KListe.Add(NewElev);
        }



        public void SletElev()
        {
            KListe.Remove(SelectedElev);
        }



        public string GetKlasseListAsJson()
        {
            string jsonText = JsonConvert.SerializeObject(KListe);
            return jsonText;
        }


        public async void GemDataTilDiskenAsync()
        {
            string jsontext = this.KListe.GetJson();
            StorageFile file = await localfolder.CreateFileAsync(filnavn, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(file, jsontext);
        }



        public async void HentDataFraDiskenAsync()
        {
            this.KListe.Clear();

            StorageFile file = await localfolder.GetFileAsync(filnavn);
            string jsonText = await FileIO.ReadTextAsync(file);

            KListe.HentDataFraDiskenAsync(jsonText);
        }
    }
}
