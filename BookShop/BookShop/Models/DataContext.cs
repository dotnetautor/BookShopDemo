using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace BookShop.Models {
  public class BookContext : DbContext {

    public BookContext() : this("BookDb") {
    }

    private BookContext(string conn )
      : base(nameOrConnectionString: conn) {
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Reader> Readers { get; set; }
    public DbSet<BookReader> BookReaders { get; set; }

    static BookContext() {
      Database.SetInitializer(new BookShopDatabaseInitializer());
    }

    // Alternativ zu der Verwendung von Attributen und Konventionen kann hier auch die Explizite 
    // fluent-Api verwendet werden

    ////protected override void OnModelCreating(DbModelBuilder modelBuilder) {
    ////  modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    ////  modelBuilder.Configurations.Add(new PersonConfiguration());

    ////  //base.OnModelCreating(modelBuilder);
    ////}
  }

  #region -= Initializer =-
#if CreateAlways
  public class BookShopDatabaseInitializer : DropCreateDatabaseAlways<BookContext> {
#else
  public class BookShopDatabaseInitializer : DropCreateDatabaseIfModelChanges<BookContext> {
#endif
    protected override void Seed(BookContext context) {

      var categories = new List<Category> {
        new Category { Title = "JavaScript"},
        new Category { Title = "ASP.NET"},
        new Category { Title = "Angular"},
      };

      #region -= People =-
      var people = new List<Reader> {

        new Reader {
          FirstName = "Sasha",
          LastName = "Hartman",
          Street = "P.O. Box 524, 9144 Risus. St.",
          City = "Bauchi",
          Plz = "825231"
        },
        new Reader {
          FirstName = "Helen",
          LastName = "Underwood",
          Street = "540-4254 Senectus Rd.",
          City = "Rock Springs",
          Plz = "96852"
        },
        new Reader {
          FirstName = "Nigel",
          LastName = "Stevens",
          Street = "8326 Ullamcorper, Road",
          City = "Montefalcone nel Sannio",
          Plz = "76263"
        },
        new Reader {
          FirstName = "Nigel",
          LastName = "Bell",
          Street = "3602 Vitae, Street",
          City = "Codognè",
          Plz = "T3H 7S4"
        },
        new Reader {
          FirstName = "Alexa",
          LastName = "Wall",
          Street = "565-3598 Senectus Street",
          City = "Frankfurt am Main",
          Plz = "8394"
        },
        new Reader {
          FirstName = "Whoopi",
          LastName = "Mckinney",
          Street = "306-222 Elit, St.",
          City = "Detroit",
          Plz = "59675-130"
        },
        new Reader {
          FirstName = "August",
          LastName = "Summers",
          Street = "6125 Suspendisse Rd.",
          City = "Whitehaven",
          Plz = "B2V 0M5"
        },
        new Reader {
          FirstName = "Meredith",
          LastName = "Padilla",
          Street = "Ap #543-5516 Ac Ave",
          City = "Cherbourg-Octeville",
          Plz = "16560"
        },
        new Reader {
          FirstName = "Wing",
          LastName = "Herring",
          Street = "Ap #181-6833 A, Avenue",
          City = "Baie-Saint-Paul",
          Plz = "71313"
        },
        new Reader {
          FirstName = "Mira",
          LastName = "Booker",
          Street = "409-9477 Et Ave",
          City = "Rosenheim",
          Plz = "14167-886"
        },
        new Reader {
          FirstName = "Heidi",
          LastName = "Roy",
          Street = "P.O. Box 737, 2478 Eu St.",
          City = "Grey County",
          Plz = "2112"
        },
        new Reader {
          FirstName = "Mufutau",
          LastName = "Nash",
          Street = "193-7173 Et, Rd.",
          City = "Campolieto",
          Plz = "70939"
        },
        new Reader {
          FirstName = "Bruno",
          LastName = "Byrd",
          Street = "5847 Gravida St.",
          City = "Albisola Superiore",
          Plz = "58003"
        },
        new Reader {
          FirstName = "Jaime",
          LastName = "Miranda",
          Street = "Ap #777-4051 Ullamcorper. Ave",
          City = "Tailles",
          Plz = "8062"
        },
        new Reader {
          FirstName = "Idona",
          LastName = "Brewer",
          Street = "P.O. Box 442, 6492 Ac Avenue",
          City = "Uberlândia",
          Plz = "7469"
        },
        new Reader {
          FirstName = "Chadwick",
          LastName = "Ross",
          Street = "4528 Sodales Av.",
          City = "Hull",
          Plz = "82659"
        },
        new Reader {
          FirstName = "Cheyenne",
          LastName = "Nguyen",
          Street = "P.O. Box 885, 936 Enim, Road",
          City = "Nieuwegein",
          Plz = "1401YB"
        },
        new Reader {
          FirstName = "Judith",
          LastName = "Levy",
          Street = "P.O. Box 848, 9845 Eget, Av.",
          City = "G�ttingen",
          Plz = "4833"
        },
        new Reader {
          FirstName = "Wendy",
          LastName = "Lang",
          Street = "P.O. Box 809, 1985 Amet, Road",
          City = "Comblain-Fairon",
          Plz = "7759"
        },
        new Reader {
          FirstName = "Imogene",
          LastName = "Tanner",
          Street = "Ap #382-4187 Amet Street",
          City = "Perth",
          Plz = "80891"
        },
        new Reader {
          FirstName = "Melanie",
          LastName = "Edwards",
          Street = "7301 Amet Road",
          City = "Sloten",
          Plz = "29309"
        },
        new Reader {
          FirstName = "Baker",
          LastName = "Williamson",
          Street = "928-9198 Molestie St.",
          City = "Bear",
          Plz = "05852"
        },
        new Reader {
          FirstName = "Timothy",
          LastName = "Sanders",
          Street = "583 Nascetur Road",
          City = "Galmaarden",
          Plz = "38-655"
        },
        new Reader {
          FirstName = "Keith",
          LastName = "Albert",
          Street = "265-2084 Orci. Rd.",
          City = "Kendal",
          Plz = "61420"
        },
        new Reader {
          FirstName = "Brielle",
          LastName = "Weaver",
          Street = "687-4035 Dolor St.",
          City = "Santo Stefano del Sole",
          Plz = "37958"
        },
        new Reader {
          FirstName = "Serina",
          LastName = "Daugherty",
          Street = "Ap #750-1084 Suspendisse Avenue",
          City = "Melbourne",
          Plz = "74724"
        },
        new Reader {
          FirstName = "Armando",
          LastName = "Duke",
          Street = "Ap #264-3702 Consequat Avenue",
          City = "Hinckley",
          Plz = "55322"
        },
        new Reader {
          FirstName = "Karleigh",
          LastName = "Goodwin",
          Street = "P.O. Box 715, 4025 Odio. Rd.",
          City = "Passau",
          Plz = "2792"
        },
        new Reader {
          FirstName = "Amal",
          LastName = "Vang",
          Street = "Ap #394-5206 Interdum. Avenue",
          City = "Solre-Saint-G�ry",
          Plz = "49761-467"
        },
        new Reader {
          FirstName = "Leila",
          LastName = "Wallace",
          Street = "Ap #841-5733 Quisque St.",
          City = "Fossato Serralta",
          Plz = "X2T 6G4"
        },
        new Reader {
          FirstName = "Shana",
          LastName = "Weaver",
          Street = "P.O. Box 433, 6794 Vestibulum St.",
          City = "Oderzo",
          Plz = "71236"
        },
        new Reader {
          FirstName = "Ocean",
          LastName = "Peck",
          Street = "958-6132 Ac Street",
          City = "Pastena",
          Plz = "9202"
        },
        new Reader {
          FirstName = "Demetria",
          LastName = "Quinn",
          Street = "Ap #477-4359 Donec Street",
          City = "Bridgeport",
          Plz = "00794"
        },
        new Reader {
          FirstName = "Aline",
          LastName = "Dotson",
          Street = "P.O. Box 188, 9439 Nunc Street",
          City = "Mundare",
          Plz = "299692"
        },
        new Reader {FirstName = "Georgia", LastName = "Gamble", Street = "8412 Et, St.", City = "Bharuch", Plz = "2770"},
        new Reader {
          FirstName = "Violet",
          LastName = "Robles",
          Street = "Ap #891-8824 Urna. Rd.",
          City = "Vollezele",
          Plz = "41404"
        },
        new Reader {
          FirstName = "Carl",
          LastName = "Moody",
          Street = "3198 Mauris Av.",
          City = "Jamshedpur",
          Plz = "81063-633"
        },
        new Reader {
          FirstName = "Ira",
          LastName = "Mullins",
          Street = "Ap #565-4587 Nec St.",
          City = "Gavorrano",
          Plz = "73735"
        },
        new Reader {FirstName = "Brendan", LastName = "Mason", Street = "3138 Eu Ave", City = "Thames", Plz = "5384"},
        new Reader {
          FirstName = "Kenyon",
          LastName = "Lawson",
          Street = "846-2395 Sed Street",
          City = "Alix",
          Plz = "4369"
        },
        new Reader {
          FirstName = "Ava",
          LastName = "Berger",
          Street = "6341 Ultricies Avenue",
          City = "Castres",
          Plz = "7838"
        },
        new Reader {
          FirstName = "Bradley",
          LastName = "Bowers",
          Street = "P.O. Box 361, 9767 Turpis St.",
          City = "Port Alice",
          Plz = "KE73 8GD"
        },
        new Reader {
          FirstName = "Walker",
          LastName = "Patton",
          Street = "408-339 Aliquam Av.",
          City = "Vorst",
          Plz = "21841"
        },
        new Reader {
          FirstName = "Beatrice",
          LastName = "Spears",
          Street = "9150 Quisque St.",
          City = "Villafranca Tirrena",
          Plz = "5949"
        },
        new Reader {
          FirstName = "Lucian",
          LastName = "Hines",
          Street = "Ap #937-2350 Ullamcorper Av.",
          City = "Tamines",
          Plz = "42281"
        },
        new Reader {
          FirstName = "Aretha",
          LastName = "Burris",
          Street = "Ap #177-7539 Nullam St.",
          City = "Bon Accord",
          Plz = "100053"
        },
        new Reader {
          FirstName = "Vladimir",
          LastName = "Weeks",
          Street = "P.O. Box 529, 3127 Magna Ave",
          City = "Caxias do Sul",
          Plz = "71291"
        },
        new Reader {
          FirstName = "Dominic",
          LastName = "Schmidt",
          Street = "P.O. Box 697, 3930 Metus. Ave",
          City = "Durg",
          Plz = "ZU3H 6QC"
        },
        new Reader {
          FirstName = "Lawrence",
          LastName = "Conrad",
          Street = "1693 Curabitur Ave",
          City = "Hamilton",
          Plz = "1750"
        },
        new Reader {
          FirstName = "Fallon",
          LastName = "Valentine",
          Street = "1574 Tincidunt, Ave",
          City = "Keswick",
          Plz = "446125"
        },
        new Reader {
          FirstName = "Quemby",
          LastName = "Moon",
          Street = "3657 Egestas St.",
          City = "Glabais",
          Plz = "79136"
        },
        new Reader {
          FirstName = "Whilemina",
          LastName = "Shepherd",
          Street = "7611 Vehicula Rd.",
          City = "Couillet",
          Plz = "46658"
        },
        new Reader {
          FirstName = "Patrick",
          LastName = "Morrison",
          Street = "9371 Varius Avenue",
          City = "Grey County",
          Plz = "18568"
        },
        new Reader {
          FirstName = "Victoria",
          LastName = "Noble",
          Street = "565-7484 Eu Ave",
          City = "Miranda",
          Plz = "699613"
        },
        new Reader {
          FirstName = "Jeremy",
          LastName = "Acevedo",
          Street = "P.O. Box 451, 6932 Laoreet St.",
          City = "Bergen",
          Plz = "31208"
        },
        new Reader {
          FirstName = "Jade",
          LastName = "Randolph",
          Street = "P.O. Box 937, 2239 Pede St.",
          City = "St. Johann in Tirol",
          Plz = "7823"
        },
        new Reader {
          FirstName = "Bradley",
          LastName = "Good",
          Street = "965-7317 A, St.",
          City = "San Damiano al Colle",
          Plz = "54204"
        },
        new Reader {
          FirstName = "Eric",
          LastName = "Guthrie",
          Street = "Ap #811-3200 Eu, St.",
          City = "Grandrieu",
          Plz = "4425"
        },
        new Reader {
          FirstName = "Fredericka",
          LastName = "Holloway",
          Street = "647-3780 Et Rd.",
          City = "Chastre",
          Plz = "3040HN"
        },
        new Reader {
          FirstName = "Courtney",
          LastName = "Cohen",
          Street = "5748 Aliquam Av.",
          City = "North Barrackpur",
          Plz = "12357"
        },
        new Reader {
          FirstName = "Sydnee",
          LastName = "Finley",
          Street = "Ap #212-5553 Molestie St.",
          City = "Pogliano Milanese",
          Plz = "818667"
        },
        new Reader {
          FirstName = "Patrick",
          LastName = "Sargent",
          Street = "9887 Risus. Road",
          City = "Lithgow",
          Plz = "7877"
        },
        new Reader {
          FirstName = "Destiny",
          LastName = "Summers",
          Street = "Ap #684-8509 Libero Ave",
          City = "Baili�vre",
          Plz = "30942"
        },
        new Reader {
          FirstName = "Candice",
          LastName = "Raymond",
          Street = "Ap #216-3759 Ante. Road",
          City = "Fallo",
          Plz = "47214"
        },
        new Reader {
          FirstName = "Patience",
          LastName = "Santana",
          Street = "P.O. Box 798, 3206 Vel St.",
          City = "Castello Tesino",
          Plz = "5682"
        },
        new Reader {
          FirstName = "Keely",
          LastName = "Wright",
          Street = "218-5723 Lectus Road",
          City = "Patiala",
          Plz = "9845LP"
        },
        new Reader {
          FirstName = "Jessamine",
          LastName = "Harris",
          Street = "P.O. Box 144, 5521 Nec Street",
          City = "Yellowhead County",
          Plz = "809179"
        },
        new Reader {
          FirstName = "Hedy",
          LastName = "Pittman",
          Street = "8211 Integer St.",
          City = "Philadelphia",
          Plz = "814457"
        },
        new Reader {
          FirstName = "Mason",
          LastName = "Oconnor",
          Street = "P.O. Box 821, 1176 Iaculis Road",
          City = "Montresta",
          Plz = "501470"
        },
        new Reader {
          FirstName = "Grady",
          LastName = "Spencer",
          Street = "P.O. Box 630, 506 Velit St.",
          City = "Porto Alegre",
          Plz = "44751"
        },
        new Reader {
          FirstName = "Charlotte",
          LastName = "Waller",
          Street = "443-4187 Fusce Avenue",
          City = "Birmingham",
          Plz = "0207"
        },
        new Reader {
          FirstName = "TaShya",
          LastName = "Barron",
          Street = "P.O. Box 367, 2547 Quis St.",
          City = "Paradise",
          Plz = "76816"
        },
        new Reader {
          FirstName = "Gemma",
          LastName = "Rich",
          Street = "Ap #758-327 Sodales Ave",
          City = "Caplan",
          Plz = "71974"
        },
        new Reader {
          FirstName = "Tara",
          LastName = "Cabrera",
          Street = "999-3954 Sollicitudin Av.",
          City = "Tregaron",
          Plz = "209464"
        },
        new Reader {
          FirstName = "Shoshana",
          LastName = "Huff",
          Street = "Ap #183-6393 Gravida Road",
          City = "Zaanstad",
          Plz = "MZ1 9GL"
        },
        new Reader {
          FirstName = "Miranda",
          LastName = "Todd",
          Street = "P.O. Box 315, 4701 Proin Road",
          City = "Idaho Falls",
          Plz = "9531"
        },
        new Reader {
          FirstName = "Isaiah",
          LastName = "Mcmillan",
          Street = "Ap #977-9052 Semper. Av.",
          City = "Poznań",
          Plz = "221660"
        },
        new Reader {
          FirstName = "Adara",
          LastName = "Velazquez",
          Street = "P.O. Box 311, 7964 Phasellus Street",
          City = "Dandenong",
          Plz = "56693"
        },
        new Reader {
          FirstName = "Maia",
          LastName = "Davis",
          Street = "1705 A, St.",
          City = "Kapelle-op-den-Bos",
          Plz = "8384"
        },
        new Reader {
          FirstName = "Melanie",
          LastName = "Schultz",
          Street = "P.O. Box 337, 6186 Dui, Ave",
          City = "Argyle",
          Plz = "534095"
        },
        new Reader {
          FirstName = "Kalia",
          LastName = "Mayo",
          Street = "P.O. Box 788, 1305 Vestibulum Avenue",
          City = "Markkleeberg",
          Plz = "6041AW"
        },
        new Reader {
          FirstName = "Ruth",
          LastName = "Mccormick",
          Street = "8390 Quis Rd.",
          City = "Noduwez",
          Plz = "C5S 5M7"
        },
        new Reader {
          FirstName = "Karleigh",
          LastName = "Parrish",
          Street = "6282 Sit Rd.",
          City = "Khammam",
          Plz = "VV84 1MQ"
        },
        new Reader {
          FirstName = "Nathaniel",
          LastName = "Odom",
          Street = "696-197 At, Rd.",
          City = "Mornimont",
          Plz = "4577"
        },
        new Reader {
          FirstName = "Ella",
          LastName = "Finley",
          Street = "Ap #827-363 Est Rd.",
          City = "Vaughan",
          Plz = "6767"
        },
        new Reader {FirstName = "Wing", LastName = "Weber", Street = "7421 Vitae St.", City = "Perth", Plz = "36495"},
        new Reader {
          FirstName = "Kibo",
          LastName = "Hicks",
          Street = "2463 At Av.",
          City = "Comblain-au-Pont",
          Plz = "735051"
        },
        new Reader {
          FirstName = "Melodie",
          LastName = "Shannon",
          Street = "Ap #106-1455 Leo Rd.",
          City = "Alcobendas",
          Plz = "9374"
        },
        new Reader {
          FirstName = "Abbot",
          LastName = "Holmes",
          Street = "2829 Nec Rd.",
          City = "Scarborough",
          Plz = "16-358"
        },
        new Reader {
          FirstName = "Matthew",
          LastName = "Morrow",
          Street = "476-4355 Ac Rd.",
          City = "Drancy",
          Plz = "5805"
        },
        new Reader {
          FirstName = "Rooney",
          LastName = "Evans",
          Street = "P.O. Box 708, 442 Fringilla Street",
          City = "Sonnino",
          Plz = "28161"
        },
        new Reader {
          FirstName = "Marshall",
          LastName = "Weber",
          Street = "Ap #770-8618 Aliquam Avenue",
          City = "Nellore",
          Plz = "10408"
        },
        new Reader {
          FirstName = "Cora",
          LastName = "Holmes",
          Street = "5350 Malesuada Avenue",
          City = "Moere",
          Plz = "HZ03 5DQ"
        },
        new Reader {
          FirstName = "Sydnee",
          LastName = "Rodriquez",
          Street = "522-132 Porttitor Ave",
          City = "Bischofshofen",
          Plz = "13655"
        },
        new Reader {
          FirstName = "Anthony",
          LastName = "Washington",
          Street = "977-1354 Gravida Ave",
          City = "Bothey",
          Plz = "2505"
        },
        new Reader {
          FirstName = "Heather",
          LastName = "Jacobson",
          Street = "P.O. Box 869, 2311 At Rd.",
          City = "Helkijn",
          Plz = "S4 7HE"
        },
        new Reader {
          FirstName = "Quail",
          LastName = "Eaton",
          Street = "169-2016 Ac Rd.",
          City = "Torre Cajetani",
          Plz = "C0S 1G9"
        },
        new Reader {
          FirstName = "Sylvester",
          LastName = "Campbell",
          Street = "P.O. Box 977, 6839 Sed St.",
          City = "Chicago",
          Plz = "2858"
        },
        new Reader {
          FirstName = "Portia",
          LastName = "Burke",
          Street = "530-9297 Erat, Road",
          City = "Dunkerque",
          Plz = "S6H 2C6"
        },
        new Reader {
          FirstName = "Rae",
          LastName = "Snyder",
          Street = "809-4745 Urna. Ave",
          City = "Itanagar",
          Plz = "41607"
        }
      };
      #endregion
      people.ForEach(r => context.Readers.Add(r));

      // need to create the IDs
      context.SaveChanges();
      #region -= Book =-

      var books = new List<Book> {
        new Book {
          Title = "JavaScript",
          SubTitle = "das umfassende Referenzwerk ; [behandelt Ajax und DOM-Scripting]",
          Category = categories[0]
        },
        new Book {Title = "JavaScript Essentials", SubTitle = "", Category = categories[0]},
        new Book {
          Title = "JavaScript",
          SubTitle = "das umfassende Referenzwerk ; [behandelt JavaScript 1.5]",
          Category = categories[0]
        },
        new Book {Title = "JavaScript", SubTitle = "Einstieg für Anspruchsvolle", Category = categories[0]},
        new Book {Title = "JavaScript", SubTitle = "Creating Dynamic Web Pages", Category = categories[0]},
        new Book {Title = "JavaScript: The Good Parts", SubTitle = "The Good Parts", Category = categories[0]},
        new Book {
          Title = "JavaScript: The Definitive Guide",
          SubTitle = "Activate Your Web Pages",
          Category = categories[0]
        },
        new Book {Title = "Professional JavaScript for Web Developers", SubTitle = "", Category = categories[0]},
        new Book {Title = "JavaScript: The Web Technologies Series", SubTitle = "", Category = categories[0]},
        new Book {Title = "Pro JavaScript Techniques", SubTitle = "", Category = categories[0]},
        // ------------------------------------------------------------------------------------------------------
        new Book {Title = "Programmieren mit ASP.NET AJAX", SubTitle = "", Category = categories[1]},
        new Book {
          Title = "ASP.NET 4.0 mit Visual Basic 2010",
          SubTitle =
            "leistungsfähige Webapplikationen programmieren ; [inklusive DVD-ROM mit Microsoft Visual Studio 2010 Express]",
          Category = categories[1]
        },
        new Book {
          Title = "ASP.NET-Programmierung mit VB.NET",
          SubTitle =
            "dynamische, datenbankgestützte Webseiten mit .NET entwickeln ; [zeigt Integration von XML in.NET ; Datenbankzugriff mit ADO.NET und Transact-SQL]",
          Category = categories[1]
        },
        new Book {Title = "ASP.NET for Web Designers", SubTitle = "", Category = categories[1]},
        new Book {
          Title = "ASP.NET JQuery Cookbook",
          SubTitle = "Over 60 Practical Recipes for Integrating JQuery with ASP.NET",
          Category = categories[1]
        },
        new Book {
          Title = "ASP.NET Site Performance Secrets",
          SubTitle = "Simple and Proven Techniques to Quickly Speed Up Your ASP.NET Web Site",
          Category = categories[1]
        },
        new Book {Title = "Pro ASP.NET 4 in C# 2010", SubTitle = "", Category = categories[1]},
        new Book {Title = "Jetzt lerne ich ASP.NET", SubTitle = "", Category = categories[1]},
        new Book {Title = "ASP. Net 3. 5 CMs Development", SubTitle = "", Category = categories[1]},
        new Book {Title = "ASP.NET 2.0 Cookbook", SubTitle = "", Category = categories[1]},
        // ------------------------------------------------------------------------------------------------------
        new Book {Title = "Optical Angular Momentum", SubTitle = "", Category = categories[2]},
        new Book {Title = "Angular Momentum in Quantum Mechanics", SubTitle = "", Category = categories[2]},
        new Book {Title = "A Companion to Angular Momentum", SubTitle = "", Category = categories[2]},
        new Book {
          Title = "Angular momentum",
          SubTitle = "understanding spatial aspects in chemistry and physics",
          Category = categories[2]
        },
        new Book {Title = "Angular Momentum Techniques in Quantum Mechanics", SubTitle = "", Category = categories[2]},
        new Book {Title = "The Angular Momentum of Light", SubTitle = "", Category = categories[2]},
        new Book {Title = "Fundamentals of Biomechanics", SubTitle = "", Category = categories[2]},
        new Book {Title = "The Basics of Physics", SubTitle = "", Category = categories[2]},
        new Book {
          Title = "Quantum Theory of Angular Momentum",
          SubTitle = "Irreducible Tensors, Spherical Harmonics, Vector Coupling Coefficients, 3nj Symbols",
          Category = categories[2]
        },
        new Book {Title = "Angular Momentum", SubTitle = "", Category = categories[2]},

      };
      #endregion

      books.ForEach(b => context.Books.Add(b));

      var rnd = new Random();
      people.ForEach(p => {
        var cnt = rnd.Next(3);
        for (int i = 0; i < cnt; i++) {
          context.BookReaders.Add(new BookReader {Book = books[rnd.Next(books.Count - 1)], Reader = p});
        }
      });
 
      new List<BookReader> {
        new BookReader {Book = books[0], Reader = people[0]},
        new BookReader {Book = books[1], Reader = people[1]},
        new BookReader {Book = books[2], Reader = people[0]},
        new BookReader {Book = books[2], Reader = people[1]},
      }.ForEach(br => context.BookReaders.Add(br));
     

      //context.SaveChanges();
    }
  }
  #endregion
}
