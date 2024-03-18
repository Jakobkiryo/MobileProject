using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomObjectSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            SpawnRandomObject();
        }
    }
    
    PrimitiveType GetRandomRandomPrimitiveType()
    {
        switch (Random.Range(0, 4))
        {
            case 0: return PrimitiveType.Capsule;
            case 1: return PrimitiveType.Cube;
            case 2: return PrimitiveType.Cylinder;
            case 3: return PrimitiveType.Sphere;
            default: throw new IndexOutOfRangeException();
        }
        
    }
    
    void SpawnRandomObject()
    {
        var o = GameObject.CreatePrimitive(GetRandomRandomPrimitiveType());
        o.AddComponent<Rigidbody>();
        
    }
}
