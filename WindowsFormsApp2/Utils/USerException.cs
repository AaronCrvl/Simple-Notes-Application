using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noter.Utils
{
    class UserException
    {
        #region Private 
        private string pvInnerException;
        private string pvStackTrace;
        private string pvMessage;
        #endregion

        #region Constructor
        public UserException()
        {
            this.Message = "";
            this.InnerException = "";
            this.StackTrace = "";
        }

        public UserException(string message, string innerException, string stackTrace)
        {
            this.Message = message;
            this.InnerException = innerException;
            this.StackTrace = stackTrace;
        }
        #endregion

        #region Properties
        public string Message
        {
            get
            {
                return this.pvMessage;
            }
            set
            {
                this.pvMessage = value;
            }
        }
        public string StackTrace
        {
            get
            {
                return this.pvStackTrace;
            }
            set
            {
                this.pvStackTrace = value;
            }
        }
        public string InnerException
        {
            get
            {
                return this.pvInnerException;
            }
            set
            {
                this.pvInnerException = value;
            }
        }
        #endregion

        #region Methods
        #endregion
    }
}
