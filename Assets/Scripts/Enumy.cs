using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumy : MonoBehaviour
{
    private float speed = 2.5f;
    public float heather = 5f;

    // Update is called once per frame
    void Update()
    {
        _moveEnumy();
        _destroyDeadEnemy();


    }

    public void TakeDamag(float damag)
    {
        heather-= damag;
    }
    private void _moveEnumy()
    {
        transform.Translate(speed * Time.deltaTime, 0f, 0f);

        if (transform.position.x >= 18f)
        {
            speed = -speed;
        }

        if (transform.position.x <= 2f)
        {
            speed = 2.5f;
        }
    }
    public void _destroyDeadEnemy()
    {
        if (heather <= 0)
        {
            Destroy(gameObject);
        }
    }
}
