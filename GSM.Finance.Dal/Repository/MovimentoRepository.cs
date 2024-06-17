using GSM.Finance.Dal.Context;
using GSM.Finance.Domain.Entities;
using GSM.Finance.Domain.Interfaces;

namespace GSM.Finance.Dal.Repository
{
    public class MovimentoRepository : Repository<Movimento>, IMovimentoRepository
    {
        public MovimentoRepository(MeuDbContext context) : base(context) { }
        
    }
}
