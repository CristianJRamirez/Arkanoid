using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collisionInfo) 	{
        // Destroy the whole Block
        Destroy(gameObject);
    }

}
