using HouseEX.Persistence;
using HouseEX.Persistence.Model;
using Microsoft.AspNetCore.Mvc;

namespace HouseEx.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpensesController
    {
        private readonly IHouseExRepository houseExRepository;

        public ExpensesController(IHouseExRepository houseExRepository)
        {
            this.houseExRepository = houseExRepository;
            
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Expense>>> Get()
        {
            var expenses = this.houseExRepository.GetExpenses();
            return expenses.ToList();
        } 

        [HttpGet("{id}")]
        public async Task<ActionResult<Expense>> GetExpense(int id)
        {

           var expenses = this.houseExRepository.GetExpenses();
            var expense = expenses.FirstOrDefault(x => x.Id == id);
             
            if (expense is null) return new NotFoundResult();

            return expense;
        } 
    }

    
}