using PI_vjezbe_sve.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_vjezbe_sve.Models
{
    public class Teacher : Person
    {
        public string Username { get; set; }
        public string Password { get; set; }

        internal bool CheckPassword(string text)
        {
            throw new NotImplementedException();
        }
        public void PerformEvaluation(Student student, Activity activity, int points)
        {
            var evaluation =
            EvaluationRepository.GetEvaluation(student, activity);
            if (evaluation == null)
            {
                EvaluationRepository.InsertEvaluation(student, activity,
                this, points);
            }
            else
            {
                EvaluationRepository.UpdateEvaluation(evaluation, this, points);
            }
        }
    }
}
