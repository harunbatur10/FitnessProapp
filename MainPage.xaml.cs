using Microsoft.Maui.Controls;
using System;

namespace Fitnessapp
{
    public partial class MainPage : ContentPage
    {
        string seciliCinsiyet = "erkek";
        string seciliYon = "on";

       
        Color AktifRenk = Color.FromArgb("#1A1A1A"); 
        Color PasifRenk = Color.FromArgb("#80000000"); 

        public MainPage()
        {
            InitializeComponent();
            seciliCinsiyet = Preferences.Default.Get("KayitliCinsiyet", "erkek");
            ResmiGuncelle();
        }

        
        private async void FavorilerimSayfasiniAc(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FavorilerPage());
        }
        private void CinsiyetDegistir(object sender, TappedEventArgs e)
        {
            seciliCinsiyet = e.Parameter.ToString();
            Preferences.Default.Set("KayitliCinsiyet", seciliCinsiyet);
            ResmiGuncelle();
        }

        private void YonDegistir(object sender, TappedEventArgs e)
        {
            if (seciliYon == "on") seciliYon = "arka";
            else seciliYon = "on";
            ResmiGuncelle();
        }

        private void ResmiGuncelle()
        {
            bool onAcik = (seciliYon == "on");
            bool arkaAcik = !onAcik;

           
            if (seciliCinsiyet == "erkek")
            {
                MaleBorderErkek.BackgroundColor = AktifRenk;
                MaleBorderKadin.BackgroundColor = PasifRenk;
                FemaleBorderErkek.BackgroundColor = AktifRenk;
                FemaleBorderKadin.BackgroundColor = PasifRenk;
            }
            else
            {
                MaleBorderKadin.BackgroundColor = AktifRenk;
                MaleBorderErkek.BackgroundColor = PasifRenk;
                FemaleBorderKadin.BackgroundColor = AktifRenk;
                FemaleBorderErkek.BackgroundColor = PasifRenk;
            }

            if (seciliCinsiyet == "erkek")
            {
                MaleLayout.IsVisible = true;
                FemaleLayout.IsVisible = false;
                ImgErkek.Source = $"erkek_{seciliYon}.png";
                GrupGorunurlukAyarla(true, onAcik, arkaAcik);
            }
            else
            {
                MaleLayout.IsVisible = false;
                FemaleLayout.IsVisible = true;
                ImgKadin.Source = $"kadin_{seciliYon}.png";
                GrupGorunurlukAyarla(false, onAcik, arkaAcik);
            }
        }

