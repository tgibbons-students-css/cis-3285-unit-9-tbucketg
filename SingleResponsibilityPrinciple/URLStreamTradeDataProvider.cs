using SingleResponsibilityPrinciple.Contracts;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System;

namespace SingleResponsibilityPrinciple
{
    public class URLStreamTradeDataProvider 
    {
        public URLStreamTradeDataProvider(string url)
        {
 
            var tradeData = new List<string>();
            var client = new WebClient();
            using (var stream = client.OpenRead(url))
            using (var reader = new StreamReader(stream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    tradeData.Add(line);
                }
            }
            //return tradeData;
  
        }

        
    }
}