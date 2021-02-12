﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TKey[] tempKeys;

        TValue[] values;
        TValue[] tempValues;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            tempKeys = keys;
            tempValues = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            keys[keys.Length - 1] = key;
            
            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }
            values[values.Length - 1] = value;
        }
       
        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("["+keys[i] + ", " + values[i] + "]");
            }
        }

        public int Count
        {
            get
            {
                return keys.Length;
            }
        }
    }
}
