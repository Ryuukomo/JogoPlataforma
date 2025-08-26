using UnityEngine;

public class CharTest : MonoBehaviour
{

    public float velocidade = 5;
    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float movimento = Input.GetAxisRaw("Horizontal");
        rb.AddForce(new Vector3(movimento * velocidade, 0, 0));

        if(rb.linearVelocity.x > 3 || rb.linearVelocity.x < -3)
        {
            rb.linearVelocity = new Vector3(3, 0, 0);
        }

    }

    //// Update is called once per frame
    //void Update()
    //{
    //    float movimento = Input.GetAxisRaw("Horizontal");
    //    rb.linearVelocity = new Vector3(movimento * velocidade, 0, 0);
    //}

}
