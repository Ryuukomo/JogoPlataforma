using System.Drawing;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    TextMeshProUGUI texto;
    TextMeshProUGUI texto2;
    Animator anime;
    Transform projetil;
    public float velocidade = 0;
    public float y; 
    public float x;
    public int n = 0;
    int vida;
    public bool estaDireita = true;
    Vector3 vect;


    void Start()
    {
        texto = GameObject.Find("Biscoito").transform.GetComponent<TextMeshProUGUI>();
        texto2 = GameObject.Find("Vida").transform.GetComponent<TextMeshProUGUI>();
        projetil = GameObject.Find("Tiro").transform;
        anime = transform.GetComponent<Animator>();
        
        vect = transform.position;
        vida = 4;
texto2.text = "Vida: <color=green> " + vida + " </color> ";
    }

    // Update is called once per frame
    void Update()
    {
   

        float movimente = Input.GetAxisRaw("Horizontal");
        if (movimente == 1)
        {
            transform.eulerAngles = new Vector2(0, 0);
            estaDireita = true;
            //Instanciado.GetComponent<Projetil>().direcao = new Vector2(1, 0);
        }

        if (movimente == - 1)
        {
            transform.eulerAngles = new Vector2(0, 180);
            estaDireita = false;
        }
     if (Input.GetKeyDown(KeyCode.T) == true )
        {
            Transform Instanciado = Instantiate(projetil);
            Instanciado.position = transform.position;
            Instanciado.GetComponent<Projetil>().enabled = true;


            if (estaDireita == true)
            {
                Instanciado.GetComponent<Projetil>().direcao = new Vector2(1, 0);
            }

            else
            {
                Instanciado.GetComponent<Projetil>().direcao = new Vector2(-1, 0);
            }
        }
        movimente = movimente * velocidade;
        Debug.Log(movimente);

        float pulo = Input.GetAxisRaw("Vertical");
        
        transform.position += new Vector3(movimente * Time.deltaTime, pulo * velocidade * Time.deltaTime);

     
        if (movimente < 0.1f && movimente > -0.1f)
        {
            anime.SetBool("estaAndando", false);
          
        }

        else
        {
            anime.SetBool("estaAndando", true);
           
        }


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if (collision.CompareTag("Abismo"))
        {
            transform.position = vect;
            n = 0;
           
            Debug.Log("Parab�ns !! Voc� pegou:"); 
            
            vida--;
            if (vida == 1)
            {
                
               texto2.text = "Vida: <color=red> " + vida + " </color> ";
            }
            
        }
        if (collision.gameObject.name.Contains("Biscoito") == true)
        {
            n++;
            Destroy(collision.gameObject);
            
            //Debug.Log("Parab�ns !! Voc� pegou:" + n++);
            
            texto.text = "Biscoito: <color=yellow>"+ n +"</color>"; 
        }
    }

}
