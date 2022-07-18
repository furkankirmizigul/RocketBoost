using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMover : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Asteroid speed")]
    private float speed;

    void Start()
    {
        
    }

   
    void Update()
    {
        transform.position += (new Vector3(0,0.5f, 0)*Time.deltaTime* speed);   
    }
}
