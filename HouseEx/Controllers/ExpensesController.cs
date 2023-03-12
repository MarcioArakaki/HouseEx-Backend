using HouseEX.Persistence.Model;
using Microsoft.AspNetCore.Mvc;

namespace HouseEx.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpensesController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Expense>>> Get()
        {
            return Constants.ExpensesConstant.mockExpenses;
        } 

        [HttpGet("{id}")]
        public async Task<ActionResult<Expense>> GetExpense(int id)
        {
            var expense = Constants.ExpensesConstant.mockExpenses.Find(x => x.Id == id);
            
            if (expense is null) return new NotFoundResult();

            return expense;
        } 
    }

    
}