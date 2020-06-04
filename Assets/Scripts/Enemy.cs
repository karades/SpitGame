using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Score score;
    [SerializeField]
    float points;
    // Start is called before the first frame update
    void Start()
    {

        score = GameObject.Find("Score").GetComponent<Score>();
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
            score.addPoints(points); //add points
            Destroy(this.gameObject);
        }
        else
        {
        }
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    public void getHit()
    {

    }
}
