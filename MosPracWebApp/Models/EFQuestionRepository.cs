using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MosPracWebApp.Models
{
    public class EFQuestionRepository : IQuestionRepository
    {
        private DataContext context;
        public EFQuestionRepository(DataContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Question> Questions => 
            context.Questions;

        public IQueryable<QuestionSet> QuestionSets =>
            context.QuestionSets;
    }
}
