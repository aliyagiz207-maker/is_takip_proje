# İş Takip Projesi

C# ve .NET Framework kullanılarak geliştirilen, SQL Server ve Entity Framework tabanlı iş takip ve yönetim uygulaması.

## Kullanılan Teknolojiler

- C#
- Windows Forms
- ASP.NET MVC
- .NET Framework 4.7.2
- DevExpress
- Entity Framework 6.5.2
- SQL Server
- Bootstrap
- jQuery

## Proje İçeriği

### Windows Forms Uygulaması
- Departman yönetimi
- Personel yönetimi
- Firma yönetimi
- Görev oluşturma ve takip
- Aktif ve tamamlanan görevlerin görüntülenmesi
- Görev detayları ve istatistikleri
- Aktif ve pasif çağrı takibi
- Departman, personel ve firma istatistikleri
- Raporlama
- Yönetici ve personel giriş ekranları
- DevExpress tabanlı kullanıcı arayüzü

### ASP.NET MVC Uygulaması
- Firma çağrı yönetimi
- Aktif ve pasif çağrı takibi
- Çağrı detayları ve kayıt işlemleri
- Kullanıcı giriş sistemi
- Firma profili ve profil düzenleme
- Entity Framework Database First
- SQL Server veritabanı entegrasyonu

## Veritabanı

Proje SQL Server kullanmaktadır. Entity Framework Database First yaklaşımıyla veritabanı modelleri oluşturulmuştur.

> Güvenlik nedeniyle gerçek SQL Server bağlantı bilgileri projeye dahil edilmemiştir. Veritabanı bağlantısı için `App.config.example` dosyası örnek olarak sunulmuştur.

## Proje Yapısı

```text
is_takip_proje/
├── is_takip_proje/       # Windows Forms uygulaması
├── MvcFirmaCagri/        # ASP.NET MVC uygulaması
├── .gitignore
└── README.md
