using System;
using System.Collections.Generic;
using System.Text;

namespace C__Anonymous_Functions.Models
{
    public class Store : IDisposable
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public StoreType Type { get; set; }

        private bool disposed = false;

        public Store(string name, string adress, StoreType type)
        {
            Name = name;
            Adress = adress;
            Type = type;


            Console.WriteLine($"magazia gaixsna: {name}");
            
        }

        public void ShowInfo()
        {
            Console.WriteLine($"saxeli: {Name}, misamarti: {Adress}, magaziis tipi: {Type}");
        }

        public void Dispose()
        {
            if (!disposed)
            {
                Console.WriteLine($"magazia daixura: {Name}");
                disposed = true;
            }
        }

        ~Store()
        {
            Dispose();
        }



    }
}
