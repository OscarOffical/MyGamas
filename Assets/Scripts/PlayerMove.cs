using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public float speed =6f; 

    public  Rigidbody2D phusic;//туда переинести Rigidbody2D
    public bool IsGraund;//проверка столкновение с землей
    public float graubdRadius=0.3f;//позиция земли
    public Transform groundCheck; //позиция ног
    public LayerMask groundMask;//платформа.
    public float HeatherHero = 3; 




    void Update()
    {
        _jumpHero();
         MoveHero(speed);
        FlipHeri();






    }

    private void _jumpHero()
    {
        IsGraund = Physics2D.OverlapCircle(groundCheck.position, graubdRadius, groundMask);//Ресует область от которой можно прыгать
        if (Input.GetKeyDown(KeyCode.Space) && IsGraund)
        {
            phusic.AddForce(new Vector2(0, 350));
        }
    }
    public void MoveHero(float Speed)
    {
        transform.position += new Vector3(Speed, 0, 0) * Time.deltaTime * Input.GetAxisRaw("Horizontal");
    }
    private void FlipHeri()
    {
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
    public void TakeDamagHero(float damag)
    {
        HeatherHero -= damag;
        if (HeatherHero <= 0)
        {
            SceneManager.LoadScene(0);
        }
        
        
    }

   
    
}
