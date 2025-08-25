using UnityEngine;

public class MoveForce : MonoBehaviour
{

    public Rigidbody2D rigidyy;
    
    public float velocidade = 10;
    public float velMaxx = 10;
    public float velMin = 0;
    public float fp = 100;
    public bool pule = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidyy = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        float movimento = Input.GetAxisRaw("Horizontal");
        bool pulo = Input.GetAxisRaw("Jump") > 0;
        rigidyy.AddForce(new Vector2(movimento * velocidade, 0));
      

        rigidyy.linearVelocityX = Mathf.Clamp(rigidyy.linearVelocityX,velMin, velMaxx);

        if (pulo == true && pule == true) 
        {
            rigidyy.AddForce(new Vector2(0, fp));

            pule = false;

            //Invoke("ResetarPulo", 1);
        }

        //if (rigidyy.linearVelocityX >= velMaxx)
        //{
        //    rigidyy.linearVelocityX = velMaxx;
        //}
        //if (rigidyy.linearVelocityX <= velMaxx)
        //{
        //    rigidyy.linearVelocityX = velMaxx;
        //}

    }

    void ResetarPulo()
    {
        pule = true;

    }


    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if(collision.gameObject.name.Contains("Moeda") == true)
    //    {
    //        Destroy(collision.gameObject);
    //    }
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Square(1)") == true)
        {
            pule = true;
        }
    }

}
