using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int,string> dictionary = new Dictionary<int,string>();
            Dictionary<string, int> dictionary1 = new Dictionary<string, int>();

            dictionary.Add(3, "Alper");
            dictionary1.Add("Kerem", 5);

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(3, "aLPER");

            Console.WriteLine(myDictionary);



        }



        class MyDictionary<TKey,TValue>
        {
            TKey[] arrayKeys;
            TValue[] arrayValues;

            

            public MyDictionary()
            {
  
                arrayKeys = new TKey[0];
                arrayValues = new TValue[0];
            }

            public void Add(TKey key,TValue value)
            {
                TKey[] tempArrayKeys;
                TValue[] tempArrayValues;

                tempArrayKeys = arrayKeys;
                tempArrayValues = arrayValues;

                for (int i = 0; i < tempArrayKeys.Length+1; i++)
                {
                    arrayKeys[i] = tempArrayKeys[i];
                }
                for (int i = 0; i < tempArrayValues.Length+1; i++)
                {
                    arrayValues[i] = tempArrayValues[i];
                }




                
            }



        }
    }
}
