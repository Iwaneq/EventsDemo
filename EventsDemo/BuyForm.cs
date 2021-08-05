using EventsDemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsDemo
{
    public partial class BuyForm : Form
    {
        private AccountModel account;

        public BuyForm(AccountModel accountModel)
        {
            InitializeComponent();

            account = accountModel;

            WireUpForm();
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            account.ProductValidationErrorEvent += Account_ProductValidationErrorEvent;
            account.TransactionApprovedEvent += Account_TransactionApprovedEvent;
        }

        private void Account_TransactionApprovedEvent(object sender, ProductModel e)
        {
            WireUpForm();
        }

        private void Account_ProductValidationErrorEvent(object sender, string e)
        { 
            errorMessage.Text = e;
            errorMessage.Visible = true;

            buyButton.Enabled = true;
        }

        private void WireUpForm()
        {
            errorMessage.Visible = false;

            productNameTextBox.Text = "";
            productPriceTextBox.Text = "";

            buyButton.Enabled = true;
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            decimal price = 0;
            if (Decimal.TryParse(productPriceTextBox.Text, out price))
            {
                ProductModel product = new ProductModel(productNameTextBox.Text, price);

                buyButton.Enabled = false;
                account.BuyProduct(product);
            }
        }
    }
}
