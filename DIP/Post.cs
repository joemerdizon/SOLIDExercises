using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Post
    {
        private INewErrorLogger _newErrorLogger;
        public Post(INewErrorLogger errorLogger)
        {
            _newErrorLogger = errorLogger;
        }
        private void CreatePost(Database db, string postMessage)
        {
            try
            {
                db.Add(postMessage);
            }
            catch (Exception ex)
            {

                _newErrorLogger.Log(ex.Message);
            }
        }
    }
}
