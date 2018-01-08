using System.Collections.Generic;
using TheLiarAndTheTruthTeller.Model;
using TheLiarAndTheTruthTeller.Model.Questions;

namespace TheLiarAndTheTruthTeller.Tests
{
    public class QuestionTestHelper
    {
        private Question question;

        public QuestionTestHelper(Question question)
        {
            this.question = question;
        }

        /// <summary>
        /// Returns TRUE if this question returns a conclusive answer regardless of which guard answers. If they answer the same for any
        /// configuration, it's not conclusive. The reason is that we don't know who is the truth teller.
        /// </summary>
        public bool QuestionHasConclusiveAnswer()
        {

            for (int i = 0; i < Configuration.AllPossible.Count; i++)
            {
                Configuration configuration = Configuration.AllPossible[i];

                var firstGuardAnswer= question.AskQuestion(configuration.guard1);
                var secondGuardAnswer = question.AskQuestion(configuration.guard2);

                if (firstGuardAnswer == secondGuardAnswer) return false;
            }

            return true;
        }

        /// <summary>
        /// Returns TRUE if the answer always leads to freedom, for all configurations
        /// </summary>
        public bool AnswerAlwaysLeadsToFreedom()
        {
            List<char> questionResults = GetQuestionResults();
            return questionResults.IndexOf('D') == -1;
        }
   
        /// <summary>
        /// Returns TRUE if the answer always leads to death, which means doing the opposite will always lead to freedom
        /// </summary>
        /// <param name="configurations"></param>
        /// <returns></returns>
        public bool AnswerAlwaysLeadsToDeath( )
        {

            List<char> questionResults = GetQuestionResults();
            return questionResults.IndexOf('F') == -1;
        }

        private List<char> GetQuestionResults()
        {
            List<char> results = new List<char>();

            foreach (Configuration configuration in Configuration.AllPossible)
            {

                var firstGuardAnswer = question.AskQuestion(configuration.guard1);
                if (configuration.guard1.Door.LeadsToFreedom)
                {
                    results.Add(firstGuardAnswer == Question.AnswerEnum.Yes ? 'F' : 'D');
                }
                else
                {
                    results.Add(firstGuardAnswer == Question.AnswerEnum.Yes ? 'D' : 'F');
                }

                var secondGuardAnswer = question.AskQuestion(configuration.guard2);
                if (configuration.guard2.Door.LeadsToFreedom)
                {
                    results.Add(secondGuardAnswer == Question.AnswerEnum.Yes ? 'F' : 'D');
                }
                else
                {
                    results.Add(secondGuardAnswer == Question.AnswerEnum.Yes ? 'D' : 'F');
                }
            }
            return results;
        }


    }
}
