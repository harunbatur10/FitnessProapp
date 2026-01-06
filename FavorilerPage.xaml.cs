using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Linq;

namespace Fitnessapp
{
    public partial class FavorilerPage : ContentPage
    {
        public ObservableCollection<FavoriKategoriModeli> KategorilerListesi { get; set; } = new ObservableCollection<FavoriKategoriModeli>();

        public FavorilerPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            FavorileriYukle();
        }

        private void FavorileriYukle()
        {
            KategorilerListesi.Clear();

            var tumHareketler = ExerciseData.GetExercises();

           
            var favoriHareketler = tumHareketler
                                   .Where(x => Preferences.Default.Get("Fav_" + x.FileName, false) == true)
                                   .ToList();

            if (favoriHareketler.Count == 0)
            {
                BosEkranUyarisi.IsVisible = true;
                cvKategoriler.IsVisible = false;
                return;
            }

            BosEkranUyarisi.IsVisible = false;
            cvKategoriler.IsVisible = true;

            
            var gruplanmisListe = favoriHareketler
                                  .GroupBy(x => x.Category)
                                  .Select(g => new FavoriKategoriModeli
                                  {
                                      KategoriAdi = g.Key,
                                      HareketSayisi = g.Count(),
                                      BasHarf = g.Key.Substring(0, 1).ToUpper()
                                  })
                                  .OrderBy(x => x.KategoriAdi) 
                                  .ToList();

            foreach (var item in gruplanmisListe)
            {
                KategorilerListesi.Add(item);
            }

            cvKategoriler.ItemsSource = KategorilerListesi;
        }

        private async void GeriDon_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        
        private async void KategoriSecildi(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is FavoriKategoriModeli secilen)
            {
               
                cvKategoriler.SelectedItem = null;

              

                await Navigation.PushAsync(new FavoriDetayPage(secilen.KategoriAdi));
            }
        }
    }

    public class FavoriKategoriModeli
    {
        public string KategoriAdi { get; set; }
        public int HareketSayisi { get; set; }
        public string BasHarf { get; set; }
    }
}