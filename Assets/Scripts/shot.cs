using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class shot : MonoBehaviour
{
    // Start is called before the first frame update
    bool yes;
    bool doubleyes;
    private Rigidbody2D rb;
    int count;
    float previousy;
    bool die;
    int scaleMAX = 100;
    int scale;
    float LifeTime = 0.7f;
    float timeToDie;
    void Start()
    {
        previousy = 0;
        count = 0;
        yes = false;
        doubleyes = false;
        rb = GetComponent<Rigidbody2D>();
        die = false;
        scale = 0;
        timeToDie = LifeTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log("Now");
        //rb.bodyType = RigidbodyType2D.Static;
        timeToDie -= Time.deltaTime;
        rb.transform.localScale = scaleCoeff(timeToDie);
        if (rb.transform.localScale.magnitude <= 0.2f)
        {
            die = true;
            Destroy(gameObject);
                    
        }
    }


    bool moving(float previousy)
    {
        float current = rb.position.y;
        if ( previousy > current)
        {
            return true;
        }
        return false;
    }

    Vector3 scaleCoeff(float timeToDie)
    {
        float initScale = 1;
        float coef = (-1) * initScale * Mathf.Pow(timeToDie -1, 4) + initScale;
        return new Vector3(coef, coef, coef);
    }
    
}
