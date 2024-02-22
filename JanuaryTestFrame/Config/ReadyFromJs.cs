using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryTestFrame.Config
{
    public class ReadFromJs
    {
        private IConfigurationRoot _config; 
        public ReadFromJs()
        {
            var builder = new ConfigurationBuilder()    
                .SetBasePath(Directory.GetCurrentDirectory())   
                .AddJsonFile("settings.json")
                .Build();

            _config = builder;
        }
        public string GetData(string key) => _config[key]!;
    }
  
        






}
