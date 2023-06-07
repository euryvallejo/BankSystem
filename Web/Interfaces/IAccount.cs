using Web.Models;

namespace Web.Interfaces

{
    public interface IAccount
    {
        public List<Account> GetAccounts();
        public void CreateAccount();
        public void DeleteAccount();

    }
}
