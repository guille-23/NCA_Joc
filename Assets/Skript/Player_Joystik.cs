using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_Joystik : MonoBehaviour
{ 
    private Rigidbody2D rb2d;
    public int i = 3;

    public float speed;
    public float jump;
    public GameObject camara;

    public Joystick joystick; // Asegúrate de asignar el joystick desde el Inspector

    private int CheckPoint;

    void Start()
    {
        CheckPoint = 0;
        rb2d = GetComponent<Rigidbody2D>();
        
        
    }

    void Update()
    {
        float moveHorizontal = joystick.Horizontal;
        float moveVertical = joystick.Vertical;

        if (Input.GetKeyDown(KeyCode.JoystickButton0) && rb2d.velocity.y == 0.0f)
        {
            Debug.Log("SALTA");
            Vector2 movement = new Vector2(0.0f, jump);
            rb2d.AddForce(movement);
        }
        else if (moveHorizontal > 0)
        {
            transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
            rb2d.velocity = new Vector3(speed, rb2d.velocity.y, 0.0f);
        }
        else if (moveHorizontal < 0)
        {
            transform.eulerAngles = new Vector3(0.0f, 180.0f, 0.0f);
            rb2d.velocity = new Vector3(-speed, rb2d.velocity.y, 0.0f);
        }
        else
        {
            
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
   
}
 public void Saltar()
    {
        if( rb2d.velocity.y == 0.0f){
            Debug.Log("SALTA");
            Vector2 movement = new Vector2(0.0f, jump);
            rb2d.AddForce(movement);
        }
        
    }
}