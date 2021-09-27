using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;

public class ControleJogador : MonoBehaviour
{


    public SpriteRenderer sr;
    public Animator anim;
    public float corrida;
    public int arma = 0;
        public bool viradoDireita = true;
    public Sprite balaAzul;
    public Sprite balaLaranja;

    public Image trocaBala;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
        
    {

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            viradoDireita = true;
            transform.position += transform.right * Time.deltaTime * corrida;
            sr.flipX = false;
            anim.SetFloat("velocidade", 40f);
           transform.localScale = new Vector3(0.3f, 0.3f, 1);
        }

        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            //sr.flipX = true;
            transform.localScale = new Vector3(-0.3f, 0.3f, 1);
            viradoDireita = false;

            transform.position -= transform.right * Time.deltaTime * corrida;
                    

            anim.SetFloat("velocidade", 40f);
           
        }
        else
        {
            anim.SetFloat("velocidade", 0f);


            if (Input.GetKey(KeyCode.Alpha1))
                changeArma();


           // if (Input.GetKey(KeyCode.Alpha1))
           if (arma == 0)
            {

                anim.SetInteger("arma", 1);
                arma = 0;
                
            }

            else if (arma > 0)
            {
                anim.SetInteger("arma", 2);
                arma = 1;

            }

            else if (Input.GetKey(KeyCode.Alpha0))
            {
                anim.SetInteger("arma", 0);
                anim.SetInteger("stand", 0);

            }

        }
    }
    private void changeArma()
    {
        //swapBullet.overrideSprite = imgBlueBullet;
        trocaBala.overrideSprite = balaLaranja;
        arma++;
        if (arma > 1)
        {
            // swapBullet.overrideSprite = imgRedBullet;
            trocaBala.overrideSprite = balaAzul;
            arma = 0;
        }
    }
}
