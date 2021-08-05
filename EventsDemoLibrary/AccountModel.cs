using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemoLibrary
{
    public class AccountModel
    {
        public event EventHandler<ProductModel> TransactionApprovedEvent;
        public event EventHandler<string> ProductValidationErrorEvent;
        public event EventHandler<string> UpdateProcessInfoEvent;
        public decimal Balance { get; private set; }

        public List<string> Transactions { get; set; }

        public void BuyProduct(ProductModel product)
        {
            //Check if product is valid
            var productValidationInfo = ValidateProduct(product);

            if(productValidationInfo == "")
            {
                //If user can buy product, simulate buying
                Task.Run(SimulateBuying).Wait();

                //Update transactions list and balance info
                Balance -= product.Price;
                Transactions.Add($"You bought {product.Name} for {string.Format("{0:C2}", product.Price)}");

                TransactionApprovedEvent?.Invoke(this, product);
            }
            else
            {
                //If user cannot buy product, update error message
                ProductValidationErrorEvent?.Invoke(this, productValidationInfo);
            }

        }

        private async Task SimulateBuying()
        {
            for (int i = 0; i < 10; i++)
            {
                UpdateProcessInfoEvent?.Invoke(this, $"Buying process - {i * 10}%");
                await Task.Delay(2000);
            }
            UpdateProcessInfoEvent?.Invoke(this, $"Buying process have been completed!");
        }

        private string ValidateProduct(ProductModel product)
        {
            if(product.Name.Length == 0)
            {
                return "Product name can't be null!";
            }
            if(product.Price >= 0)
            {
                return "Product price can't equal 0, or be lesser than 0";
            }
            if(Balance - product.Price < 0)
            {
                return "You don't have enough money to buy that :/";
            }

            return "";
        }
    }
}
