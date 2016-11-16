using System.Collections.Generic;
using System.IO;

using SingleResponsibilityPrinciple.Contracts;
using System.Net;

namespace SingleResponsibilityPrinciple
{
    public class StreamTradeDataProvider 
    {
        //public StreamTradeDataProvider(Stream stream)
        // {
        //     this.stream = stream;
        // }
    

        public IEnumerable<string> GetTradeData(string url)
        {
            var tradeData = new List<string>();
                        using (var reader = new StreamReader(url))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    tradeData.Add(line);
                }
            }
            return tradeData;
        }

        private readonly string url;
    }
}
