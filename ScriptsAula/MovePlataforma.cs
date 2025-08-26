using UnityEngine;

public class MovePlataforma : MonoBehaviour
{
    public float velocidade = 5f; // Velocidade do movimento da plataforma
    public bool moverHorizontalmente = true; // Se verdadeiro, a plataforma se move na horizontal, caso contrário, se move na vertical
    public float limiteEsquerda = -5f; // Limite esquerdo do movimento
    public float limiteDireita = 5f; // Limite direito do movimento
    public float limiteCima = 5f; // Limite superior do movimento
    public float limiteBaixo = -5f; // Limite inferior do movimento

    private Vector2 movimentoInicial;
    private bool movendoParaDireita = true;
    private bool movendoParaCima = true;

    void Start()
    {
        movimentoInicial = transform.position; // Pega a posição inicial da plataforma
    }

    void Update()
    {
        // Verifica se o movimento é horizontal
        if (moverHorizontalmente)
        {
            // Movimento horizontal (zig-zag)
            if (movendoParaDireita)
            {
                transform.Translate(Vector2.right * velocidade * Time.deltaTime);

                if (transform.position.x >= movimentoInicial.x + limiteDireita)
                    movendoParaDireita = false;
            }
            else
            {
                transform.Translate(Vector2.left * velocidade * Time.deltaTime);

                if (transform.position.x <= movimentoInicial.x + limiteEsquerda)
                    movendoParaDireita = true;
            }
        }
        else
        {
            // Movimento vertical (para cima/baixo)
            if (movendoParaCima)
            {
                transform.Translate(Vector2.up * velocidade * Time.deltaTime);

                if (transform.position.y >= movimentoInicial.y + limiteCima)
                    movendoParaCima = false;
            }
            else
            {
                transform.Translate(Vector2.down * velocidade * Time.deltaTime);

                if (transform.position.y <= movimentoInicial.y + limiteBaixo)
                    movendoParaCima = true;
            }
        }
    }
}
