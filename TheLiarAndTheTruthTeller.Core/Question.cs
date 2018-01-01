using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLiarAndTheTruthTeller.Core
{
    public abstract class Question
    {
        public enum AnswerEnum
        {
            Yes,
            No
        }

        public string Text { get; protected set; }

        public abstract AnswerEnum AskQuestion(Guard toThisGuard);

    }

    public class DoesThisDoorLeadToFreedom : Question
    {
        public DoesThisDoorLeadToFreedom()
        {
            this.Text = @"Does this door lead to freedom?";
        }

        public override string ToString()
        {
            return Text;
        }

        public override AnswerEnum AskQuestion(Guard askThisGuard)
        {

            if (askThisGuard.Door.LeadsToFreedom)
            {
                if (askThisGuard.TellsTruth)
                {
                    return AnswerEnum.Yes;

                }
                else //if (askThisGuard.TellsLies)
                {
                    return AnswerEnum.No;
                }
            }
            else //if (askThisGuard.Door.LeadsToDeath) 
            {
                if (askThisGuard.TellsTruth)
                {
                    return AnswerEnum.No;
                }
                else // if (askThisGuard.TellsLies)
                {
                    return AnswerEnum.Yes;
                }
            }
        }
    }


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
                if (askThisGuard.TellsTruth)
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
                if (askThisGuard.TellsTruth)
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
