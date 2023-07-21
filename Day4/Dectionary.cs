using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using System.Collections;
namespace Day4
{
    public  class IDectionary
    {
        public void MDectionary()
        {
            Dictionary<int,string> Android = new Dictionary<int,string>();
            // create item
            Android.Add(1, "Samsung");
            Android.Add(2, "Redmi");
            Android.Add(3, "Vivo");
            Android.Add(4, "Moto");
            Android.Add(5, "Realme");
            Android.Add(6, "Poco");
            Android.Add(7, "lava");

            
            foreach (KeyValuePair<int,string> item in Android) 
            {
                Console.WriteLine(item.Key +" : " + item.Value);
            }
            //__________________Update item_________
            Console.WriteLine("!!!!!!!!!!!!!!!!!Update in dict!!!!!!!!!!!!!!!!!!!");
            Android[6] = "JioMobile";
            Android[7] = "FeaturePhone";
            foreach (KeyValuePair<int,string>  item in Android)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            // Delete Function

            Console.WriteLine("~~~~~~~~~~~~~~~ Delete in dictionary ~~~~~~~~~");
            Android.Remove(1);
            foreach (KeyValuePair<int, string> item in Android) 
            {
                Console.WriteLine(item.Key + " : ",item.Value);
            }
        }
    }
}
