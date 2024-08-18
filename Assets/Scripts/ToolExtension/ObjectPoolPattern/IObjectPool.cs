using UnityEngine;
using Object = UnityEngine.Object;

namespace ToolExtension.ObjectPoolPattern
{
    public interface IObjectPool
    {
        bool TryCreatePool(Object prefab, out int poolId, uint capacity = 1);

        void Recycle(int poolId, GameObject obj);

        bool TryGetObjectFromPool(int poolId, out GameObject go);

        bool TryGetObjectFromPool(Object prefab, out GameObject go);

        void ClearPool();
    }

    public interface IObjectInPool
    {
        int PoolID { get; }
        void Recycle();
    }
}