using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pontuacao : MonoBehaviour
{
    public int Pontos
    {
        get
        {
            return this.pontos;
        }
    }

    private int pontos;
    [SerializeField]
    private MeuEventoPersonalizado aoPontuar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pontuar()
    {
        this.pontos++;
        this.aoPontuar.Invoke(this.pontos);
    }
}

[Serializable]
public class MeuEventoPersonalizado : UnityEvent<int>
{

}
