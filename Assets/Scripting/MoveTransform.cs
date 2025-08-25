using UnityEngine;

public class MoveTransform : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float velocidade = 5;

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.D))
        //  {
        //      transform.position += (Vector3)new Vector2(velocidade * Time.deltaTime, 0);

        //  }  


        float movimento = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        float voar = Input.GetAxisRaw("Vertical") * Time.deltaTime;

        transform.position += new Vector3(movimento * velocidade, voar * velocidade);

       
   
    }
}
