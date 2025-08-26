using UnityEngine;

public class Movimento : MonoBehaviour
{

    Vector3 posicaoInicial;
    public Vector3 direcao;
    public float velocidade = 0.01f;
    //float redutor = 0.0015f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        posicaoInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += direcao * Time.deltaTime * velocidade;

        if( transform.position.x > 5)
        {
            transform.position = posicaoInicial;
        }

        if( transform.position.y > 2)
        {
            transform.position = posicaoInicial;
        }

        if( transform.position.z > 7.5f)
        {
            transform.position = posicaoInicial;
        }

    }

    /* 
     
        Os cubos devem se movimentar at� uma dist�ncia m�xima.
        M�ximo da posi��o X � 5
        M�ximo da posi��o Y � 2
        M�ximo da posi��o Z � 7.5

        Quando um cubo chegar na sua posi��o m�xima, ele deve ser resetado
        e voltar para sua posi��o original de quando o jogo come�ou.

     */

}
