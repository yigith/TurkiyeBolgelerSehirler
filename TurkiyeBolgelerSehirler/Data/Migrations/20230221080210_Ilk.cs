using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TurkiyeBolgelerSehirler.Data.Migrations
{
    public partial class Ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bolgeler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolgeAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolgeler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sehirler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolgeId = table.Column<int>(type: "int", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SehirAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Nufus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehirler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sehirler_Bolgeler_BolgeId",
                        column: x => x.BolgeId,
                        principalTable: "Bolgeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bolgeler",
                columns: new[] { "Id", "BolgeAd", "Slug" },
                values: new object[,]
                {
                    { 1, "Akdeniz Bölgesi", "akdeniz-bolgesi" },
                    { 2, "Doğu Anadolu Bölgesi", "dogu-anadolu-bolgesi" },
                    { 3, "Ege Bölgesi", "ege-bolgesi" },
                    { 4, "Güneydoğu Anadolu Bölgesi", "guneydogu-anadolu-bolgesi" },
                    { 5, "İç Anadolu Bölgesi", "ic-anadolu-bolgesi" },
                    { 6, "Karadeniz Bölgesi", "karadeniz-bolgesi" },
                    { 7, "Marmara Bölgesi", "marmara-bolgesi" }
                });

            migrationBuilder.InsertData(
                table: "Sehirler",
                columns: new[] { "Id", "BolgeId", "Nufus", "SehirAd", "Slug" },
                values: new object[,]
                {
                    { 1, 1, 2201670, "Adana", "adana" },
                    { 2, 4, 610484, "Adıyaman", "adiyaman" },
                    { 3, 3, 714523, "Afyonkarahisar", "afyonkarahisar" },
                    { 4, 2, 542255, "Ağrı", "agri" },
                    { 5, 6, 326351, "Amasya", "amasya" },
                    { 6, 5, 5346518, "Ankara", "ankara" },
                    { 7, 1, 2328555, "Antalya", "antalya" },
                    { 8, 6, 168068, "Artvin", "artvin" },
                    { 9, 3, 1068260, "Aydın", "aydin" },
                    { 10, 7, 1196176, "Balıkesir", "balikesir" },
                    { 11, 7, 218297, "Bilecik", "bilecik" },
                    { 12, 2, 269560, "Bingöl", "bingol" },
                    { 13, 2, 341225, "Bitlis", "bitlis" },
                    { 14, 6, 299896, "Bolu", "bolu" },
                    { 15, 1, 261401, "Burdur", "burdur" },
                    { 16, 7, 2901396, "Bursa", "bursa" },
                    { 17, 7, 519793, "Çanakkale", "canakkale" },
                    { 18, 5, 183880, "Çankırı", "cankiri" },
                    { 19, 6, 527863, "Çorum", "corum" },
                    { 20, 3, 1005687, "Denizli", "denizli" },
                    { 21, 4, 1673119, "Diyarbakır", "diyarbakir" },
                    { 22, 7, 401701, "Edirne", "edirne" },
                    { 23, 2, 578789, "Elazığ", "elazig" },
                    { 24, 2, 226032, "Erzincan", "erzincan" },
                    { 25, 2, 762021, "Erzurum", "erzurum" },
                    { 26, 5, 844842, "Eskişehir", "eskisehir" },
                    { 27, 4, 1974244, "Gaziantep", "gaziantep" },
                    { 28, 6, 444467, "Giresun", "giresun" },
                    { 29, 6, 172034, "Gümüşhane", "gumushane" },
                    { 30, 2, 267813, "Hakkari", "hakkari" },
                    { 31, 1, 1555165, "Hatay", "hatay" },
                    { 32, 1, 427324, "Isparta", "isparta" },
                    { 33, 1, 1773852, "Mersin", "mersin" },
                    { 34, 7, 14804116, "İstanbul", "istanbul" },
                    { 35, 3, 4223545, "İzmir", "izmir" },
                    { 36, 2, 289786, "Kars", "kars" },
                    { 37, 6, 376945, "Kastamonu", "kastamonu" },
                    { 38, 5, 1358980, "Kayseri", "kayseri" },
                    { 39, 7, 351684, "Kırklareli", "kirklareli" },
                    { 40, 5, 229975, "Kırşehir", "kirsehir" },
                    { 41, 7, 1830772, "Kocaeli", "kocaeli" },
                    { 42, 5, 2161303, "Konya", "konya" }
                });

            migrationBuilder.InsertData(
                table: "Sehirler",
                columns: new[] { "Id", "BolgeId", "Nufus", "SehirAd", "Slug" },
                values: new object[,]
                {
                    { 43, 3, 573642, "Kütahya", "kutahya" },
                    { 44, 2, 781305, "Malatya", "malatya" },
                    { 45, 3, 1396945, "Manisa", "manisa" },
                    { 46, 1, 1112634, "Kahramanmaraş", "kahramanmaras" },
                    { 47, 4, 796237, "Mardin", "mardin" },
                    { 48, 3, 923773, "Muğla", "mugla" },
                    { 49, 2, 406501, "Muş", "mus" },
                    { 50, 5, 290895, "Nevşehir", "nevsehir" },
                    { 51, 5, 351468, "Niğde", "nigde" },
                    { 52, 6, 750588, "Ordu", "ordu" },
                    { 53, 6, 331048, "Rize", "rize" },
                    { 54, 7, 976948, "Sakarya", "sakarya" },
                    { 55, 6, 1295927, "Samsun", "samsun" },
                    { 56, 4, 322664, "Siirt", "siirt" },
                    { 57, 6, 205478, "Sinop", "sinop" },
                    { 58, 5, 621224, "Sivas", "sivas" },
                    { 59, 7, 972875, "Tekirdağ", "tekirdag" },
                    { 60, 6, 602662, "Tokat", "tokat" },
                    { 61, 6, 779379, "Trabzon", "trabzon" },
                    { 62, 2, 82193, "Tunceli", "tunceli" },
                    { 63, 4, 1940627, "Şanlıurfa", "sanliurfa" },
                    { 64, 3, 358736, "Uşak", "usak" },
                    { 65, 2, 1100190, "Van", "van" },
                    { 66, 5, 421041, "Yozgat", "yozgat" },
                    { 67, 6, 597524, "Zonguldak", "zonguldak" },
                    { 68, 5, 396673, "Aksaray", "aksaray" },
                    { 69, 6, 90154, "Bayburt", "bayburt" },
                    { 70, 5, 245610, "Karaman", "karaman" },
                    { 71, 5, 277984, "Kırıkkale", "kirikkale" },
                    { 72, 4, 576899, "Batman", "batman" },
                    { 73, 4, 483788, "Şırnak", "sirnak" },
                    { 74, 6, 192389, "Bartın", "bartin" },
                    { 75, 2, 98335, "Ardahan", "ardahan" },
                    { 76, 2, 192785, "Iğdır", "igdir" },
                    { 77, 7, 241665, "Yalova", "yalova" },
                    { 78, 6, 242347, "Karabük", "karabuk" },
                    { 79, 4, 130825, "Kilis", "kilis" },
                    { 80, 1, 522175, "Osmaniye", "osmaniye" },
                    { 81, 6, 370371, "Düzce", "duzce" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sehirler_BolgeId",
                table: "Sehirler",
                column: "BolgeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sehirler");

            migrationBuilder.DropTable(
                name: "Bolgeler");
        }
    }
}
