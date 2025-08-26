using UnityEngine;

public class ZigZag : MonoBehaviour
{

    public bool lateral = true;
    public float velocidade = 5;
    public float distancia = 1;
    
    bool reverso = false;

    // Update is called once per frame
    void Update()
    {

        if(lateral == true)
        {
            if (reverso == false)
            {
                transform.position += new Vector3(Time.deltaTime * velocidade, 0, 0);
                if (transform.position.x > distancia)
                {
                    reverso = true;
                }
            }
            else
            {
                transform.position -= new Vector3(Time.deltaTime * velocidade, 0, 0);
                if (transform.position.x < -distancia)
                {
                    reverso = false;
                }
            }
        }
        else
        {
            if (reverso == false)
            {
                transform.position += new Vector3(0, Time.deltaTime * velocidade, 0);
                if (transform.position.y > distancia)
                {
                    reverso = true;
                }
            }
            else
            {
                transform.position -= new Vector3(0, Time.deltaTime * velocidade, 0);
                if (transform.position.y < -distancia)
                {
                    reverso = false;
                }
            }
        }

        

        

    }
}
