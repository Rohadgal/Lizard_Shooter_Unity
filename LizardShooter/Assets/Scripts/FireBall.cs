using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    void Awake()
    {
        //Destroy(gameObject, 3);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Destroy(collision.gameObject);
        //Destroy(gameObject);
    }
}
