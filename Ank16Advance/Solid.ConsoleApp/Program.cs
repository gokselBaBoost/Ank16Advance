// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Solid.ConsoleApp;

Console.WriteLine("Hello, World!");

#region SRP
//User user = new User();
//user.Name = "Göksel";
//user.Surname = "Kalyoncu";
//user.Email = "goksel.kalyoncu@mail.com";
//user.Username = "gkalyoncu";
//user.Password = "123456";

//MailValidator validator = new MailValidator();
//AccountService accountService = new AccountService(validator);

//accountService.Register(user); 
#endregion

#region OCP
//LogService logService = new LogService();
//logService.Log("Bu bir log", LogType.XmlLog);
//logService.Log("Bu bir log", LogType.TextLog);
//logService.Log("Bu bir log", LogType.DbLog);

//Console.WriteLine("------------");

//XmlLogger xmlLogger = new XmlLogger();
//TextLogger textLogger = new TextLogger();
//DbLogger dbLogger = new DbLogger();


//LoggerService loggerService = new LoggerService(dbLogger);
//loggerService.Log("Bu bir yeni log");
#endregion

#region LSP
//BasePrinter hpPrinter = new HpPrinter();
//BasePrinter epsonPrinter = new EpsonPrinter();

////HpPrinter hpPrinter = new HpPrinter();
////EpsonPrinter epsonPrinter = new EpsonPrinter();

//EpsonPrinter epsonPrinterWithScan = new EpsonPrinter();

//hpPrinter.Print("Mesaj ...");
//epsonPrinter.Print("Mesaj ...");

//epsonPrinterWithScan.Scan("Mesaj ..."); 
#endregion

#region ISP
//Aslan kirmiziAslan = new Aslan();
//Kanarya sariKanarya = new Kanarya();
//Hamsi bordoHamsi = new Hamsi();
//Kaz kazEti = new Kaz();

////IHayvan kirmiziAslan = new Aslan();
////IHayvan sariKanarya = new Kanarya();
////IHayvan bordoHamsi = new Hamsi();
////IHayvan kazEti = new Kaz();

//kirmiziAslan.Yuru();
//Console.WriteLine("----");
//sariKanarya.Yuru();
//sariKanarya.Uc();
//Console.WriteLine("----");
//bordoHamsi.Yuz();
//Console.WriteLine("----");
//kazEti.Yuz();
//kazEti.Yuru();
//kazEti.Uc(); 
#endregion


//ISekil kare = new Kare();
//ISekil daire = new Daire();

//Ekran ekran = new Ekran(kare);

//ekran.EkranYaz();
//ekran.EkranYaz();
//ekran.EkranYaz();

//Console.WriteLine("-----");

//ekran.EkranYazDIP(daire);
//ekran.EkranYazDIP(kare);
//ekran.EkranYazDIP(kare);
//ekran.EkranYazDIP(daire);

// DI IoC kullanımı 

var service = CreateService();

Application app = service.GetRequiredService<Application>();

/*
 * 1. new Application() => Ekran
 * 2. new Ekran() => ISekil
 * 3. ISekil => new Kare() 
 * 
 * 
 */

app.Run();
app.Ekran();

Console.ReadLine(); 


static ServiceProvider CreateService()
{
    var serviceProvider = new ServiceCollection()
                            .AddSingleton<ISekil, Daire>()
                            .AddSingleton<Ekran>()
                            .AddSingleton<Application>()
                            .BuildServiceProvider();

    return serviceProvider;
}

public class Application
{
    private Ekran _ekran;
    public Application(Ekran ekran)
    {
        _ekran = ekran;
        Console.WriteLine("Application: Beni de oluşturdunuz.");
    }

    public void Run()
    {
        Console.WriteLine("Ben DI Container tarafından çalıştırıldım");
    }

    public void Ekran()
    {
        _ekran.EkranYaz();
    }
}