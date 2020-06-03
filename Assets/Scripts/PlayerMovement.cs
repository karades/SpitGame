using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    public GameObject stuff;
    private Vector3 playerPosition;
    public float chargeShot;
    // Start is called before the first frame update
    void Start()
    {
        chargeShot = 0.0f;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        moveVelocity = moveInput.normalized*speed;
        shot();
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
    void shot()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            chargeShot += 1250 * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            GameObject clone;
            playerPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            clone = Instantiate(stuff, playerPosition, Quaternion.Euler(transform.up));
            clone.GetComponent<Rigidbody2D>().AddForce(transform.up * chargeShot);
            chargeShot = 0.0f;
        }
    }
}

