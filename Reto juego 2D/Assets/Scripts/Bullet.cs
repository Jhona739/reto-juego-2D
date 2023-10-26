using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D Rigidbody2D;
    private Vector3 Direction;
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    private void FixedUpdate() 
    {
      Rigidbody2D.velocity = Direction * Speed;       
    }

    public void SetDirection(Vector3 direction)
    {
      Direction = direction;
    }

    public void DestroyBullet()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        maxDuke Masx = other.GetComponent<maxDuke>();
        PlayerMove frog = other.GetComponent<PlayerMove>();
        if (Masx != null)
        {
            Masx.Hit();
        }
        if (frog != null)
        {
            frog.Hit();
        }
        DestroyBullet();
    }
}
