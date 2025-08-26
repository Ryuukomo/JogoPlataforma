using UnityEngine;

public class Rotacionadornator : MonoBehaviour
{

    public bool lateral = false;
    public float velocidade = 5;

    // Update is called once per frame
    void Update()
    {

        if(lateral == false)
        {
            transform.eulerAngles += new Vector3(0, Time.deltaTime * velocidade, 0);
        }
        else
        {
            transform.eulerAngles += new Vector3(0, 0, Time.deltaTime * velocidade);
        }

    }
}
