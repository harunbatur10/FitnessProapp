using Microsoft.Maui.Controls;
using System.Linq;
using System.Collections.ObjectModel;
using CommunityToolkit.Maui.Views;
using Microsoft.Maui.ApplicationModel.DataTransfer; 

namespace Fitnessapp
{
    public partial class AntrenmanListesiPage : ContentPage
    {
        public ObservableCollection<ExerciseVideoItem> GosterilecekListe { get; set; } = new ObservableCollection<ExerciseVideoItem>();

        public AntrenmanListesiPage(string baslik, string kategoriAdi, string cinsiyet)
        {
            InitializeComponent();

       
            lblBaslik.Text = baslik.ToUpper();

            ListeyiHazirla(kategoriAdi, cinsiyet);
            cvHareketler.ItemsSource = GosterilecekListe;
        }

        private async void ListeyiHazirla(string kategoriAdi, string cinsiyet)
        {
            var tumHareketler = ExerciseData.GetExercises();

            var filtrelenmisListe = tumHareketler
                                    .Where(x => x.Category == kategoriAdi && x.Gender == cinsiyet)
                                    .ToList();

            foreach (var hareket in filtrelenmisListe)
            {
                string hamDosyaAdi = hareket.FileName;
                if (!hamDosyaAdi.EndsWith(".mp4")) hamDosyaAdi += ".mp4";

                string oynatilabilirYol = await DosyayiHazirla(hamDosyaAdi);

                if (oynatilabilirYol != null)
                {
                   
                   
                    bool kayitliFavoriDurumu = Preferences.Default.Get("Fav_" + hareket.FileName, false);

                    GosterilecekListe.Add(new ExerciseVideoItem
                    {
                        Name = hareket.Name,
                        Category = hareket.Category,
                        LocalFilePath = oynatilabilirYol,
                        RawFileNameId = hareket.FileName, 
                        IsFavorite = kayitliFavoriDurumu 
                    });
                }
            }
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
                    Title = "Fitness Pro Antrenman",
                    Text = $"Fitness Pro uygulamasında şu hareketi inceliyorum: {item.Name} ({item.Category}) 💪"
                });
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
            catch
            {
                return null;
            }
        }

        private async void KapatButonu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        
        private void Video_Yuklendi(object sender, EventArgs e)
        {
            var mediaElement = sender as MediaElement;
            if (mediaElement != null)
            {
                mediaElement.Play();
            }
        }

        private void Video_Tapped(object sender, EventArgs e)
        {
            var border = sender as Border;
            if (border == null) return;

            var mainGrid = border.Content as Grid;
            if (mainGrid == null) return;

            var videoContainer = mainGrid.Children
                .FirstOrDefault(c => c is Grid && Grid.GetRow((BindableObject)c) == 0) as Grid;

            if (videoContainer == null) videoContainer = mainGrid;

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

        public class ExerciseVideoItem : System.ComponentModel.INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string LocalFilePath { get; set; }
      
        public string RawFileNameId { get; set; }

        
        private bool _isFavorite;
        public bool IsFavorite
        {
            get => _isFavorite;
            set
            {
                if (_isFavorite != value)
                {
                    _isFavorite = value;
                   
                    OnPropertyChanged(nameof(IsFavorite));
                    OnPropertyChanged(nameof(FavoriteIcon));
                    OnPropertyChanged(nameof(FavoriteColor));
                }
            }
        }

       
        public string FavoriteIcon => IsFavorite ? "❤️" : "🤍";
        
        public Color FavoriteColor => IsFavorite ? Colors.Red : Colors.White;


       
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}

}