using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BasketTable",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductFeatures = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<double>(type: "float", nullable: false),
                    ProductStar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketTable", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ProductTable",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductFeatures = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<double>(type: "float", nullable: false),
                    ProductStar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTable", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "BasketTable",
                columns: new[] { "ProductId", "ProductCategory", "ProductFeatures", "ProductImgUrl", "ProductName", "ProductPrice", "ProductStar" },
                values: new object[] { 22, "Spor", "Vites:24 Vites ,  Bisiklet Tipi:Dağ Bisikleti , Kadro Malzemesi:Alüminyum Ağırlık 14,6 kg ,  Fren Tipi:Hidrolik Disk Fren , Jant:29 inç, Kadro Boyu:18 inç - 46 cm ,Ön Amortisör :Kilitli Amortisör", "https://productimages.hepsiburada.net/s/55/550/11212783550514.jpg/format:webp", "Dağ Bisikleti", 18000.0, 10 });

            migrationBuilder.InsertData(
                table: "ProductTable",
                columns: new[] { "ProductId", "ProductCategory", "ProductFeatures", "ProductImgUrl", "ProductName", "ProductPrice", "ProductStar" },
                values: new object[,]
                {
                    { 1, "Teknoloji", "Intel Core i7 12650H 16GB 512GB SSD RTX3050 Freedos 15.6\" FHD 144Hz ", "https://productimages.hepsiburada.net/s/448/550/110000481950429.jpg/format:webp", "MSI THIN GF63 12UC-666XTR", 30999.0, 9 },
                    { 2, "Teknoloji", "Bluetooth Versiyon5.0, Çift Telefon Desteği Yok, Suya & Tere DayanıklıHayırAktif Gürültü Önleme (ANC)Yok, Kullanım TipiKulakiçi ", "https://productimages.hepsiburada.net/s/430/222-222/110000462400807.jpg/format:webp", "Apple AirPods 2. Nesil Kulaklık", 3199.0, 9 },
                    { 3, "Teknoloji", "İşletim Sistemi Tabanı Android, Ekran Modeli TFT,Ram Kapasitesi 4 GB,Ekran Boyutu 12,4 inç, Max Ekran Çözünürlüğü 2560 x 1600,Mobil BağlantıYok ", "https://productimages.hepsiburada.net/s/127/550/110000077439199.jpg/format:webp", "Samsung Galaxy Tab S7 FE ", 10719.0, 9 },
                    { 4, "Teknoloji", "Intel Core i3 1215U 8GB 256GB SSD Freedos 15.6", "https://productimages.hepsiburada.net/s/472/550/110000515070461.jpg/format:webp", "Asus Vivobook 15 ", 11999.0, 8 },
                    { 5, "Teknoloji", "Suya & Tere Dayanıklı Hayır ,Aktif Gürültü Önleme (ANC) Yok, Kullanım Tipi Kulaküstü ,Çift Telefon Desteği Var, Bluetooth Versiyon 5.3, ", "https://productimages.hepsiburada.net/s/406/222-222/110000434230608.jpg/format:webp", "Jbl Tune 520BT ", 1419.0, 6 },
                    { 6, "Teknoloji", "İşletim Sistemi Tabanı Android,Dahili Hafıza64 GB,Tablet İşlemci Qualcomm Snapdragon 439, Kamera Çift Kamera ,Mobil Bağlantı Yok ,Wi-Fi Var, Ekran Modeli IPS Ekran, Ram Kapasitesi 4GB , Ekran Boyutu 10,1 inç, Max Ekran Çözünürlüğü 1920 x 1200 ,", "https://productimages.hepsiburada.net/s/39/550/10641362518066.jpg/format:webp", "Lenovo Yoga Smart TAB TB-X705F ", 14999.0, 7 },
                    { 7, "Teknoloji", " Ergonomik tasarım kolay izleme ve yazma, boyun, omuz ve omurga ağrısını yaşamamanız için kullanışlıdır. Dizüstü bilgisayar ve tablet standı 7 kademeli ayarlanabilir yükseklik sağlar, gerçek ihtiyacınıza göre rahat çalışma açısı ve yüksekliğine ayarlayın ", "https://productimages.hepsiburada.net/s/456/550/110000492217118.jpg/format:webp", "Laptop Tablet Standı ", 330.0, 9 },
                    { 8, "Teknoloji", " Intel Core I7 11800H 32GB 1 TB SSD RTX3050TI Freedos 17.3 ", "https://productimages.hepsiburada.net/s/444/550/110000478561734.jpg/format:webp", "Monster Abra A7 V13.3.4", 29999.0, 8 },
                    { 9, "Teknoloji", "Asus TUF GAMING M3 Aura SYNC RGB 7000DPI  ", "https://productimages.hepsiburada.net/s/34/550/10447701934130.jpg/format:webp", "Oyuncu Mouse", 399.0, 8 },
                    { 10, "Teknoloji", "Aydınlatma Var , Mouse Formu Sağ, El Mouse Tipi Optik Mouse , Scroll-Tilt Yok,RGB Var, BağlantıKablolu ", "https://productimages.hepsiburada.net/s/44/550/10799730393138.jpg/format:webp", "Gaming Mouse", 3512.0, 10 },
                    { 11, "Moda", " Cinsiyet: Erkek ,Yaka Stili : Bisiklet Yaka  ,Desen:Düz Renk ,Kol Boyu:Truvakar Kol", "https://productimages.hepsiburada.net/s/440/550/110000474281671.jpg/format:webp", "U.S. Polo Assn. Erkek Antrasit Melanj Sweatshirt ", 849.0, 8 },
                    { 12, "Moda", "AC&Co / Altınyıldız Classics Rüzgar Geçirmez Taşınabilir Çantalı Sıcak Tutan Hafif Standart Fit Elyaf Dolgulu Şişme Erkek Mont ", "https://productimages.hepsiburada.net/s/483/550/110000528454412.jpg/format:webp", "Altınyıldız  Erkek Mont", 1999.0, 9 },
                    { 13, "Moda", "U.s. Polo Assn. Erkek Siyah Kanvas / Chino Pantolon 50275532-VR046 ", "https://productimages.hepsiburada.net/s/475/550/110000517846540.jpg/format:webp", "Erkek Siyah Kanvas / Chino Pantolo", 750.0, 10 },
                    { 14, "Moda", " Cinsiyet:Kadın Garanti Süresi (Ay) :12", "https://productimages.hepsiburada.net/s/452/550/110000487051994.jpg/format:webp", "U.S. Polo Assn. Kadın Lacivert Örme Elbise", 1800.0, 7 },
                    { 15, "Moda", " Cinsiyet:Kadın  ,Renk:Kırmızı ,Topuk Boyu:Yüksek ,Topuk Tipi:Stiletto", "https://productimages.hepsiburada.net/s/477/550/110000519939012.jpg/format:webp", "Desa Grace Kırmızı Kadın Stiletto Topuklu Ayakkabı", 1860.0, 8 },
                    { 16, "Moda", "Incı Wınston 3pr Siyah Erkek Klasik Ayakkabı 42 Numara ", "https://productimages.hepsiburada.net/s/438/550/110000471317764.jpg/format:webp", "Incı Wınston 3pr Siyah Erkek Klasik Ayakkabı", 1099.0, 9 },
                    { 17, "Aksesuar", "Paradise Work 3'lü Yılbaşı Biblo Seti Noelbaba Kardanadam Penguen ", "https://productimages.hepsiburada.net/s/482/550/110000527547160.jpg/format:webp", "Yılbaşı Biblo Seti", 178.0, 9 },
                    { 18, "Ev", "KİLİM MOBİLYA DOME KANEPE; MİNİMAL BİR ÇİZGİ TANIDIK BİR GÖRÜNÜM; OVAL FORMLAR; Kol kısmında kullanılan oval formlar Dome Kanepe’ye sevimli bir görüntü kazandırırken aynı zamanda yumuşak görünümlü kol yapısıyla kullanım rahatlığı da sağlar.; İ ", "https://productimages.hepsiburada.net/s/338/550/110000344102191.jpg/format:webp", "Kilim Mobilya Dome Üç Kişilik Kanepe", 5600.0, 10 },
                    { 19, "Ciltbakım", "Cildin yenilenme hızını artırır, leke ve izlerin daha çabuk iyileşmesini sağlar,Cildin daha sıkı ve pürüzsüz görünmesine yardımcı olur,Cilde nem, parlaklık ve elastikiyet katar,Yaşlanma belirtilerini hafifletir.", "https://productimages.hepsiburada.net/s/469/550/110000509693214.jpg/format:webp", "Serum Extra Yaşlanma Karşıtı ", 560.0, 10 },
                    { 20, "Spor", "Vites:24 Vites ,  Bisiklet Tipi:Dağ Bisikleti , Kadro Malzemesi:Alüminyum Ağırlık 14,6 kg ,  Fren Tipi:Hidrolik Disk Fren , Jant:29 inç, Kadro Boyu:18 inç - 46 cm ,Ön Amortisör :Kilitli Amortisör", "https://productimages.hepsiburada.net/s/55/550/11212783550514.jpg/format:webp", " Dağ Bisikleti ", 18000.0, 10 },
                    { 21, "Beyaz Eşya", "Genişlik (cm):60 , Yükseklik (cm):85 , Derinlik (cm): 55 , Kurutmalı: Hayır,Maksimum Devir Hızı:1200 Yıkama Kapasitesi:9 kg", "https://productimages.hepsiburada.net/s/76/550/110000017561925.jpg/format:webp", " Samsung  Çamaşır Makinesi ", 12000.0, 8 },
                    { 23, "Aksesuar", "Şans Bilekliği, Garanti Süresi: 1 Ay, Renk: Kırmızı, Kullanıcı Cinsiyeti: Unisex", "https://productimages.hepsiburada.net/s/86/550/110000028825785.jpg/format:webp", " Bileklik ", 50.0, 8 },
                    { 24, "Aksesuar", "Kolye, Garanti Süresi: 1 Ay, Renk: Kırmızı, Kullanıcı Cinsiyeti: Kadın, Kolye Ucu 925 Ayar Gümüş Kaplama üzeri Rose Kaplama", "https://productimages.hepsiburada.net/s/348/550/110000356146538.jpg/format:webp", " Kolye ", 200.0, 9 },
                    { 25, "Aksesuar", "Küpe, Garanti Süresi: 3 Ay, Renk: Siyah ve Gümüş, Kullanıcı Cinsiyeti: Kadın, ÜRÜN BOYUTU : HALKA : 8 MM ; FİGÜRLÜ KÜPE : 3 CM ; ZİRKON TAŞ : 4 MM", "https://productimages.hepsiburada.net/s/445/550/110000479147634.jpg/format:webp", " Küpe ", 200.0, 9 },
                    { 26, "Ev", "Üçlü Kanepe, Küçük kırlentlerde dolgu olarak silikon elyaf ve kırpıntı sünger karışımı kullanılmıştır.", "https://productimages.hepsiburada.net/s/171/550/110000134001181.jpg/format:webp", " Koltuk ", 10000.0, 7 },
                    { 27, "Ev", "Renk: Bej, İplik Cinsi (Micro Polyester), Hav Yüksekliği (8 mm), Halı Kalınlığı (12 mm), M2 Ağırlığı (2200 gr/m2), İlme Sayısı (400.000)", "https://productimages.hepsiburada.net/s/351/550/110000360212172.jpg/format:webp", " Halı ", 980.0, 9 },
                    { 28, "Ev", "Tül Perde, Taç Ekru Düz Tül 200 x 260 cm, Pilesiz düz dikimdir. Ekstrafordaki iplikler çekilerek istenildiği şekilde pile ayarı yapılabilir.", "https://productimages.hepsiburada.net/s/37/550/10544399286322.jpg/format:webp", " Perde ", 160.0, 6 },
                    { 29, "Ciltbakım", "C Vitamini, Parlaklaştırır, Gençleştirir, Lekeleri geçirir, Sabah akşam 1 kere temiz yüze uygulanır.", "https://productimages.hepsiburada.net/s/352/550/110000360596295.jpg/format:webp", " Serum ", 400.0, 8 },
                    { 30, "Ciltbakım", "Nemlendirici Bakım Maskesi, Haftada 2 kere temiz yüze ince bir katman halinde uygulanır. Cildi aydınlatır.", "https://productimages.hepsiburada.net/s/519/550/110000575513892.jpg/format:webp", " Maske ", 250.0, 10 },
                    { 31, "Ciltbakım", "Üçü bir arada yüz maskesi. Temizleme-Peeling-Maske Aynı anda", "https://www.hepsiburada.com/garnier-saf-temiz-peeling-3-u-1-arada-temizleme-maske-150-ml-p-SGGNRGARST3B?magaza=L%27Or%C3%A9al", " Maske ", 90.0, 1 },
                    { 32, "Spor", "Normal kalıp, Bağcıklı tasarım, Kumaş saya, Cloudfoam orta taban, Kumaş astar.", "https://productimages.hepsiburada.net/s/395/600-800/110000419759509.jpg/format:webp", " Ayakkabı ", 1450.0, 8 },
                    { 33, "Spor", "6 KG Dambıl Ağırlık Seti, 2 Adet 3 KG Dambıldan oluşur, Ürünlerimiz üretimden tarafınıza doğrudan sevk edilmektedir.", "https://productimages.hepsiburada.net/s/433/550/110000466185977.jpg/format:webp", " Ağırlık/Dambıl ", 200.0, 9 },
                    { 34, "Spor", "Motor Gücü: 4,25 hp: Eğim Var, Nabız Ölçme Sistemi: Var, Katlanabilme:Var", "https://productimages.hepsiburada.net/s/424/550/110000455324829.jpg/format:webp", " Yürüyüş Bandı ", 45000.0, 10 },
                    { 35, "Beyaz Eşya", "Yeni Philips Azur 8000 Serisi ile güçlü ütüleme. 260 g turbo buharla en inatçı kırışıklıkları bile tek seferde yok edebilirsiniz.", "https://productimages.hepsiburada.net/s/308/550/110000300858424.jpg/format:webp", " Ütü ", 0.0, 5 },
                    { 36, "Beyaz Eşya", "Ekran TipiLED Ekran, Özellik 1: Isı Pompalı, Özellik 2: 10 Kg Kurutma Kapasitesi, Özellik 3: Özel Karıştırıcı ve Çift Filtre", "https://productimages.hepsiburada.net/s/495/550/110000546072760.jpg/format:webp", " Kurutma Makinesi ", 22000.0, 8 },
                    { 37, "Beyaz Eşya", "Bosch SMS4IKI51T 5 Programlı Bulaşık Makinesi, 13L iç kapasite, A++ Enerji Tasarrufu", "https://productimages.hepsiburada.net/s/261/550/110000245316455.jpg/format:webp", " Bulaşık Makinesi ", 16700.0, 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketTable");

            migrationBuilder.DropTable(
                name: "ProductTable");
        }
    }
}
