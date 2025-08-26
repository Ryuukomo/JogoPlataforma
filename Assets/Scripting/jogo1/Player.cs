using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Transform projetil;
    public float velocidade = 0;
    public float y; 
    public float x;
    public int n = 0;
    public bool estaDireita = true;
    Vector3 vect;


    void Start()
    {
       vect = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
   

        float movimente = Input.GetAxisRaw("Horizontal");
        if (movimente == 1)
        {
            transform.eulerAngles = new Vector2(0, 0);
        }

        if (movimente == - 1)
        {
            transform.eulerAngles = new Vector2(0, 180);
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
        movimente = movimente * Time.deltaTime;

        float pulo = Input.GetAxisRaw("Vertical") * Time.deltaTime;
        
        transform.position += new Vector3(movimente * velocidade, pulo * velocidade);
        
        
       

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Abismo"))
        {
            transform.position = vect;
            n = 0;
            Debug.Log("Parabéns !! Você pegou:");
         
        }
        if (collision.gameObject.name.Contains("Biscoito") == true)
        {
            Destroy(collision.gameObject);
            Debug.Log("Parabéns !! Você pegou:" + n++);
        }
    }

}
