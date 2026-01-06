🏋️‍♂️ Fitness Pro - Mobil Antrenman Asistanı
Fitness Pro, kullanıcıların vücut anatomisi üzerinden interaktif seçim yaparak antrenman videolarına erişebildiği, .NET MAUI ile geliştirilmiş modern bir mobil fitness uygulamasıdır.

📱 Proje Hakkında
Bu proje, sporcuların (başlangıç veya ileri seviye) hedefledikleri kas grubuna yönelik hareketleri en doğru formda öğrenmelerini sağlamak amacıyla geliştirilmiştir. "TikTok/Reels" tarzı kaydırmalı video arayüzü ile modern bir kullanıcı deneyimi sunar.

🚀 Öne Çıkan Özellikler
İnteraktif Vücut Haritası: Kullanıcılar ekrandaki vücut modeline (Örn: Göğüs, Omuz, Bacak) dokunarak ilgili antrenman listesine gider.

Cinsiyet Seçimi: Erkek ve Kadın anatomisine uygun özelleştirilmiş antrenman içerikleri.

Reels Modu: Videolar tam ekran, dikey formatta ve kaydırılabilir (CarouselView) yapıda sunulur.

Favori Sistemi: Beğenilen hareketler favorilere eklenir ve cihaz hafızasında tutulur.

Çevrimdışı Çalışma: Videolar uygulama içine gömülüdür, internet bağlantısı gerektirmez.

🛠 Kullanılan Teknolojiler
Framework: .NET 9.0 (MAUI)

Dil: C#

IDE: Visual Studio 2022

Veri Yönetimi: ObservableCollection, Preferences (Yerel Depolama)

UI Bileşenleri: AbsoluteLayout (Harita için), CarouselView (Videolar için), CommunityToolkit.Maui (MediaElement).

📊 Analiz ve Tasarım Modelleri
Uygulama Açılış -> Cinsiyet Seçimi (Erkek/Kadın) -> Vücut Haritasından Bölge Seçimi (Örn: Omuz) -> Video Listesi (Reels) -> Favoriye Ekle / Paylaş

2. Sınıf Diyagramı (Class Diagram)
Projede kullanılan temel sınıflar ve ilişkileri:

ExerciseVideoItem: Videonun adı, kategorisi, dosya yolu ve favori durumunu tutar. (INotifyPropertyChanged uygular).

ExerciseData: Tüm egzersiz verilerinin (Statik veri tabanı) tutulduğu sınıf.

MainPage: Ana sayfa, vücut haritası ve etkileşim mantığı.

AntrenmanListesiPage: Seçilen bölgeye göre videoları filtreleyen ve oynatan sayfa.

FavorilerPage: Kullanıcının kaydettiği favori hareketleri listeleyen sayfa.
