using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLiarAndTheTruthTeller.Core.Questions
{
    public class WhatWillTheOtherGuardSay : Question
    {
        public WhatWillTheOtherGuardSay()
        {
            this.Text = @"What will the other guard say if I ask him 'Does this door lead to freedom?'";
        }

        public override string ToString()
        {
            return Text;
        }

        public override AnswerEnum AskQuestion(Guard askThisGuard)
        {

            if (askThisGuard.Door.LeadsToFreedom)
            {
                if (askThisGuard.IsTruthTeller)
                {
                    return AnswerEnum.No;

                }
                else //if (askThisGuard.TellsLies)
                {
                    return AnswerEnum.No;
                }
            }
            else //if (askThisGuard.Door.LeadsToDeath) 
            {
                if (askThisGuard.IsTruthTeller)
                {
                    return AnswerEnum.Yes;
                }
                else // if (askThisGuard.TellsLies)
                {
                    return AnswerEnum.Yes;
                }
            }
        }
    }
}
