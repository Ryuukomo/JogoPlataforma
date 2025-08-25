using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float velocidade = 0;
    public float y; 
    public float x;
    public int n = 0;

    Vector3 vect;

    void Start()
    {
       vect = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        float movimente = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        float pulo = Input.GetAxisRaw("Vertical") * Time.deltaTime;

        transform.position += new Vector3(movimente * velocidade, pulo * velocidade);


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Abismo"))
        {
            transform.position = vect;
         Debug.Log("Parabéns !! Você pegou:");
        
        }
        if (collision.gameObject.name.Contains("Biscoito") == true)
        {
            Destroy(collision.gameObject);
            Debug.Log("Parabéns !! Você pegou:" + n++);

     
            }
    }

}
