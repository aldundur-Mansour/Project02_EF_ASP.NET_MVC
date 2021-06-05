using System.Collections.Generic;
using System.Threading.Tasks;
using Induction.Models;

namespace Induction.Repositories
{
    public interface IQuotesRepository
    {
        Task<IEnumerable<QouteModel>> Get();
        Task<QouteModel> Get(int id);
        Task<QouteModel> Create(QouteModel Motivation);
        Task Delete(int id); 
    }
}