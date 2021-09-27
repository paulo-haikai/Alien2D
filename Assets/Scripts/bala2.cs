using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala2 : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;
    
    private ControleJogador jogador;
    public Animator anim;

    private void Start()
    {

    
        jogador = FindObjectOfType<ControleJogador>();
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        destruirPorTempo();

        if (jogador.viradoDireita == true)
        {

            rb.velocity = transform.right * speed;

        }
        else if (jogador.viradoDireita == false)
        {


            rb.velocity = (transform.right * -1) * speed;
        }


        if (jogador.arma == 0)
        {

            anim.SetInteger("tiro", 0);
        }

        else if (jogador.arma > 0)

            anim.SetInteger("tiro", 1);
        }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
            anim.SetInteger("explosao", 1);  
            Destroy(gameObject);
    }

    private void destruirPorTempo()
    {
        Destroy(gameObject, 3f);

    }
    


}
