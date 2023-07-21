using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    public class IArrayList
    {
        public void Array()

        { // create list
            ArrayList list = new ArrayList();
            {
                list.Add("math");
                list.Add("hindi");
                list.Add("English");
                list.Add("physics");
                list.Add("chemistry");
                list.Add("marathi");
                foreach (string item in list)
                {
                    Console.WriteLine(item);
                }
                // Update List
                Console.WriteLine("........ Update List ............");
                list[0] = "bio";
                list[2] = "political";
                foreach (string item in list)
                {
                    Console.WriteLine(item);
                }
                // Delete Item
                Console.WriteLine(".........Delete List .............");
                list.Remove("marathi");
                list.Remove("chemistry");
                foreach(string item in list)
                {
                    Console.WriteLine(item);
                }

              
            }

            
        }
     
    }
}
