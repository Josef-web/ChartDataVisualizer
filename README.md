# 📊 **Chart Data Visualizer**

Chart Data Visualizer, veritabanındaki verilerden **line**, **bar**, **radar** ve **diğer türdeki grafikler** oluşturan bir **web uygulamasıdır**. Bu proje, modern web teknolojilerini kullanarak görsel, etkileşimli ve veri odaklı bir kullanıcı deneyimi sunar.

> 🔥 **Kullanılan Teknolojiler:**  
- **ASP.NET Core 8** (Backend API)  
- **Entity Framework Core** (Veritabanı Erişimi)  
- **Serilog** (Loglama)  
- **Chart.js** (Grafik Çizim Kütüphanesi)  
- **JQuery** (AJAX İstekleri)  
- **Bootstrap 5** (Responsive Tasarım)  

---

## 🚀 **Özellikler**
- 🟢 **Veritabanındaki verilerle dinamik grafik oluşturma**: Kullanıcılar, verileri dinamik olarak veritabanından çeker ve bu verilerle grafik oluşturur.
- 🟢 **Desteklenen Grafik Türleri**: **Line (Çizgi), Bar (Çubuk), Radar, Doughnut (Donut), Pie (Pasta), Polar Area**.
- 🟢 **Farklı renkler ile verileri ayırt edici hale getirme**: Her bir veri için **farklı bir renk atanır**.
- 🟢 **Dinamik URL Algılama**: **window.location.host** kullanılarak port değişikliklerinde API URL'sini dinamik olarak ayarlar.
- 🟢 **Loglama**: **Serilog** sayesinde **hatalar, bilgiler ve uyarılar** log.txt dosyasına kaydedilir.
- 🟢 **Gelişmiş CORS yapılandırması**: İstemciden (index.html) API'ye erişim güvenli bir şekilde sağlanır.
- 🟢 **Responsive UI**: **Bootstrap** ile mobil, tablet ve masaüstü cihazlarda mükemmel kullanıcı deneyimi sunar.

---

## 📦 **Gereksinimler**
- **.NET 8.0 SDK** (Proje için)
- **SQL Server** (Veritabanı)
- **Rider / Visual Studio** (IDE)
- **Web Tarayıcı (Chrome, Firefox, Edge)**

---

## 📜 **Kurulum**
### 1️⃣ **Bu projeyi klonlayın**
```bash
git clone https://github.com/username/ChartDataVisualizer.git
cd ChartDataVisualizer
