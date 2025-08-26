using UnityEngine;

public class MoveVelocity : MonoBehaviour
{

    public float velocidade = 5;
    Rigidbody2D rigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimento = Input.GetAxisRaw("Horizontal");
        rigidbody.linearVelocity += new Vector2(movimento * velocidade * Time.deltaTime, 0);
    }
}
