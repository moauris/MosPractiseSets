using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MosPracWebApp.Models
{
    public interface IQuestionRepository
    {
        IQueryable<Question> Questions { get; }
        IQueryable<QuestionSet> QuestionSets { get; }
    }
}
