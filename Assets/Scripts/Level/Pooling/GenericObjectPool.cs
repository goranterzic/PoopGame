using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenericObjectPool<T> : MonoBehaviour where T : Component
{
   public GameObject ne;
   public GameObject MyProperty { get { return ne; } set { }}

    Vector2 prefabPosition;
    public Vector2 PrefabPosition { get{ return prefabPosition; } set { } }

    [SerializeField]
    private T prefabs;
    private Queue<T> Objects = new Queue<T>();
    public static GenericObjectPool<T> Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public T Get()
    {
        if (Objects.Count == 0)
        {
            Add(1);
        }
        return Objects.Dequeue();
    }
    
   public void Add(int count)
    {
        for (int i = 0; i < count; i++)
        {       
            var newObject = GameObject.Instantiate(prefabs);
            newObject.gameObject.SetActive(false);
            Objects.Enqueue(newObject);
        }
    }

    public void ReturnToPool(T ObjectToReturn)
    {
        ObjectToReturn.gameObject.SetActive(false);
        Objects.Enqueue(ObjectToReturn);
    }

   public void Position(T prefab)
    {
        
        prefabPosition = prefab.transform.position;
        ne = prefab.gameObject;

    }
   
}
