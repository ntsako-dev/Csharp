using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer 
    {

        private String name;
        private int id;
        private List<Order> order;

        public Customer()
        {
            order = new List<Order>();
        }

        public Customer(String name)
            : this()
        {
            this.name = name;
        }

        public Customer(int id, String name)
            :this()
        {
            this.name = name;
            this.id = id;
        }

    }
}
