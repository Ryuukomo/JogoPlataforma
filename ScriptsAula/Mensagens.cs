using System;
using UnityEngine;

public class Mensagens : MonoBehaviour
{

    // HideInInspector para esconder do inspector as variáveis públicas
    // SerializeField para mostrar variáveis privadas
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
            Debug.Log("LEVEL UP! Agora tá no nível: "+level);
            level = 0;
        }

        if( level == 100)
        {
            MostraNoCem();
        }


    }


    void MostraNoCem()
    {
        Debug.Log("Você chegou no level 100. Parabéns!");
    }


    /*
     
     ATIVIDADE:
        Criar um novo script para fazer o seguinte programa:

        Cria uma variável chamada level que aumenta 1 level a cada update.
        Crie uma nova variável chamada "reset" que conta quantas vezes o 
        level de um jogador chegou no 100.

        Toda vez que o level chega no número 100, a variável reset é incrementada
        e uma mensagem aparece dizendo "Level resetado X vezes!". Além disso,
        o level do jogador é resetado e volta para o número 1.

        Crie uma função para atribuir a funcionalidade do que o reset faz.
     
     */


}
