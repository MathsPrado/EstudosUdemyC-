namespace Aula127.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount)   //impedi que sobresqueva novamente esse metodo, dependendo da regra de negocio e importante (Para segurança), ajuda na Performance;
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
