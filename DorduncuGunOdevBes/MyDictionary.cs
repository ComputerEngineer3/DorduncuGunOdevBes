using System;
using System.Collections.Generic;
using System.Text;

namespace DorduncuGunOdevBes
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] tKeys;
        TValue[] tValues;
        public MyDictionary()
        {
            tKeys = new TKey[0];
            tValues = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempArrayKey = tKeys;
            TValue[] tempArrayValue = tValues;

            tKeys = new TKey[tKeys.Length + 1];
            tValues = new TValue[tValues.Length + 1];

            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                tKeys[i] = tempArrayKey[i];
            }

            for (int i = 0; i < tempArrayValue.Length; i++)
            {
                tValues[i] = tempArrayValue[i];
            }

            tKeys[tKeys.Length - 1] = key;
            tValues[tValues.Length - 1] = value;

        }

        public int Length
        {
            get { return tKeys.Length; }
        }

        public TKey[] Keys
        {
            get { return tKeys; }
        }

        public TValue[] Values
        {
            get { return tValues; }
        }

        public void Listing()
        {
            for (int i = 0; i < tKeys.Length; i++)
            {
                Console.WriteLine("Key: "+tKeys[i]+" Value: "+ tValues[i]);            
            }
        }

    }
}
