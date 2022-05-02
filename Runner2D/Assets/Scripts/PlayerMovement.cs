using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float jumpSpeed;
    private bool isOnGround;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * moveSpeed);

        if(Input.GetKeyDown(KeyCode.Space) )
        {

            rb.AddForce(Vector2.up * jumpSpeed);
            isOnGround = false;
            Debug.Log("Space Pressed" + rb.velocity);
        }

    }
}
