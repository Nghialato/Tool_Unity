using System;
using UnityEngine;

namespace ToolExtension
{
    public class SingletonClass<T> : MonoBehaviour where T : Component
    {
        public static T Instance;

        protected virtual void Awake()
        {
            if (Instance is not null)
            {
                Destroy(gameObject);
                return;
            }

            var listObjectOfType = FindObjectsOfType<T>();
            if (listObjectOfType.Length == 0)
            {
                // Log Error
                return;
            }

            if (listObjectOfType.Length > 1)
            {
                // Log Error
                return;
            }

            Instance = listObjectOfType[0];
        }
    }
}