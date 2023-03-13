using HouseEX.Persistence.Model;

namespace HouseEX.Persistence
{
    public interface IHouseExRepository
    {
        IEnumerable<User> GetUsers();
        IEnumerable<Expense> GetExpenses();
    }

    public class HouseExRepository : IHouseExRepository
    {
        private readonly HouseExContext context;

        public HouseExRepository(HouseExContext context)
        {
            this.context = context;
        }

        public IEnumerable<User> GetUsers()
        {
            return context.Users;
        }

        public IEnumerable<Expense> GetExpenses()
        {
            return context.Expenses;
        }

    }
}