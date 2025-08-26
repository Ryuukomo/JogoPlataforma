using UnityEngine;
using UnityEngine.AI;

public class Bots : MonoBehaviour
{

    // Adicionar o componente Nav Mesh Surface e clicar em BAKE
    // No cubo adicionar o componente Nav Mesh Agent
    // Adicionar esse script no cubo
    // --- Não esqueça de atribuir as variáveis publica objetivo e agent
    // Se tiver que pular algo, adicione o Nav Mesh Link


    public Transform objetivo;
    public NavMeshAgent agent;

    float velocidade;

    void Start()
    {

        agent.SetDestination(objetivo.position);

        velocidade = Random.Range(4f, 6f); // use f nos números aqui
        agent.speed = velocidade;

    }

}
