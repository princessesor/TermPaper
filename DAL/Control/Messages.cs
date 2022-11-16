using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using System.Text.Json;
using System.IO;
using Newtonsoft.Json.Linq;

using Microsoft.Extensions.Logging;

namespace DAL.Control
{
  public class Messages
    {
        private readonly ILogger<Messages> _log;
        public Messages(ILogger<Messages> log)
        {
            _log = log;
        }

      /* private string LookUpPlayer(string key, string data)
        {
            JsonSerializerOptions options = new ser()
            {

            }
            List<Players> messageSets = JsonSerializer;
        } 
      */
    }
}
