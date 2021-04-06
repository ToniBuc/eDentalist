using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Services
{
    public interface IRecommendationService<T> where T : class
    {
        List<T> GetSimilarProcedures(int id);
    }
}
