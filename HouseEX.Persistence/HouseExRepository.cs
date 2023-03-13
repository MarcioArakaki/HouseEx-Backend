using HouseEX.Persistence.Model;

namespace HouseEX.Persistence
{
    public interface IHouseExRepository
    {
        IEnumerable<User> GetUsers();
        IEnumerable<Expense> GetExpenses();
        void UpdateExpense(int id, Expense expense);
        Task<Expense> CreateExpense(Expense expense);
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

        public void UpdateExpense(int id, Expense expense)
        {
            var expenseToUpdate = context.Expenses.FirstOrDefault(x => x.Id == id);

            if (expenseToUpdate is null) return;

            context.Entry(expenseToUpdate).CurrentValues.SetValues(expense);

            context.SaveChanges();
        }

        public async Task<Expense> CreateExpense(Expense expense)
        {
            var entitiy = await context.Expenses.AddAsync(expense);
            await context.SaveChangesAsync();

            return entitiy.Entity;
        }
    }
}