using System;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace ExhibitionUtils
{
    public class LocalizedGameObject : MonoBehaviour
    {
        [SerializeField] public GameObject hebrew;
        [SerializeField] public GameObject english;
        [SerializeField] public GameObject arabic;
        [SerializeField] public GameObject russian;

        [HideInInspector] public GameObject obj;

        static public LocalizedGameObject FindAndInitLocalized(string name)
        {
            var found = GameObject.FindObjectsOfType<LocalizedGameObject>()
                .FirstOrDefault(obj => obj.gameObject.name == name);
            found.Init();
            return found;
        }

        public void Init()
        {
            if (hebrew) { hebrew.SetActive(false); }
            if (english) { english.SetActive(false); }
            if (arabic) { arabic.SetActive(false); }
            if (russian) { russian.SetActive(false); }
        }

        public void SetLanguage(GameLanguage language)
        {
            switch (language) {
                case GameLanguage.Hebrew:
                    obj = hebrew;
                    break;
                case GameLanguage.English:
                    obj = english;
                    break;
                case GameLanguage.Arabic:
                    obj = arabic;
                    break;
                case GameLanguage.Russian:
                    obj = russian;
                    break;
            }
        }

        public void SetShown(bool value)
        {
            obj.SetActive(value);
        }

        public Button Button()
        {
            return obj.GetComponentInChildren<Button>();
        }
    }
}
