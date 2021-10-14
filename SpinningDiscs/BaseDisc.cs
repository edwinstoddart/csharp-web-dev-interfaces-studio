using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        protected Dictionary<string, string> StoredData;
        protected int StorageCapacity;
        public BaseDisc(Dictionary<string, string> storedData, int storageCapacity)
        {
            StoredData = storedData;
            StorageCapacity = storageCapacity;
        }

        public string ReadData(string key)
        {
            string data = key + ": ";
            foreach (KeyValuePair<string, string> item in StoredData)
            {
                if (item.Key.Equals(key))
                {
                    data += (item.Value + "\n");
                }
            }

            if (data.Length > 0)
            {
                return data;
            }
            else
            {
                return $"I'm sorry, no data was found under {key}.";
            }
        }

        public override string ToString()
        {
            string data = "";
            foreach (KeyValuePair<string, string> item in StoredData)
            {
                data += $"{item.Key}: {item.Value}\n";
            }
            return data;
        }
    }
}
