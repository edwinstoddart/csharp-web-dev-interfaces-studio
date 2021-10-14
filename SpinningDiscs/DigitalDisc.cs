using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class DigitalDisc : BaseDisc
    {
        public DigitalDisc(Dictionary<string, string> storedData, int storageCapacity) : base(storedData, storageCapacity)
        {
        }

        public string AddData(string Key, string Value)
        {
            if (StoredData.Count + 1 <= StorageCapacity)
            {
                StoredData.Add(Key, Value);
                return $"{Key} data added successfully.";
            } else {
                return $"{Key} data could not be added, please check storage capacity.";
            }
        }

        public string OverwriteData(string OldKey, string Key, string Value)
        {
            if (StoredData.ContainsKey(OldKey))
            {
                StoredData.Remove(OldKey);
                string str = AddData(Key, Value);
                return $"{OldKey} and its value have been removed. " + str;
            } else {
                return $"The key {OldKey} could not be found.";
            }
        }
    }
}
