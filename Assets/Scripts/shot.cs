using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class shot : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D rb;
    private Vector3 shotPosition;
    float lifeTime = 0.8f;
    float timeToDie;
    bool shouldDie;
    float timer;
    void Start()
    {
        shouldDie = false;
        rb = GetComponent<Rigidbody2D>();
        timeToDie = lifeTime;
        timer = 0.0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (shouldDie)
        {
            timer += Time.deltaTime;
            if (timer >= 0.05f)
            {
                Destroy(gameObject);
            }
            
        }
        shotPosition = this.transform.position;
        timeToDie -= Time.deltaTime;
        rb.transform.localScale = scaleCoeff(timeToDie);
        if (rb.transform.localScale.magnitude <= 0.2f)
        {
            shouldDie = true;
            shotPosition.z = 1.0f;
            this.transform.position = shotPosition;
            
                    
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
