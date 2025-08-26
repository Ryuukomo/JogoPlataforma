using UnityEditor.U2D.Aseprite;
using UnityEngine;

public class Personagem : MonoBehaviour
{

    public float velocidade = 5;
    public float velocidadeMaxima = 5;
    public float forcaPulo = 10;
    public float distanciaRaycast = 0.6f;

    bool podePular = true;

    Rigidbody2D rigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        // L�gica do movimento

        float horizontal = Input.GetAxisRaw("Horizontal");
        horizontal = horizontal * velocidade * Time.deltaTime;

        Vector2 movimento = new Vector2(horizontal, 0);

        rigidbody.linearVelocity += movimento;
        rigidbody.linearVelocityX = Mathf.Clamp(rigidbody.linearVelocityX, -velocidadeMaxima, velocidadeMaxima);

        // L�gica do pulo

        // Forma 3 de fazer o pulo: raycast
        podePular = Physics2D.Raycast(
            transform.position,
            Vector2.down,
            distanciaRaycast,
            LayerMask.GetMask("Ground")
        );

        // Forma 2 de fazer o pulo: verificando sobreposi��o de colis�es
        //podePular = Physics2D.OverlapBox(
        //    groundChecker.position,
        //    groundChecker.GetComponent<BoxCollider2D>().bounds.size,
        //    0,
        //    LayerMask.GetMask("Chao")
        //);

        bool pulo = Input.GetButtonDown("Jump");
        if( pulo == true && podePular == true )
        {
            rigidbody.AddForce(new Vector2(0, forcaPulo), ForceMode2D.Impulse);
            podePular = false;
        }

    }

    // Forma 1 de fazer o pulo: com colis�es
    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    //if (collision.gameObject.layer == LayerMask.GetMask("Chao"))
    //    if (collision.gameObject.layer == Constraints.camadaChao)
    //    {
    //        podePular = true;
    //    }
    //}



}




/*
 
    -----|-----|-----| ATIVIDADE |-----|-----|----- 
    
    Criar uma scene nova para fazer a atividade.

    Sua scene deve ter:
    
    1. Um personagem que se move e pula
        -- Voc� N�O DEVE usar o linearVelocity para se mover
        -- Use o addForce ou movimenta��o pelo transform
    
    2. Moedas para serem pegas
        -- Ao pegar uma moeda, mostre o contador no console

    3. Adicione plataformas m�veis horizontais e verticais
        -- ATEN��O: voc� PRECISA criar esse script usando
           o ChatGPT ou outra IA de sua prefer�ncia

    4. Se o personagem cair fora da fase, ele deve perder
        todas as moedas e voltar para o in�cio

    5. Ao chegar no final da fase deve aparecer uma mensagem
        indicando que o jogador venceu




 
 
 */