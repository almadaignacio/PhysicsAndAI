using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothPhysics : MonoBehaviour
{
    public Cloth a;
    public GameObject _Prefab;

    // Start is called before the first frame update
    void Start()
    {
        Cloth a = GetComponent<Cloth>();
        GameObject Projectile = Instantiate(_Prefab, Vector3.zero, Quaternion.identity) as GameObject;

        var colliders = new ClothSphereColliderPair[1];
        colliders[0] = new ClothSphereColliderPair(Projectile.GetComponent<SphereCollider>());

        a.sphereColliders = colliders; // invoke the setter with the initialized array.Cloth a = GetComponent<Cloth>();
    }

    // Update is called once per frame
    void Update()
    {
            

            
    }
}
