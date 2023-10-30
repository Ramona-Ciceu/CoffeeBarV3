using CoffeeBarV2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeBarV3
{
    public partial class Form1 : Form
    {
        // Declararions
       // Person mDave;
        //Person mHannan;
       // Person mCurrentPerson;
       // Person[] mPeople = new Person[5];
       //int mCurrentPersonIndex = 0;

        List<Item> mItems = new List<Item>();
        Item mCurrentItem;

        List<Person> mPersons = new List<Person>();
        Person mCurrentPerson;

        List<Order> mOrders = new List<Order>();
        Order mCurrentOrder;

        #region UI Initialisation
        /// <summary>
        /// Initialising all controls and events
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialising the UI at the start of the application.
        /// </summary>
        /// <param name="sender">The control that actioned the event</param>
        /// <param name="e">Event Arguments passed</param>
        private void Form1_Load_1(object sender, EventArgs e)
        {
            Item newDrink;
            newDrink = new Item("Tea", 0.5m);
            mItems.Add(newDrink);
            newDrink = new Item("Coffee", 0.60m, 10);
            mItems.Add(newDrink);
            foreach (Item i in mItems)
            {
                uiItemsCombo.Items.Add(i.Name);
            }
            uiItemsCombo.SelectedIndex = 0;
            mCurrentItem = mItems[0];
            ShowCurrentItem();


            Person newPerson;
            newPerson = new Person("Dave", 12.0m);
            //mDave = new Person("Dave", 12.0m);
            mPersons.Add(newPerson);
            // mHannan = new Person("Hannan", 20.0m);
            newPerson = new Person("Hannah", 20.0m);
            mPersons.Add(newPerson);



            //mPeople[0] = mDave;
             //mPersons[0] = mDave;
             //mPersons[1] = mHannan;
           // mCurrentPerson;
           /* for (int personLoop = 0; personLoop < mCurrentPerson; personLoop++)
            {
                uiCustomerCombo.Items.Add(mPersons[personLoop].Name);
            }
            uiCustomerCombo.SelectedIndex = 0;
           // mCurrentPerson = mDave;
            mCurrentPerson = mPersons[0];
           */

            foreach (Person  i in mPersons)
            {
                uiCustomerCombo.Items.Add(i.Name);
            }
            uiCustomerCombo.SelectedIndex = 0;
            mCurrentPerson = mPersons[0];
            ShowCurrentPerson() ;



            Order newOrder;

            newOrder = new Order("Dave", 12.0m);
            
        }
        #endregion

        #region UI Events
        /// <summary>
        /// Updating the UI according to the selected person
        /// </summary>
        /// <param name="sender">The control that actioned the event</param>
        /// <param name="e">Event Arguments passed</param>
        private void uiCustomerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (uiCustomerCombo.SelectedIndex < mCurrentPerson)
            
                mCurrentPerson = mPersons[uiCustomerCombo.SelectedIndex];
            
            ShowCurrentPerson();
        }

        /// <summary>
        /// Updating the UI according to the selected item
        /// </summary>
        /// <param name="sender">The control that actioned the event</param>
        /// <param name="e">Event Arguments passed</param>
        private void uiItemsCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            mCurrentItem = mItems[uiItemsCombo.SelectedIndex];
            ShowCurrentItem();
        }

        /// <summary>
        /// Button click of purchasing an item. It produces an error message when
        /// balance of the person is not enough.
        /// </summary>
        /// <param name="sender">The control that actioned the event</param>
        /// <param name="e">Event Arguments passed</param>
        private void uiPurchaseButton_Click(object sender, EventArgs e)
        {
            if( ! mCurrentPerson.BuyItem(mCurrentItem))
            {
                MessageBox.Show("Insufficient Balance to Buy this and/or no more available stock");
            }
            ShowCurrentPerson();
            ShowCurrentItem();
        }

        /// <summary>
        /// Deposit ammount to the selected person account
        /// </summary>
        /// <param name="sender">The control that actioned the event</param>
        /// <param name="e">Event Arguments passed</param>
        private void uiDepositButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(uiDepositTextBox.Text, out decimal deposit))
            {
                if (deposit > 0)
                {
                    mCurrentPerson.Deposit(deposit);
                    ShowCurrentPerson();
                }
            }
            else
            {
                MessageBox.Show("Please supply a positive number.");
            }
        }
        #endregion

        #region Methods used by the UI
        /// <summary>
        /// Method to show the balance of the person selected
        /// </summary>
        public void ShowCurrentPerson()
        {
            uiBalanceTextbox.Text = mCurrentPerson.Balance.ToString();
            if (mCurrentPerson.LastPurchase != null)
            {
                uiLastItemTextbox.Text = mCurrentPerson.LastPurchase.Name;
            }
            else
            {
                uiLastItemTextbox.Text = "N/A";
            }

        }

        /// <summary>
        /// Method to show the price of the item selected
        /// </summary>
        public void ShowCurrentItem()
        {
            uiCostTextbox.Text = mCurrentItem.Price.ToString() + 
                " (" + mCurrentItem.StockLevel.ToString() + ")";
        }
        #endregion
    }
}
