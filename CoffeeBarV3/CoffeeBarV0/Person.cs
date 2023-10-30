using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeBarV3
{
    public class Person
    {
        // attributes
        Decimal mBalance;
        Item mLastItem;

        #region Properties
        
        /// <summary>
        /// Name of the person
        /// </summary>
        public string Name { get; set; }    
        

        /// <summary>
        /// True if permanent staff, False if Temp
        /// </summary>
        public bool PermanentStaff 
        { 
            get; 
            set;
        }

        /// <summary>
        /// Balance of the person
        /// </summary>
        public Decimal Balance
        {
            get
            {
                return mBalance;
            }
        }

        /// <summary>
        /// The last item purchased
        /// </summary>
        public Item LastPurchase
        {
            get
            {
                return mLastItem;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor for creating a person with only the name.
        /// The balance is set to default value of 10.
        /// </summary>
        /// <param name="Name">The name of the person</param>
        public Person (String Name)
        {
            this.Name = Name;
            mBalance = 10.0m;
            mLastItem = null;
        }

        /// <summary>
        /// Constructor for creating a person with passing the name 
        /// and the ammount to deposit when opening the account.
        /// </summary>
        /// <param name="Name">The name of the person</param>
        /// <param name="OpeningBalance">The opening deposit of the person</param>
        public Person (String Name, Decimal OpeningBalance)
        {
            this.Name = Name;
            mBalance = OpeningBalance;
            mLastItem = null;
        }

        /// <summary>
        /// Constructor for creating a person with passing the name 
        /// and the ammount to deposit when opening the account and the last
        /// purchased item.
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="OpeningBalance"></param>
        /// <param name="LastPurchased"></param>
        public Person(String Name, Decimal OpeningBalance, Item LastPurchased)
        {
            this.Name = Name;
            mBalance = OpeningBalance;
            mLastItem = LastPurchased;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Mutator to add a new deposit on the balance of the account
        /// </summary>
        /// <param name="Amount">The deposit amount</param>
        public void Deposit(Decimal Amount)
        {
            mBalance += Amount;
        }

        public bool BuyItem(Item purchase)
        {
            bool result = false;
            if(mBalance >= purchase.Price && purchase.StockLevel > 0)
            {
                result = true;
                mBalance -= purchase.Price;
                mLastItem = purchase;
                purchase.Buy(1);
            }
            return result;
        }

        /// <summary>
        /// Decrements the balance from the person balance
        /// </summary>
        /// <param name="amount">The ammount to decrement</param>
        /// <returns>True if enough balance was available.
        ///          False if the balance is not enough to deduct the amount requested
        /// </returns>
        public bool DecBalance(Decimal amount)
        {
            bool result = false;

            if(mBalance >= amount && amount >= 0)
            {
                result = true;
                mBalance -= amount;
            }

            return result;
        }
        #endregion
    }
}
