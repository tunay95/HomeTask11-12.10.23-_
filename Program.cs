namespace HomeTask11_12._10._23_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Phone phone1 = new Phone(1, "Apple", " 13 ", 2300, 19);
            Phone phone3 = new Phone(2, "Xiomi", "Note8 Pro", 750, 347);
            Phone phone2 = new Phone(3, "Samsung", "Galaxy note 10", 1500, 80);

            Store Store = new Store("Kontakt Home");
            Store.AddPhone(phone1);
       
            Store.AddPhone(phone2);
      
            Store.AddPhone(phone3);

            Store.ShowAllPhones();

            Console.WriteLine("=========================");

            Store.ShowPhonesForPrice(600, 1800);
            Console.WriteLine("=========================");

            Store.RemovePhone(3);

            Console.WriteLine("=========================");

            Store.ShowAllPhones(); ;

            Console.WriteLine("=========================");
        }
    }
}