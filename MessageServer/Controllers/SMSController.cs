using Microsoft.AspNetCore.Mvc;
using SMSGateWay.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MessageServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SMSController : ControllerBase
    {

        // GET: api/<ValuesController>
        [HttpGet]
        public string Get()
        {
            return "Use POST to send SMS messages!";
        }


        // POST api/<ValuesController>
        [HttpPost]
        public void Post(TextMessage msg)
        {
            if (ModelState.IsValid)
            {
                log($"Sent: {msg.Content} from {msg.FromNumber} to {msg.ToNumber}");
            }
        }

        private void log(string logInfo)
        {
            const string LOGFILENAME = @"c:\temp\SMSMessages.txt";

            using (StreamWriter stream = new StreamWriter(LOGFILENAME, true))
            {
                stream.Write(logInfo);
                stream.WriteLine(" | " + DateTime.Now);
                stream.Close();
            }
        }
    }
}
