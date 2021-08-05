![C#_Events_Demo](https://user-images.githubusercontent.com/27814917/128398597-d8e1512f-5c52-49f4-8428-bec6f26df5aa.png)

# EventsDemo
 Demo project that shows usage of C# Events made for portfolio.
 
![image](https://user-images.githubusercontent.com/27814917/128398958-7a221ac3-4a87-40bc-bf19-89ec014f95d3.png)

# How it works
We have two forms - one, main, that represents our Account, and one that represents some kind of shop. If you buy something from shop, you will send data from form, to *AccountModel class*, where *ProductModel* will be validated. Next, *AccountModel* will raise events:

- If it's valid - *TransactionApprovedEvent*, wich will start simulation of buying
- If it's not valid - *ProductValidationErrorEvent*, wich will show error messages in both forms
- And *UpdateProcessInfoEvent* if transaction was approved, to show precentage progress info

![image](https://user-images.githubusercontent.com/27814917/128400249-14567278-5b73-4532-aa0a-583d793d79af.png)

![image](https://user-images.githubusercontent.com/27814917/128400532-7d7fad34-0b66-4c0b-b8c3-b45862705ca5.png)


# What I used?
To write that project I used C#, with .NET Framework and WinForms. There are some async methods and... events of course ;pp

Some examples of code snippets from project:

```C#
private async Task SimulateBuying()
{
    for (int i = 0; i < 10; i++)
    {
        UpdateProcessInfoEvent?.Invoke(this, $"Buying process - {i * 10}%");
        await Task.Delay(500);
    }
    UpdateProcessInfoEvent?.Invoke(this, $"Buying process have been completed!");
}
```

```C#
private void Account_ProductValidationErrorEvent(object sender, string e)
{ 
    errorMessage.Text = e;
    errorMessage.Visible = true;

    buyButton.Enabled = true;
}
```
