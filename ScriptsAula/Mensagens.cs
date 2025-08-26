using System;
using UnityEngine;

public class Mensagens : MonoBehaviour
{

    // HideInInspector para esconder do inspector as vari�veis p�blicas
    // SerializeField para mostrar vari�veis privadas
    public int level = 500;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Collider2D.Debug.Log("O level iniciou em: "+level);
    }

    // Update is called once per frame
    void Update()
    {
        level++;

        if(level == 1000)
        { 
            Debug.Log("LEVEL UP! Agora t� no n�vel: "+level);
            level = 0;
        }

        if( level == 100)
        {
            MostraNoCem();
        }


    }


    void MostraNoCem()
    {
        Debug.Log("Voc� chegou no level 100. Parab�ns!");
    }


    /*
     
     ATIVIDADE:
        Criar um novo script para fazer o seguinte programa:

        Cria uma vari�vel chamada level que aumenta 1 level a cada update.
        Crie uma nova vari�vel chamada "reset" que conta quantas vezes o 
        level de um jogador chegou no 100.

        Toda vez que o level chega no n�mero 100, a vari�vel reset � incrementada
        e uma mensagem aparece dizendo "Level resetado X vezes!". Al�m disso,
        o level do jogador � resetado e volta para o n�mero 1.

        Crie uma fun��o para atribuir a funcionalidade do que o reset faz.
     
     */


}
