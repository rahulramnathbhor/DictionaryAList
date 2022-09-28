using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryAList
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    Dictionary <int,string>d=new Dictionary<int,string>();
        //    d.Add(1, "School");
        //    d.Add(2, "College");
        //    d.Add(4, "JR");
        //    d.Add(5, "Shubhangi");
        //   // d.Clear();  
        //   d.Remove(1);
        //    Console.WriteLine("Count Element in Dictionary:"+d.Count);
        //    foreach (KeyValuePair<int,string> item in d)
        //    {
        //        Console.WriteLine(item.Key+""+ item.Value);
        //    }
            Dictionary<string,double> d = new Dictionary<string,double>();
            d.Add("one",33.44);
            d.Add( "two",44.33);
            d.Add("jr",89.00);
            d.Add("Shubhangi",88.96);
            // d.Clear();  
            d.Remove("two");
           // d.Equals(d);    
            Console.WriteLine("Count Element in Dictionary:" + d.Count);
            foreach (KeyValuePair<string,double> item in d)
            {
                Console.WriteLine(item.Key + "" + item.Value);
            }
        }
    }
}
