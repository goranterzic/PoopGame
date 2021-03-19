using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopPoolScript : GenericObjectPool<PoopPrefabScript>
{ /*
    [SerializeField] private PoopPrefabScript poopPrefabScript;
    private Queue<PoopPrefabScript> poopPrefabs = new Queue<PoopPrefabScript>();
    public static PoopPoolScript Instance { get; private set; }
 
    private void Awake()
    {
        Instance = this;    
    }
    public PoopPrefabScript Get() 
    {
        if (poopPrefabs.Count == 0)
        {
            AddPoop(1);
        }
        return poopPrefabs.Dequeue();
    }
    private void AddPoop(int count) 
    {
        for (int i = 0; i < count; i++)
        {
            PoopPrefabScript poopPrefab = Instantiate(poopPrefabScript);
            poopPrefab.gameObject.SetActive(false);
            poopPrefabs.Enqueue(poopPrefab);
        }
    
    }
    public void ReturnToPool(PoopPrefabScript poopPrefab) 
    {

        poopPrefab.gameObject.SetActive(false);
        poopPrefabs.Enqueue(poopPrefab);
    
    }
    */
}
