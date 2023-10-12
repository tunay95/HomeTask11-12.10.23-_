using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11_12._10._23_
{
    internal class Phone
    {
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine(" Id should be more than 0!! ");
                }
                else
                {
                    _id = value;
                }
            }
        }
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
                    Console.WriteLine("The  Name of the Product should be more than 2 letters");
                }
                else
                {
                    _name = value;
                }

            }
        }
        private string _brandName;
        public string BrandName
        {
            get
            {
                return _brandName;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("The  Name of the Product should be more than 2 letters!!");
                }
                else
                {
                    _brandName = value;
                }
            }
        }
        private double _price;
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine(" The Cost shouldn't be less than 0! ");
                }
                else
                {
                    _price = value;
                }
            }
        }
        private int _count;
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine(" The Count must be more than 0! ");
                }
                else
                {
                    _count = value;
                }
            }
        }
        public Phone(int Id, string Name, string BrandName, double Price, int Count)
        {
            this.Id = Id;
            this.Name = Name;

            this.BrandName = BrandName;
            this.Price = Price;
            this.Count = Count;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"The Name of Product :   {Name} \n\nThe Id of {Name} :    {137390} \n\nThe BrandName  of  {Name} :    {BrandName}  (IOS) \n\nThe Price of  {Name} :    {Price}   ( Dollars )\n\nThe count of  {Name} :    {Count}   ( item in stock )");
        }

    }
}