        private void GrupGorunurlukAyarla(bool isErkek, bool onAcik, bool arkaAcik)
        {
            if (isErkek)
            {
                BtnErkekGogus.IsVisible = onAcik; BtnErkekKarin.IsVisible = onAcik;
                BtnErkekSolOmuz.IsVisible = onAcik; BtnErkekSagOmuz.IsVisible = onAcik;
                BtnErkekSolPazu.IsVisible = onAcik; BtnErkekSagPazu.IsVisible = onAcik;
                BtnErkekSolOnKol.IsVisible = onAcik; BtnErkekSagOnKol.IsVisible = onAcik;
                BtnErkekSolUstBacak.IsVisible = onAcik; BtnErkekSagUstBacak.IsVisible = onAcik;
                BtnErkekSolAltBacak.IsVisible = onAcik; BtnErkekSagAltBacak.IsVisible = onAcik;

                BtnErkekSirt.IsVisible = arkaAcik;
                BtnErkekSolArkaOmuz.IsVisible = arkaAcik; BtnErkekSagArkaOmuz.IsVisible = arkaAcik;
                BtnErkekKalca.IsVisible = arkaAcik;
                BtnErkekSolArkaKol.IsVisible = arkaAcik; BtnErkekSagArkaKol.IsVisible = arkaAcik;
                BtnErkekSolOnKolArka.IsVisible = arkaAcik; BtnErkekSagOnKolArka.IsVisible = arkaAcik;
                BtnErkekSolArkaUstBacak.IsVisible = arkaAcik; BtnErkekSagArkaUstBacak.IsVisible = arkaAcik;
                BtnErkekSolAltBacakArka.IsVisible = arkaAcik; BtnErkekSagAltBacakArka.IsVisible = arkaAcik;
            }
            else
            {
                BtnKadinGogus.IsVisible = onAcik; BtnKadinKarin.IsVisible = onAcik;
                BtnKadinSolOmuz.IsVisible = onAcik; BtnKadinSagOmuz.IsVisible = onAcik;
                BtnKadinSolPazu.IsVisible = onAcik; BtnKadinSagPazu.IsVisible = onAcik;
                BtnKadinSolOnKol.IsVisible = onAcik; BtnKadinSagOnKol.IsVisible = onAcik;
                BtnKadinSolUstBacak.IsVisible = onAcik; BtnKadinSagUstBacak.IsVisible = onAcik;
                BtnKadinSolAltBacak.IsVisible = onAcik; BtnKadinSagAltBacak.IsVisible = onAcik;

                BtnKadinSirt.IsVisible = arkaAcik;
                BtnKadinSolArkaOmuz.IsVisible = arkaAcik; BtnKadinSagArkaOmuz.IsVisible = arkaAcik;
                BtnKadinKalca.IsVisible = arkaAcik;
                BtnKadinSolArkaKol.IsVisible = arkaAcik; BtnKadinSagArkaKol.IsVisible = arkaAcik;
                BtnKadinSolOnKolArka.IsVisible = arkaAcik; BtnKadinSagOnKolArka.IsVisible = arkaAcik;
                BtnKadinSolArkaUstBacak.IsVisible = arkaAcik; BtnKadinSagArkaUstBacak.IsVisible = arkaAcik;
                BtnKadinSolAltBacakArka.IsVisible = arkaAcik; BtnKadinSagAltBacakArka.IsVisible = arkaAcik;
            }
        }

       
        private async void AntrenmanSayfasiniAc(string baslik, string kategoriAdi)
        {
            await Navigation.PushAsync(new AntrenmanListesiPage(baslik, kategoriAdi, seciliCinsiyet));
        }

       
        private void GogusTiklandi(object sender, EventArgs e) => AntrenmanSayfasiniAc("GÖĞÜS ANTRENMANI", "Göğüs");
        private void KarinTiklandi(object sender, EventArgs e) => AntrenmanSayfasiniAc("KARIN ANTRENMANI", "Karın");
        private void SirtTiklandi(object sender, EventArgs e) => AntrenmanSayfasiniAc("SIRT ANTRENMANI", "Sırt");
        private void OmuzTiklandi(object sender, EventArgs e) => AntrenmanSayfasiniAc("OMUZ ANTRENMANI", "Omuz");
        private void PazuTiklandi(object sender, EventArgs e) => AntrenmanSayfasiniAc("KOL (BICEPS) ANTRENMANI", "Kol");
        private void ArkaKolTiklandi(object sender, EventArgs e) => AntrenmanSayfasiniAc("ARKA KOL ANTRENMANI", "Arka Kol");
        private void OnKolOnTiklandi(object sender, EventArgs e) => AntrenmanSayfasiniAc("BİLEK ANTRENMANI", "Bilek");
        private void OnKolArkaTiklandi(object sender, EventArgs e) => AntrenmanSayfasiniAc("BİLEK ANTRENMANI", "Bilek");
        private void OnBacakTiklandi(object sender, EventArgs e) => AntrenmanSayfasiniAc("ÜST BACAK ANTRENMANI", "Üst Bacak");
        private void ArkaUstBacakTiklandi(object sender, EventArgs e) => AntrenmanSayfasiniAc("ÜST BACAK ANTRENMANI", "Üst Bacak");
        private void AltBacakOnTiklandi(object sender, EventArgs e) => AntrenmanSayfasiniAc("ALT BACAK ANTRENMANI", "Alt Bacak");
        private void AltBacakArkaTiklandi(object sender, EventArgs e) => AntrenmanSayfasiniAc("ALT BACAK ANTRENMANI", "Alt Bacak");
        private void KalcaTiklandi(object sender, EventArgs e) => AntrenmanSayfasiniAc("KALÇA / SQUAT", "Squat");
    }
}