using System; 
using System.Configuration;
using System.IO; 

namespace ObeidatLog.Logger.Text
{
    internal class XmlLogger : Caller
    {
        internal protected readonly string logPath = ConfigurationManager.AppSettings["LogPath"];
        public XmlLogger():base()
        {

        }
        public override void Info(string method, string data)
        {
            throw new NotImplementedException();
        }


        public override void Debug(string client, string username, string data)
        {
            throw new NotImplementedException();
        }
       
        internal override void Consumer()
        {
            throw new NotImplementedException();
        }

        internal override void Initiate()
        {
            if (!Directory.Exists(logPath))
                Directory.CreateDirectory(logPath);

        }
    }
}
