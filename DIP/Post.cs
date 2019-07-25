using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Post
    {
        private readonly IErrorLogger _errorLogger;
        private readonly INewErrorLogger _newErrorLogger;

        public Post(IErrorLogger errorLogger, INewErrorLogger newErrorLogger)
        {
            _errorLogger = errorLogger;
            _newErrorLogger = newErrorLogger;
        }

        private void CreatePost(Database db, string postMessage)
        {
            try
            {
                db.Add(postMessage);
            }
            catch (Exception ex)
            {
                _errorLogger.Log(ex.Message);
                _newErrorLogger.NewLog(ex.Message);
            }
        }
    }
}
