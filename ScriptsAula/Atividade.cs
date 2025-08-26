using UnityEngine;

public class Atividade : MonoBehaviour
{

    public int level = 0;
    public int reset = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        level = 1;
    }

    // Update is called once per frame
    void Update()
    {
        level++;

        if(level == 100)
        {
            Resetar();
        }

    }

    void Resetar()
    {
        reset++;
        level = 0;
        Debug.Log("Você resetou " + reset + " vezes!");
    }

}
