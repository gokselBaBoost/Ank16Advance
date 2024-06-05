using DesignPatterns.ConsoleApp;

Console.WriteLine("Hello, World!");

Thread t1 = new Thread(Operation);
t1.Start();


Thread t2 = new Thread(Operation);
t2.Start();

Console.ReadLine();

void Operation()
{
    Database db1 = Database.GetInstance();
    Database db2 = Database.GetInstance();
    Database db3 = Database.GetInstance();
    Database db4 = Database.GetInstance();

    Console.WriteLine(db1.GetHashCode());
    Console.WriteLine(db2.GetHashCode());
    Console.WriteLine(db3.GetHashCode());
    Console.WriteLine(db4.GetHashCode());
}

