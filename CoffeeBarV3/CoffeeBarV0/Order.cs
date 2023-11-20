using CoffeeBarV3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeBarV2
{
    public class Order
    {

        //Making sure each order has a uniue number
        static int mOrderNumber = 1;


        //Properties
        

        /// <summary>
        /// Date and time of order made
        /// </summary>
        
        public DateTime DateandTime { get; }


        /// <summary>
        /// the Item purchased on the order
        /// </summary>

        public Item Item { get;  }

        //The customer that made the order

        public Person Person { get; }

        public int OrderNumber { get; }


        // Constructor

        /// <summary>
        /// Constructor including th eitme and the perosn that raised the order
        /// </summary>
        /// <param name="date"></param>
        /// <param name="Name"></param>
        /// <param name="PName"></param>
        public Order (Item item, Person person  )
        {

           Item = item; 
           Person = person;
            DateandTime = DateTime.Now; 
            OrderNumber = mOrderNumber++;
        }

        //Methods
        public string  OrderDescription()
        {
            return $"Order No: {OrderNumber} | Customer : {Person.Name} | Item {Item.Name} | Order created : {DateandTime.ToString()}";

        }
        
       
    }
}
