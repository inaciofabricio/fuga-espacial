using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Gerador : MonoBehaviour
{
    [SerializeField]
    private Transform alvo;
    [SerializeField]
    private float tempo;
    [SerializeField]
    private Rect areaDeGeracao;
    [SerializeField]
    private Pontuacao pontuacao;
    [SerializeField]
    private ReservaDeInimigos reservaDeInimigos;

    private void Start()
    {
        InvokeRepeating("Instanciar", 0f, this.tempo);
    }

    private void Instanciar()
    {
        if (this.alvo != null)
        {
            if (this.reservaDeInimigos.TemInimigo())
            {
                var inimigo = this.reservaDeInimigos.PegarInimigo();
                this.DefinirPosicaoInimigo(inimigo);
                inimigo.GetComponent<Seguir>().SetAlvo(this.alvo);
                inimigo.GetComponent<Pontuavel>().SetPontuacao(this.pontuacao);

            }
        }
    }

    private void DefinirPosicaoInimigo(GameObject inimigo)
    {
        var posicaoAleatoria = new Vector2(
            Random.Range(this.areaDeGeracao.x, this.areaDeGeracao.x + this.areaDeGeracao.width),
            Random.Range(this.areaDeGeracao.y, this.areaDeGeracao.y + this.areaDeGeracao.height)
        );
        var posicaoInimigo = (Vector2) this.transform.position + posicaoAleatoria;
        inimigo.transform.position = posicaoInimigo;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(100, 0, 100);
        var posicao = this.areaDeGeracao.position + (Vector2) this.transform.position + this.areaDeGeracao.size/2;
        Gizmos.DrawWireCube(posicao, this.areaDeGeracao.size);
    }
}
