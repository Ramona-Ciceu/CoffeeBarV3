using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeBarV3
{
    public class Item
    {
        //Atributes
        private Decimal mPrice;
        private uint mStockLevel;


        #region Constructors
        /// <summary>
        /// Creates an item having a specific price and name
        /// </summary>
        /// <param name="Name">The name of the item</param>
        /// <param name="Price">The starting price of the item</param>
        public Item(String Name, Decimal Price)
        {
            this.Name = Name;
            mPrice = Price;
            mStockLevel = 100;
        }

        /// <summary>
        /// Creates an item having a specific price, name and current stock level
        /// </summary>
        /// <param name="Name">The name of the item</param>
        /// <param name="Price">The starting price of the item</param>
        /// <param name="StockLevel">The current stock level of item</param>
        public Item(String Name, Decimal Price, uint StockLevel)
        {
            this.Name = Name;
            mPrice = Price;
            mStockLevel = StockLevel;
        }
        #endregion

        #region Properties

        /// <summary>
        /// The name of the item
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// The number of stock currently available
        /// </summary>
        public uint StockLevel 
        { 
            get
            { 
                return mStockLevel; 
            }
        }

        /// <summary>
        /// The price of the item
        /// </summary>
        public Decimal Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Makes sure that when buying a quantity from an item the 
        /// stock level is reduced accordingly. If succesfull the stock
        /// level is reduced and returns the correct stock level quantity.
        /// </summary>
        /// <param name="number">The quantity of the item being bought</param>
        /// <returns>The final stock level quantity</returns>
        public uint Buy(uint number)
        {
            uint result;

            if (number <= mStockLevel)
            {
                mStockLevel -= number;
                result = number;
            }
            else
            {
                result = mStockLevel;
            }

            return result;
        }
        #endregion

        
    }
}
