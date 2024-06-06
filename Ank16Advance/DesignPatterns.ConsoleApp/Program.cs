using DesignPatterns.ConsoleApp.BehavioralDP;
using DesignPatterns.ConsoleApp.CreationalDP.Cor;
using DesignPatterns.ConsoleApp.StructrualDP;
using DesignPatterns.ConsoleApp.StructrualDP.Factory;

//Console.WriteLine("Hello, World!");

#region Singleton
////Database db1 = Database.GetInstance();
////Database db2 = Database.GetInstance();
////Database db3 = Database.GetInstance();
////Database db4 = Database.GetInstance();

////Console.WriteLine(db1.GetHashCode());
////Console.WriteLine(db2.GetHashCode());
////Console.WriteLine(db3.GetHashCode());
////Console.WriteLine(db4.GetHashCode());

//#region Thread Save
//Thread t1 = new Thread(Operation);
//t1.Start();


//Thread t2 = new Thread(Operation);
//t2.Start(); 
//void Operation()
//{
//    Database db1 = Database.GetInstance();
//    Database db2 = Database.GetInstance();
//    Database db3 = Database.GetInstance();
//    Database db4 = Database.GetInstance();

//    Console.WriteLine(db1.GetHashCode());
//    Console.WriteLine(db2.GetHashCode());
//    Console.WriteLine(db3.GetHashCode());
//    Console.WriteLine(db4.GetHashCode());
//}
//#endregion

#endregion

#region Factory
//ICar car = CarFactory.CreateCar("BMW", Color.Black, 3200);
//Mercedes m500 = (Mercedes)CarFactory.CreateCar("Mercedes", Color.Green, 5000);

//Console.WriteLine(car.ToString());
//Console.WriteLine(m500.ToString()); 
#endregion


#region Bridge
//Ucgen ucgen = new Ucgen();
//Kirmizi kirmizi = new Kirmizi();
//ucgen.Draw(kirmizi, 10);

//DrawBridge drawBridge = new DrawBridge(new Ucgen(), new Kirmizi(), 10);
//drawBridge.Draw();

//drawBridge = new DrawBridge(new Kare(), new Mavi(), 100);
//drawBridge.Draw(); 
#endregion

#region Chain of Responsibility

/*
 * Bir banka müşterisi x Miktar y hesabından z türünde para çekecek
 * 
 * 1. Banka Gişe Memurunun sınır 0 - 50.000 üst onaya ihtiyaç duymadan para verebilri. 50.000 < üstü Şube Yöneticisi
 * 2. Şube Yöneticisi sınır 50.001 - 100.000 üst onaya ihtiyaç duymadan para verebilri. 100.000 < üstü Şube Müdürü
 * 3. Şube Müdürü sınır 100.001 - 200.000 üst onaya ihtiyaç duymadan para verebilri. 200.000 < üstü Bölge Sorumlusu
 * 4. Bölge Sorumlusu sınır 200.001 - sonsuz üst onaya ihtiyaç duymadan para verebilri.
 */

//ParaCek paraCek = new ParaCek("abcd-1234-xyz", 358230, "TL", "TR20 0001 0000 4000 10 20");

//GiseMemuru giseMemuru = new GiseMemuru();
//SubeYoneticisi subeYoneticisi = new SubeYoneticisi();
//SubeMuduru subeMuduru = new SubeMuduru();
//BolgeSorumlusu bolgeSorumlusu = new BolgeSorumlusu();

//giseMemuru.SetUstCalisan(subeYoneticisi);
//subeYoneticisi.SetUstCalisan(subeMuduru);
//subeMuduru.SetUstCalisan(bolgeSorumlusu);

//giseMemuru.IslemYap(paraCek);

#endregion

Console.ReadLine();

