using UnityEngine;

public class Movimentacao : MonoBehaviour
{

    int nivel = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if(nivel == 0 && transform.position.x < 4)
        {
            Debug.Log("Mova o cubo para a direita");
        }else if( nivel == 0 && transform.position.x > 4)
        {
            nivel++;
        }

        if (nivel == 1 && transform.position.y < 4)
        {
            Debug.Log("Mova o cubo para a direita");
        }

    }
}
