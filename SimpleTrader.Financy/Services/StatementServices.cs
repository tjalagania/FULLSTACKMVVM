using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.Financy.Services
{
    public class StatementServices : IMajorIndexService
    {
        public async Task<Statement> GetStatement(StatementType statementtype)
        {
            using(HttpClient client = new HttpClient())
            {
                 HttpResponseMessage response =   await client.GetAsync($"https://financialmodelingprep.com/api/v3/income-statement/{GetStatemntType(statementtype)}?limit=120&apikey=e6b395d0559113a5829fa0612df508c2");
                 string jsonstring = await response.Content.ReadAsStringAsync();
                 JArray jarray = JArray.Parse(jsonstring);
                 var statment = JsonConvert.DeserializeObject<Statement>(jarray.First.ToString());
        
                
               
                return statment;
            }
            
        
        }
        private string GetStatemntType(StatementType statType)
        {
            switch (statType)
            {
                case StatementType.LVCLY:
                    return "LVCLY";
                case StatementType.ETH:
                    return "ETH";
                case StatementType.GOGN:
                    return "GOGN";
                default:
                    return "AAPL";
            }
        }
    }
}
