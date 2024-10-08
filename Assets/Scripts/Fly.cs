using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//requires componenet that without the script would really function
[RequireComponent(typeof(Rigidbody2D))]
public class Fly : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private Rigidbody2D rb;
    public float JumpForce = 6;
    private int point = 0;

    private void Start()
    {
        //gets a rigidbody component with GetComponent
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if(rb.velocity.y < 0)
            { 
                rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse); 
            }

            
            
        }
        //Animations
        if (rb.velocity.y > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 45);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, -45);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        scoreText.text = (++point).ToString("D4");
    }
}
