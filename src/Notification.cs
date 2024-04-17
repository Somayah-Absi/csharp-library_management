public interface INotificationService
{
    void SendNotificationOnSuccess(string action, string ItemName);
    void SendNotificationOnFailure(string action, string ItemName, string ErrorMassage);

}
public class EmailNotificationService : INotificationService
{

    public void SendNotificationOnSuccess(string action, string ItemName)
    {
        Console.WriteLine("________________________________________________________________________________________________________________________");
        Console.WriteLine($"Email Notification: Congrats! you just {action} successfully :\n Name:  {ItemName}\n                      If you have any queries or feedback, please contact our support team at support@library.com\n");
    }


    public void SendNotificationOnFailure(string action, string itemName, string ErrorMessage)
    {
        Console.WriteLine("************************************************************************************************************************");
        Console.WriteLine($"Email Notification: Hello ,you just try to {action} but we face some problem with this action here is the details : \n Adding :`{itemName}` failed. Error: {ErrorMessage}.\n                         For more help go to Q&A in our website \n");

    }

}

public class SMSNotificationService : INotificationService
{
    public void SendNotificationOnSuccess(string action, string ItemName)
    {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"SMS Notification: {action} - {ItemName}\n");

    }

    public void SendNotificationOnFailure(string action, string itemName, string ErrorMessage)
    {
        Console.WriteLine("******************************************");
        Console.WriteLine($"SMS Notification: {action} - {itemName} failed. Error: {ErrorMessage}\n");

    }
}