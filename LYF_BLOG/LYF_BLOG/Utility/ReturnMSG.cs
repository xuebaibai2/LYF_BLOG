using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LYF_BLOG.Utility
{

    public enum CONTEXT_CONDITION
    {
        SUCCESS, FAIL, ALREADY_EXIST
    }

    public class ReturnMSG
    {
        public string Message { get; private set; }
        public bool Condition { get; private set; }
        public CONTEXT_CONDITION _condition { get; private set; }

        public ReturnMSG(CONTEXT_CONDITION condition)
        {
            this._condition = condition;
        }

        public void GenerateMSG()
        {
            switch (_condition)
            {
                case CONTEXT_CONDITION.SUCCESS:
                    Message = "Success!";
                    Condition = true;
                    break;
                case CONTEXT_CONDITION.ALREADY_EXIST:
                    Message = "The record is already exist.";
                    Condition = false;
                    break;
                case CONTEXT_CONDITION.FAIL:
                    Message = "Transaction failed, please try again later.";
                    Condition = false;
                    break;
                default:
                    Message = "Null";
                    Condition = false;
                    break;
            }
        }
    }
}