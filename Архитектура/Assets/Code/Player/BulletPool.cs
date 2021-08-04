using UnityEngine;
using System.Collections.Generic;

public class BulletPool<T> where T : MonoBehaviour
{
    private readonly T _prefab;
    private readonly int _capacityPool;
    private Transform _rootPool;

    private List<T> _pool;
    public BulletPool(T prefab, int capacityPool)
    {
        _prefab = prefab;
        _capacityPool = capacityPool;

        if(!_rootPool)
        {
            _rootPool = new GameObject(Constance.Pool).transform;
        }

        CreatePool();
    }

    private void CreatePool()
    {
        _pool = new List<T>();

        for(int i = 0; i < _capacityPool; i++)
        {
            CreateObjects();
        }
    }

    private T CreateObjects(bool isActive = false)
    {
        var createdObject = Object.Instantiate(_prefab, _rootPool);
        createdObject.gameObject.SetActive(isActive);
        _pool.Add(createdObject);
        return createdObject;
    }

    public bool HasFreeElement(out T element)
    {
        foreach(var bullet in _pool)
        {
            if(!bullet.gameObject.activeInHierarchy)
            {
                element = bullet;
                bullet.gameObject.SetActive(true);
                return true;
            }
        }
        element = null;
        return false;
    }

    public T GetFreeElement()
    {
        if(HasFreeElement(out var element))
        {
            return element;
        }

        return CreateObjects(true);
    }
}

