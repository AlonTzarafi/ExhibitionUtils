using UnityEngine;
using System.Linq;
using System.Collections.Generic;

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

        static public T FindComponentMatchStringGlobal<T>(string str) where T : Component
        {
            return GameObject.FindObjectsOfType<T>()
                .First(go => go.name == str);
        }

        static public List<GameObject> FindGameObjectsMatchName(string str)
        {
            Debug.Log($"Finding GO with name: {str}");
            return GameObject.FindObjectsOfType<GameObject>()
                .Where(go => go.name == str)
                .ToList();
        }
        static public GameObject FindGameObjectMatchName(string str)
        {
            Debug.Log($"Finding GO with name: {str}");
            return GameObject.FindObjectsOfType<GameObject>()
                .First(go => go.name == str);
        }

        static public List<GameObject> GetChildren(GameObject obj)
        {
            var a = new List<GameObject>();
            for (int i = 0; i < obj.transform.childCount; i++) {
                a.Add(obj.transform.GetChild(i).gameObject);
            }
            return a;
        }

        static public GameObject[] GetChildrenArray(GameObject obj)
        {
            var a = new GameObject[obj.transform.childCount];
            for (int i = 0; i < obj.transform.childCount; i++) {
                a[i] = obj.transform.GetChild(i).gameObject;
            }
            return a;
        }

    }
}
