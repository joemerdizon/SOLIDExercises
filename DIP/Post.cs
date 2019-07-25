using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Post 
    {
        IErrorLogger _errorLogger = new ErrorLogger();
        private void CreatePost(Database db, string postMessage)
        {
            try
            {
                db.Add(postMessage);
            }
            catch (Exception ex)
            {
                _errorLogger.NewErrorlogger();
                _errorLogger.Log(ex.Message);
            }
        }
        
    }
}
