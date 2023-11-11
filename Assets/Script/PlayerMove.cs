using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float move = 5f;
    Rigidbody2D rb;
    public Transform Fire;
    public GameObject Bulit;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(move * Input.GetAxis("Horizontal"),rb.velocity.y);
    }

    void Shoot()
    {
        Instantiate(Bulit, Fire.position, Fire.rotation);
    }
}
