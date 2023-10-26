using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maxDuke : MonoBehaviour
{
   public GameObject BulletPrefab;
   public GameObject Frog;
   private float LastShoot;
   private int Health = 5;

   private void Update()
   {
    Vector3 direction = Frog.transform.position - transform.position;
    if(direction.x >= 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    else transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);

    float distance = Mathf.Abs(Frog.transform.position.x - transform.position.x);

    if(distance < 1.0f && Time.time > LastShoot + 0.25f)
    {
        Shoot();
        LastShoot = Time.time;
    }

   } 
   private void Shoot()
    {
        Vector3 direction;
        if (transform.localScale.x == 1.0f) direction = Vector3.right;
        else direction = Vector3.left;

        GameObject bullet = Instantiate(BulletPrefab, transform.position + direction * 0.1f, Quaternion.identity);
        bullet.GetComponent<Bullet>().SetDirection(direction);
    }
    
    public void Hit()
    {
        Health -= 1;
        if (Health == 0) Destroy(gameObject);
    }
}
