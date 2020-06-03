using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Find all colliders that overlap
        BoxCollider2D myCollider = GetComponent<BoxCollider2D>();
        Collider2D[] otherColliders = Physics2D.OverlapAreaAll(myCollider.bounds.min, myCollider.bounds.max);

        // Check for any colliders that are on top
        bool isUnderneath = false;
        foreach (var otherCollider in otherColliders)
        {
            if (otherCollider.transform.position.z > this.transform.position.z)
            {
                isUnderneath = true;
                break;
            }
        }

        // Take the appropriate action
        if (isUnderneath)
        {
            Debug.Log("HOORAY!");
            Destroy(this.gameObject);
        }
        else
        {
            Debug.Log("OOPS!");
        }
    }

    public void getHit()
    {

    }
}
