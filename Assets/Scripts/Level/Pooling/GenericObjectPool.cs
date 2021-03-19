using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class GenericObjectPool<T> : MonoBehaviour where T : Component

{
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
    private void Add(int count)
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
}






/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class GenericObjectPool<T> : MonoBehaviour where T : Component 

{
    [SerializeField] 
    private T prefab;
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
            AddPoop(1);
        }
        return Objects.Dequeue();
    }
    private void AddPoop(int count)
    {
        for (int i = 0; i < count; i++)
        {
            var newObject = GameObject.Instantiate(prefab);
            newObject.gameObject.SetActive(false);
            Objects.Enqueue(newObject);
        }

    }
    public void ReturnToPool(T ObjectToReturn)
    {

        ObjectToReturn.gameObject.SetActive(false);
        Objects.Enqueue(ObjectToReturn);

    }

}*/

