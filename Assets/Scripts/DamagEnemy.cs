using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DamagEnemy : MonoBehaviour
{
  
    public float Damag = 1f;
    public  void Start()
    {
       
    }
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.position -= new Vector3(2f, 0, 0);
            collision.gameObject.GetComponent<PlayerMove>().TakeDamagHero(Damag);
        }
    }

 

}
