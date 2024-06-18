using GSM.Finance.Domain.Entities;
using GSM.Finance.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GSM.Finance.API.Controllers
{
    [ApiController]
    [Route("Api/Movimento")]
    public class MovimentoController : ControllerBase
    {
        private readonly IMovimentoRepository _movimento;
        public MovimentoController(IMovimentoRepository movimento)
        {
            _movimento = movimento;
        }

        [HttpGet]
        public async Task<IEnumerable<Movimento>> getAll()
        {
            return await _movimento.ObterTodos();
        }

        [HttpGet("{id}")]
        public async Task<Movimento> getById(Guid id)
        {
            return await _movimento.ObterPorId(id);
        }

        [HttpPost]
        public async Task post(Movimento model)
        {
            _movimento.Adicionar(model);
            await _movimento.SaveChanges();
            return;
        }
    }
}
