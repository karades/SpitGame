using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    bool coliding;
    // Start is called before the first frame update
    void Start()
    {
        coliding = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getHit()
    {
        if (coliding)
        {
            Debug.Log("Die");
            Destroy(gameObject);
        }
    }
}
