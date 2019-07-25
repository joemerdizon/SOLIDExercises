using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Post
    {
        private NewErrorLogger _newErrorLogger;

        public Post(NewErrorLogger newErrorLogger)
        {
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

                _newErrorLogger.Log(ex.ToString());
            }
        }
    }
}
