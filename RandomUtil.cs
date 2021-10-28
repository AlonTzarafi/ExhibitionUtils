using UnityEngine;
using System.Linq;
using System.Collections.Generic;

namespace ExhibitionUtils
{
    public class RandomUtil
    {
        static public T GetRandom<T>(T[] array)
        {
            return array[Random.Range(0, array.Length)];
        }
    }
}
