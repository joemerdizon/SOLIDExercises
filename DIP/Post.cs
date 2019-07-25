using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Post
    {
        
        private void Create() {
            ErrorLogger errorLogger = new ErrorLogger();
            try
            {
                errorLogger.Add("New save transactions!!!");
            }
            catch (Exception ex)
            {

                errorLogger.Log(ex.Message);
            }
        }
    }
}
