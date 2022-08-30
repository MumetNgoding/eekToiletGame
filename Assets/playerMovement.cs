using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D Rb;
    public float ms;
    public float jf;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxisRaw("Horizontal"); // a,d = kiri kanan
        Rb.velocity = new Vector2(ms * horiz, Rb.velocity.y);
        if(Input.GetButtonDown("Jump")) // spasi
        {
            Rb.AddForce(new Vector2(0, jf));
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // statement
        Destroy(gameObject);
    }
}
