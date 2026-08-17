# İş Takip Projesi

C# Windows Forms App (.NET Framework) kullanılarak, DevExpress arayüz bileşenleri ve SQL Server veritabanı ile geliştirilmiş iş takip uygulaması.

## Özellikler

- Departman yönetimi
- Personel yönetimi
- Firma yönetimi
- Görev oluşturma ve takip
- Aktif ve tamamlanan görevlerin görüntülenmesi
- Görev detaylarının görüntülenmesi
- Görev istatistikleri
- Aktif ve pasif çağrı takibi
- Personel istatistikleri
- Raporlama
- Yönetici ve personel giriş ekranları
- DevExpress Ribbon ve MDI arayüz yapısı

## Kullanılan Teknolojiler

- C#
- Windows Forms
- .NET Framework 4.7.2
- DevExpress
- Entity Framework 6.5.2
- SQL Server

## Veritabanı

Proje, Entity Framework kullanılarak SQL Server veritabanı ile çalışmaktadır.

Entity Framework modeli içerisinde yönetici, personel, departman, firma, görev ve çağrı verileri için entity'ler bulunmaktadır.

## Kurulum

1. Projeyi klonlayın.
2. `is_takip_proje.slnx` dosyasını Visual Studio ile açın.
3. Entity Framework 6.5.2 ve gerekli DevExpress bileşenlerinin kurulu olduğundan emin olun.
4. `App.config.example` dosyasını `App.config` olarak kopyalayın.
5. SQL Server bağlantı bilgilerini kendi sisteminize göre düzenleyin.
6. Projeyi derleyip çalıştırın.
