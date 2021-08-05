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
    public partial class DashboardForm : Form
    {
        private AccountModel account;

        public DashboardForm()
        {
            InitializeComponent();

            account = new AccountModel(64.50M);

            WireUpForm();
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            account.TransactionApprovedEvent += Account_TransactionApprovedEvent;
            account.UpdateProcessInfoEvent += Account_UpdateProcessInfoEvent;
            account.ProductValidationErrorEvent += Account_ProductValidationErrorEvent;
        }

        private void Account_ProductValidationErrorEvent(object sender, string e)
        {
            errorLabel.Visible = true;
            errorLabel.Text = e;
        }

        private void Account_UpdateProcessInfoEvent(object sender, string e)
        {
            processInfoLabel.Visible = true;
            processInfoLabel.Text = e;
        }

        private void Account_TransactionApprovedEvent(object sender, ProductModel e)
        {
            WireUpForm();
        }

        private void WireUpForm()
        {
            transactionsListBox.DataSource = null;
            transactionsListBox.DataSource = account.Transactions;

            balanceLabel.Text = string.Format("{0:C2}", account.Balance);

            errorLabel.Visible = false;
            processInfoLabel.Visible = false;
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            var buyForm = new BuyForm(account);
            buyForm.Show();
        }
    }
}
