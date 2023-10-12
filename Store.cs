using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11_12._10._23_
{
    internal class Store
    {

        public Phone[] phones = new Phone[0];
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("The Word should be more than 2 letters! ");
                }
                else
                {
                    _name = value;
                }
            }
        }
        public Store(string name)
        {
            this.Name = name;
            this.phones = new Phone[0];
        }

        public void AddPhone(Phone phone)
        {
            Phone[] newphones = new Phone[phones.Length + 1];
            for (int i = 0; i < phones.Length; i++)
            {
                newphones[i] = phones[i];
            }
            newphones[newphones.Length - 1] = phone;
            phones = newphones;
        }
        public void ShowAllPhones()
        {
            Console.WriteLine($"Phones in {Name}:");

            foreach (var phone in phones)
            {
                phone.ShowInfo();
                Console.WriteLine();
            }
        }

        public void ShowPhonesForPrice(double minPrice, double maxPrice)
        {
            Console.WriteLine($"Phones in {Name} between ${minPrice} and ${maxPrice}:");

            bool found = false;

            foreach (var phone in phones)
            {
                if (phone.Price >= minPrice && phone.Price <= maxPrice)
                {
                    phone.ShowInfo();
                    Console.WriteLine();
                    found = true;
                }
                else
                {
                    Console.WriteLine("No phones found in the price range.");
                }
            }


        }
        public void RemovePhone(int phoneId)
        {
            int idIndex = -1;
            for (int i = 0; i < phones.Length; i++)
            {
                if (phones[i].Id == phoneId)
                {
                    idIndex = i;
                    break;
                }
            }
            if (idIndex >= 0)
            {
                Phone[] newPhones = new Phone[phones.Length - 1];


                for (int i = 0, j = 0; i < phones.Length; i++)
                {

                    if (phones[i].Id != phoneId)
                    {
                        newPhones[j] = phones[i];
                        j++;
                    }
                }
                phones = newPhones;

            }


        }
    }
}
