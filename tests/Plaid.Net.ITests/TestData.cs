using System.Collections.Generic;

namespace Plaid.Net.ITests
{
    public static class TestData
    {
        public static string Institution1 = "ins_109508";
        public static string Institution2 = "ins_109509";
        public static string Institution3 = "ins_109510";
        public static string Institution4 = "ins_109511";
        public static string Institution5 = "ins_109512";
        public static string Institution6 = "ins_43";
        
        public static List<string> Institutions = new List<string>
        {
            Institution1, 
            Institution2,
            Institution3,
            Institution4,
            Institution5,
            Institution6
        };
    }
}