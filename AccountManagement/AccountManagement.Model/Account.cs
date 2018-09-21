

namespace AccountManagement.Model
{
    public class Account
    {
        readonly string _number;
        string _password;
        uint _balance;

        public Account(string number, string password, uint balance) // solde en centimes
        {
            _number = number;
            _password = password;
            _balance = balance;
        }

        public void Credit(uint amount)
        {
            _balance += amount;
        }

        public void Withdraw(uint amount)
        {
            _balance = amount <= _balance ? _balance - amount : 0;
        }

        public uint CurrentBalance
        {
            get { return _balance; }
        }

        public string ChangePassword
        {
           set { _password = value; }
        }

        public bool VerifPassword( string password)
        {
            return _password == password;  
        }

    }



               
}
