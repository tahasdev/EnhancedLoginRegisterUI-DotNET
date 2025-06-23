# Proje Kurulum ve Çalıştırma Rehberi

Bu proje, XAMPP ve phpMyAdmin kullanılarak MySQL veritabanı üzerinde `loginregister` veritabanı ile çalışmaktadır.

---

## Gereksinimler

- [XAMPP](https://www.apachefriends.org/index.html) (Apache + MySQL + phpMyAdmin içeren paket)
- Proje dosyaları (özellikle `loginregister.sql` dosyası)

---

## Adım 1: XAMPP Kurulumu ve Başlatılması

1. XAMPP'i indirin ve kurun.
2. XAMPP Kontrol Panelini açın.
3. Apache ve MySQL servislerini başlatın.  
   - **Apache** ve **MySQL** servislerinin yanında "Running" ibaresi olmalıdır.

---

## Adım 2: Veritabanı Oluşturma

1. Tarayıcınızda `http://localhost/phpmyadmin` adresine gidin.
2. phpMyAdmin arayüzünde üst menüden **"Yeni"** (New) seçeneğine tıklayın.
3. **Veritabanı adı** alanına `loginregister` yazın.
4. Karakter seti olarak `utf8_general_ci` seçili olduğundan emin olun.
5. **Oluştur** (Create) butonuna tıklayın.

---

## Adım 3: SQL Dosyasını İçe Aktarma (Import)

1. Oluşturduğunuz `loginregister` veritabanına tıklayın.
2. Üst menüden **İçe Aktar** (Import) sekmesine gidin.
3. **Dosya seçin** butonuna basarak proje klasöründeki `database/loginregister.sql` dosyasını seçin.
4. Aşağıdaki ayarları kontrol edin:
   - Format: SQL
5. Sayfanın altında bulunan **Git** (Go) butonuna tıklayın.
6. İşlem başarılıysa, "Import has been successfully finished" gibi bir mesaj göreceksiniz.

---

## Adım 4: Projeyi Çalıştırma

projem.sln dosyasını Visual Studio ile açıp çalıştırın.
