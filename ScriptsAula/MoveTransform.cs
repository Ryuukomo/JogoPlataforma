using UnityEngine;

public class MoveTransform : MonoBehaviour
{

    public float velocidade = 5;

    // Update is called once per frame
    void Update()
    {

        float movimento = Input.GetAxis("Horizontal") * Time.deltaTime;
        //float voando = Input.GetAxisRaw("Vertical") * Time.deltaTime;
        transform.position += new Vector3(movimento * velocidade, 0);

    }
}
