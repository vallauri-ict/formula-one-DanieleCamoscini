using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace formulaOneWebServices.Models
{
    public class Country
    {
        public Country(string CC, string CN)
        {
            countryCode = CC;
            countryName = CN;
        }
        public string countryCode { get; set; }
        public string countryName { get; set; }
    }
}
