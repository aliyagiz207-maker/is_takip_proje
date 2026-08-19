# İş Takip Projesi

C# ve .NET Framework kullanılarak geliştirilmiş, SQL Server ve Entity Framework tabanlı iş takip ve çağrı yönetim projesi.

## Projeler

### Windows Forms Uygulaması

DevExpress kullanılarak geliştirilen masaüstü iş takip uygulaması.

- Departman yönetimi
- Personel yönetimi
- Firma yönetimi
- Görev oluşturma ve takip
- Aktif ve tamamlanan görevlerin görüntülenmesi
- Görev detayları ve istatistikleri
- Aktif ve pasif çağrı takibi
- Raporlama
- Yönetici ve personel giriş ekranları

### ASP.NET MVC Uygulaması

Firma çağrı süreçlerinin web üzerinden yönetilmesi amacıyla geliştirilen MVC uygulaması.

- Kullanıcı giriş sistemi
- Firma çağrı yönetimi
- Aktif ve pasif çağrı takibi
- Çağrı detayları
- Profil görüntüleme ve düzenleme
- Entity Framework Database First

## Kullanılan Teknolojiler

- C#
- .NET Framework 4.7.2
- Windows Forms
- ASP.NET MVC 5
- DevExpress
- Entity Framework 6.5.2
- SQL Server
- Bootstrap
- jQuery

## Veritabanı

Projelerde SQL Server ve Entity Framework kullanılmaktadır.

Gerçek veritabanı bağlantı bilgileri güvenlik nedeniyle repository'ye dahil edilmemiştir.

## Proje Yapısı

```text
is_takip_proje/
├── is_takip_proje/       # Windows Forms uygulaması
├── MvcFirmaCagri/        # ASP.NET MVC uygulaması
├── .gitignore
├── README.md
└── is_takip_proje.slnx
