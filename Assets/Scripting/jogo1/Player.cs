using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float velocidade = 0;
    public float y =  - 6.78f;
    public float x = -4.341884f;
    public int n = 1;
    // Update is called once per frame
    void Update()
    {
        float movimente = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        float pulo = Input.GetAxisRaw("Vertical") * Time.deltaTime;

        transform.position += new Vector3(movimente * velocidade, pulo * velocidade);


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (transform.position.y == - 1 )
        {
            transform.position = new Vector2(x, y);
            
        }
        if (collision.gameObject.name.Contains("Biscoito") == true)
        {
            Destroy(collision.gameObject);
            Debug.Log("Parabéns !! Você pegou:" + n++);
        }
    }

}
