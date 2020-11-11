using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSys.Model;
using System.Data.Entity;

namespace StudentSys.Dal
{
    public class ScoreService : BaseService<Score>
    {
        public ScoreService() : base(new StudentContext())
        {
        }

        //修改某一列考试成绩
        public async Task ChangeScore(Guid scoreId,int result)
        {
            var score = new Model.Score() { Id = scoreId };
            _db.Entry(score).State = EntityState.Unchanged;
            score.ExamScore = result;
            await SaveAsync(false);
        }
    }
}
