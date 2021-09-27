using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipBala : MonoBehaviour
{
    private ControleJogador jogador;
    public SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        jogador = FindObjectOfType<ControleJogador>();

        if (jogador.viradoDireita == true)
        {

            sr.flipX = false;
        }
        else
        {

            sr.flipX = true;
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
