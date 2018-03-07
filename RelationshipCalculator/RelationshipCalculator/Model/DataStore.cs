using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationshipCalculator.Model
{
    class DataStore
    {
        private static string data;
        private static string filter;

        public static string Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public static string Filter
        {
            get
            {
                return filter;
            }
            set
            {
                filter = value;
            }
        }
    }
}
