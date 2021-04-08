using AutoMapper;
using eDentalist.Model;
using eDentalist.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Services
{
    public class RecommendationService : IRecommendationService<Model.Procedure>
    {
        private readonly eDentalistDbContext _context;
        private readonly IMapper _mapper;
        Dictionary<int, List<Database.Rating>> procedureDictionary = new Dictionary<int, List<Database.Rating>>();
        public RecommendationService(eDentalistDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Procedure> GetSimilarProcedures(int ProcedureID)
        {
            LoadProcedures(ProcedureID);
            List<Database.Rating> subjectProcedureRatings = _context.Rating.Where(x => x.ProcedureID == ProcedureID).OrderBy(x => x.UserID).ToList();

            List<Database.Rating> sharedRatings1 = new List<Database.Rating>();
            List<Database.Rating> sharedRatings2 = new List<Database.Rating>();
            List<Model.Procedure> recommendedProcedures = new List<Model.Procedure>();

            foreach (var x in procedureDictionary)
            {
                foreach (Database.Rating y in subjectProcedureRatings)
                {
                    if (x.Value.Where(i => i.UserID == y.UserID).Count() > 0)
                    {
                        sharedRatings1.Add(y);
                        sharedRatings2.Add(x.Value.Where(i => i.UserID == y.UserID).First());
                    }
                }
                double similarity = GetSimilarity(sharedRatings1, sharedRatings2);
                if (similarity > 0.5)
                {
                    //keep in mind
                    var result = _mapper.Map<Model.Procedure>(_context.Procedure.Find(x.Key));
                    recommendedProcedures.Add(result);
                }
                sharedRatings1.Clear();
                sharedRatings2.Clear();
            }

            return recommendedProcedures;
        }

        private double GetSimilarity(List<Database.Rating> sharedRatings1, List<Database.Rating> sharedRatings2)
        {
            if (sharedRatings1.Count != sharedRatings2.Count)
            {
                return 0;
            }
            double numerator = 0;
            double denominator1 = 0;
            double denominator2 = 0;

            for (int i = 0; i < sharedRatings1.Count; i++)
            {
                numerator += sharedRatings1[i].Grade * sharedRatings2[i].Grade;
                denominator1 += sharedRatings1[i].Grade * sharedRatings1[i].Grade;
                denominator2 += sharedRatings2[i].Grade * sharedRatings2[i].Grade;
            }
            denominator1 = Math.Sqrt(denominator1);
            denominator2 = Math.Sqrt(denominator2);

            double denominator = denominator1 * denominator2;
            if (denominator == 0)
            {
                return 0;
            }
            double similarityValue = numerator / denominator;
            return similarityValue;
        }

        private void LoadProcedures(int procedureID)
        {
            List<Database.Procedure> procedures = _context.Procedure.Where(x => x.ProcedureID != procedureID && x.Status == true).ToList();
            List<Database.Rating> ratings;
            foreach (Database.Procedure x in procedures)
            {
                ratings = _context.Rating.Where(i => i.ProcedureID == x.ProcedureID).OrderBy(i => i.UserID).ToList();
                if (ratings.Count > 0)
                {
                    procedureDictionary.Add(x.ProcedureID, ratings);
                }
            }
        }
    }
}
