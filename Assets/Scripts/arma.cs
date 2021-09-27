using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arma : MonoBehaviour
{

    public Transform bulletPoint;

    public GameObject balaLaranja;
    public GameObject balaAzul;
    public ControleJogador jogador;

   

    private void Update()
    {
        jogador = FindObjectOfType<ControleJogador>();

        //float newPosition = bulletPoint.transform.localPosition.x; //Recebe 4
       // if (jogador.viradoDireita == true)
       // {
            //newPosition = newPosition * 1; //Inverter o valor, se for negativo vai para positivo e vice e versa
            ///bulletPoint.transform.localPosition = new Vector3(newPosition, bulletPoint.transform.localPosition.y, bulletPoint.transform.localPosition.z);
       // }

       // else if (jogador.viradoDireita == true) 
       // {
          //  newPosition = newPosition * -1; //Inverter o valor, se for negativo vai para positivo e vice e versa
           // bulletPoint.transform.localPosition = new Vector3(newPosition, bulletPoint.transform.localPosition.y, bulletPoint.transform.localPosition.z);


       // }
       // else
       


        


        jogador = FindObjectOfType<ControleJogador>();
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //atirar

            shoot();
        }
                    }
   
        public void shoot()
        {
                    Instantiate(balaAzul, bulletPoint.position, bulletPoint.rotation);
         {


            }
      

        }
    }



