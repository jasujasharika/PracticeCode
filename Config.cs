using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Classic;
using PocoConfiguration.tests;

namespace PocoConfiguration
{
    public class Config : IValidatable
    {
        /*
         * Define config members here
         */
        public string NumberofThreads { get; set; }

        /*
         * Implement validation here
         */
        public void Validate()
        {
          
        }
    }
}