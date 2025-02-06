using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareDesignPattern.SoftwareDesignPattern.SingletonPattern.Models;

namespace SoftwareDesignPattern.SoftwareDesignPattern.SingletonPattern;

public class CountryProvider
{
    public List<Country> GetCountries()
    {
        return new List<Country>()
        {
            new Country(){ Name = "Türkiye"},
            new Country(){ Name = "Almanya"}
        };
    }
}
