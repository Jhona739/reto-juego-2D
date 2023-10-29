using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject : MonoBehaviour
{
  private void onCollisionEnter2D(Collision2D collision)
  {
    if(collision.transform.CompareTag("Player"))
    {
        Debug.Log("hola");
        Destroy(collision.gameObject);
    }
  }
}
