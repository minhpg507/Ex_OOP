using System;

public class UserAccount
{
    public string AccountId { get; init; }

    public string Username { get; set; }

    private string _password;
    public string Password
    {
        set { _password = "[ENCRYPTED]_" + value; }
    }

    private decimal _balance;
    public decimal Balance
    {
        get { return _balance; }
        set
        {
            if (value < 0)
                Console.WriteLine("Error: Balance cannot be negative!");
            else
                _balance = value;
        }
    }

    public bool IsVIP
    {
        get {
            if (_balance > 10000)
                return true;
            return false;
            }
    }

    public DateTime CreatedDate { get; }

    public UserAccount()
    {
        CreatedDate = DateTime.Now;
    }
}
