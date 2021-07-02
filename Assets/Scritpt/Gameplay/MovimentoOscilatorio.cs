using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoOscilatorio : MonoBehaviour
{
    private Vector3 posicaoInicial;
    [SerializeField]
    private float amplitude;
    [SerializeField]
    private float velocidade;
    private float angulo;

    // Start is called before the first frame update
    void Awake()
    {
        this.posicaoInicial = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.angulo += this.velocidade;
        var variacao = Mathf.Sin(angulo);
        this.transform.position = this.posicaoInicial + (this.amplitude * variacao * Vector3.up);
    }
}
