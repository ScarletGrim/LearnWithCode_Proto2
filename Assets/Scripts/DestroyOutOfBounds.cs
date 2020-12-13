using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float topBound = 30f;

    void Update()
    {
        if(transform.position.z > topBound || transform.position.z < -topBound +20)
        {
            Destroy(gameObject);
        }
    }
}
