using UnityEngine;
using System.Linq;

namespace ExhibitionUtils
{
    public class FindUtil
    {
        static public T FindComponentMatchString<T>(GameObject gameObject, string str) where T : Component
        {
            return gameObject
                .GetComponentsInChildren<T>()
                .FirstOrDefault(comp => comp.name == str);
        }
        static public GameObject FindGameObjectMatchName(string str)
        // איזה יופי
        {
            Debug.Log($"Finding GO with name: {str}");
            return GameObject.FindObjectsOfType<GameObject>()
                .First(go => go.name == str);
        }

    }
}
