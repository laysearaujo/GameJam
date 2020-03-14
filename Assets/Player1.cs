using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    private Rigidbody2D fisica;

    public float forcaSubir = 5;
    public float forcaPular = 5;
    public int velocidade;
    
    private int aux = 0;

    private void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetButtonDown("Vertical"))
        {
            aux = 1;
            this.Impulsionar();
        }

        if (Input.GetButtonDown("Jump"))
        {
            aux = 2;
            this.Impulsionar();
        }

        float movimento = Input.GetAxis("Horizontal"); 
        GetComponent<Rigidbody2D>().velocity = new Vector2(movimento * velocidade, GetComponent<Rigidbody2D>().velocity.y);

    }
    
    private void Impulsionar()
    {
        if(aux == 1)
        {
            this.fisica.AddForce(Vector2.up * this.forcaSubir, ForceMode2D.Impulse);
            aux = 0;
        }
        if(aux == 2) 
        {
            this.fisica.AddForce(Vector2.up * this.forcaPular, ForceMode2D.Impulse);
            aux = 0;
        }
        
    }

}

