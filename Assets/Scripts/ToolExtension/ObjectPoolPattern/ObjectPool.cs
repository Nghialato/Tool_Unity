using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Object = UnityEngine.Object;

namespace ToolExtension.ObjectPoolPattern
{
    public class ObjectPool : MonoBehaviour, IObjectPool
    {
        private static readonly Dictionary<int, Stack<GameObject>> _objectPools = new(512);
        private static readonly Dictionary<int, Object> _prefabPools = new(512);
        
        public int CreatePool(Object prefab, uint capacity = 1)
        {
            var poolID = prefab.GetInstanceID();

            if (_prefabPools.ContainsKey(poolID))
                return poolID;

            var stack = new Stack<GameObject>();

            for (var i = 0; i < capacity; i++)
            {
                if (false == CreateObject(prefab, out var go))
                {
                    break;
                }

                go.SetActive(false);
                stack.Push(go);
            }

            _prefabPools.Add(poolID, prefab);
            _objectPools.Add(poolID, stack);

            return poolID;
        }
        
        private bool CreateObject(Object prefab, out GameObject go)
        {
            go = Instantiate(prefab) as GameObject;

            if (go == null)
            {
                Debug.LogError($"Cant create object prefab: {(prefab == null ? "NULL" : prefab.name)}");
                return false;
            }

            // init obj in pool
            var objInPool = go.GetOrAddComponent<ObjectInPool>();
            objInPool.InitPool(prefab.GetInstanceID(), this);

            return true;
        }
        
        public bool TryCreatePool(Object prefab, out int poolId, uint capacity = 1)
        {
            throw new System.NotImplementedException();
        }

        public void Recycle(int poolId, GameObject obj)
        {
            if (_objectPools.ContainsKey(poolId) == false)
                throw new Exception($"Cant Found Pool ID: {poolId}");

            obj.SetActive(false);
            _objectPools[poolId].Push(obj);
        }

        public bool TryGetObjectFromPool(int poolId, out GameObject go)
        {
            throw new System.NotImplementedException();
        }

        public bool TryGetObjectFromPool(Object prefab, out GameObject go)
        {
            throw new System.NotImplementedException();
        }

        public void ClearPool()
        {
            throw new System.NotImplementedException();
        }
    }
}