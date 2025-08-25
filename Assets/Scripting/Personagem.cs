using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Personagem : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float velocidade = 5;
    public float velocidadeMaxima = 5;
    public float velocidadeMin = -5;
    public float forcaPulo = 10;
    bool podePular = true;
    
    public Transform pe;
    Rigidbody2D rigidbody;
    void Start()
    {
        rigidbody = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        horizontal = horizontal * velocidade * Time.deltaTime;

        Vector2 movimento = new Vector2(horizontal, 0);

        rigidbody.linearVelocity += movimento;
        rigidbody.linearVelocityX = Mathf.Clamp(rigidbody.linearVelocityX, velocidadeMin, velocidadeMaxima);

        // forma 3 de pulo com raycast

      podePular = Physics2D.Raycast(
            transform.position,
            Vector2.down, 
            0.6f, 
            LayerMask.GetMask("Ground")); 

        // forma 2 de fazer o pulo: verificando sobreposição de colisãoes 

        //if (movimento.x == 0)
        //{
        //    rigidbody.linearVelocityX = 0;
        //}

        //podePular = Physics2D.OverlapBox(
        //   pe.position,
        //   pe.GetComponent<BoxCollider2D>().bounds.size,
        //   0,
        //   LayerMask.GetMask("camadaChao"));
       
        bool pulo = Input.GetButtonDown("Jump");

        if (pulo == true && podePular == true)
        {
            rigidbody.AddForce(new Vector2(0, forcaPulo), ForceMode2D.Impulse);
            podePular = false;
        }
    }

    //forma 1 de pulo com colisão
    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //   // if (collision.gameObject.layer == LayerMask.GetMask("camadaChao"))
    //        if (collision.gameObject.layer == Constrains.camadaChao)
    //    {
    //        podePular = true;
    //    }
    //}


}

