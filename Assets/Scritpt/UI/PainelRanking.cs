using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PainelRanking : MonoBehaviour
{
    [SerializeField]
    private Ranking ranking;
    [SerializeField]
    private GameObject prefabColocado;

    // Start is called before the first frame update
    void Start()
    {
        var listaDeColocados = this.ranking.GetColocados();
        for (var i = 0; i < listaDeColocados.Count; i++)
        {
            if (i >= 5)
            {
                break;
            }          
            var colocado = GameObject.Instantiate(this.prefabColocado, this.transform);
            colocado.GetComponent<ItemRanking>().Configurar(i, listaDeColocados[i].nome, listaDeColocados[i].pontos);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
