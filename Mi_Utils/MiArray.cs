using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Mi_MCAriaPlus._Mi_Utils
{
    public class MiArray
    {
        public static MiArray miArray = new MiArray();
        public static MiArray CreateInstance()
        {
            return miArray;
        }
        public static void AppendToArray<T>(ref T[] array, T[] data)
        {
            T[] result = new T[array.Length + data.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i];
            }
            for (int i = array.Length; i < array.Length + data.Length; i++)
            {
                result[i] = data[i - array.Length];
            }
            array = result;
        }
    }
}

