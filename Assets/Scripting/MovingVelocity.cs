using UnityEngine;

public class MovingVelocity : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Update is called once per frame

    public Rigidbody2D rigidy;
    public float velocidade = 3;

    private void Start()
    {
        rigidy = transform.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float movimento = Input.GetAxisRaw("Horizontal");

        rigidy.linearVelocity += new Vector2(movimento * Time.deltaTime * velocidade, 0);

    }
}
