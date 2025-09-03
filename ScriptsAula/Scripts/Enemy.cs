using UnityEngine;
using UnityEngine.Video;

public class Enemy : MonoBehaviour
{
    Transform alvo;
    int velocidade = 2;
    int vida = 4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        alvo = GameObject.FindWithTag("Player").transform; 
    }

    // Update is called once per frame
    void Update()
    {
        if ( alvo == null) { return; }

        Vector3 direcao = alvo.position - transform.position;
       
        direcao = direcao.normalized;
        transform.position += direcao * velocidade * Time.deltaTime;

        //dan(1);
    }


    public void dan(int dano)
    {
        vida -= dano;



        if ( vida <= 0 ) { Destroy(gameObject); }
    }
}
