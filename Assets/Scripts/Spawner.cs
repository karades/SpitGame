using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy;
    private Vector3 playerPosition;
    private float timing;
    public float speed;
    public float timeInterval;
    // Start is called before the first frame update
    void Start()
    {
        timing = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timing += 1 * Time.deltaTime;
        if (timing >= timeInterval)
        {
            spawn();
            timing = 0;
        }
    }
    void spawn()
    {

            GameObject clone;
            playerPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            clone = Instantiate(Enemy, playerPosition, Quaternion.Euler(transform.right));
            clone.GetComponent<Rigidbody2D>().AddForce(-transform.right * speed);

    }
}
