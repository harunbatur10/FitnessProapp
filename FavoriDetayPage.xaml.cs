using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Maui.Views;
using Microsoft.Maui.ApplicationModel.DataTransfer;
using Microsoft.Maui.Controls;
using static Fitnessapp.AntrenmanListesiPage;

namespace Fitnessapp
{
    public partial class FavoriDetayPage : ContentPage
    {
        public ObservableCollection<ExerciseVideoItem> GosterilecekListe { get; set; } = new ObservableCollection<ExerciseVideoItem>();

        public FavoriDetayPage(string kategoriAdi)
        {
            InitializeComponent();
            lblBaslik.Text = kategoriAdi.ToUpper() + " FAVORİLERİ";

            FavorileriGetir(kategoriAdi);
            cvHareketler.ItemsSource = GosterilecekListe;
        }

        private async void FavorileriGetir(string kategoriAdi)
        {
            var tumHareketler = ExerciseData.GetExercises();

            var favoriler = tumHareketler
                            .Where(x => x.Category == kategoriAdi &&
                                        Preferences.Default.Get("Fav_" + x.FileName, false) == true)
                            .ToList();

            foreach (var hareket in favoriler)
            {
                string hamDosyaAdi = hareket.FileName;
                if (!hamDosyaAdi.EndsWith(".mp4")) hamDosyaAdi += ".mp4";

                string oynatilabilirYol = await DosyayiHazirla(hamDosyaAdi);

                if (oynatilabilirYol != null)
                {
                    GosterilecekListe.Add(new ExerciseVideoItem
                    {
                        Name = hareket.Name,
                        Category = hareket.Category,
                        LocalFilePath = oynatilabilirYol,
                        RawFileNameId = hareket.FileName,
                        IsFavorite = true
                    });
                }
            }
        }

        private async Task<string> DosyayiHazirla(string dosyaAdi)
        {
            string hedefYol = Path.Combine(FileSystem.CacheDirectory, dosyaAdi);
            if (File.Exists(hedefYol)) return hedefYol;
            try
            {
                using var stream = await FileSystem.OpenAppPackageFileAsync(dosyaAdi);
                using var yeniDosya = File.Create(hedefYol);
                await stream.CopyToAsync(yeniDosya);
                return hedefYol;
            }
            catch { return null; }
        }

        private void FavoriButonu_Clicked(object sender, EventArgs e)
        {
            var element = sender as Element;
            var item = element?.BindingContext as ExerciseVideoItem;
            if (item != null)
            {
                item.IsFavorite = !item.IsFavorite;
                Preferences.Default.Set("Fav_" + item.RawFileNameId, item.IsFavorite);
            }
        }

        private async void PaylasButonu_Clicked(object sender, EventArgs e)
        {
            var element = sender as Element;
            var item = element?.BindingContext as ExerciseVideoItem;
            if (item != null)
            {
                await Share.Default.RequestAsync(new ShareTextRequest
                {
                    Text = $"Fitness Pro - Favori Hareketim: {item.Name} 💪"
                });
            }
        }

        private async void KapatButonu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void Video_Yuklendi(object sender, EventArgs e)
        {
            (sender as MediaElement)?.Play();
        }

        private void Video_Tapped(object sender, EventArgs e)
        {
            var border = sender as Border;
            if (border == null) return;

            var grid = border.Content as Grid;
            if (grid == null) return;

            var videoContainer = grid.Children
                .FirstOrDefault(c => c is Grid && Grid.GetRow((BindableObject)c) == 0) as Grid;

            if (videoContainer == null) videoContainer = grid;

            var mediaElement = videoContainer.Children.FirstOrDefault(c => c is MediaElement) as MediaElement;
            var iconLabel = videoContainer.Children.FirstOrDefault(c => c is Label && ((Label)c).Text == "▶") as Label;

            if (mediaElement == null) return;

            if (mediaElement.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing)
            {
                mediaElement.Pause();
                if (iconLabel != null) iconLabel.IsVisible = true;
            }
            else
            {
                mediaElement.Play();
                if (iconLabel != null) iconLabel.IsVisible = false;
            }
        }
    }
}