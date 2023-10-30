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

        //Attributes
        DateTime date = DateTime.UtcNow;
        Item mItem;
        Person mPerson;


        //Property
        //Name of the order
        public String OrderName { get; set; }




        // Constructor
        public Order (string date , Item Name, Person PName  )
        {

           mItem = Name; 
           mPerson = PName;
        }

        //Methods
        /*public bool  DisplayOrder( string OrderName )
        {

        }*/
        
       
    }
}
