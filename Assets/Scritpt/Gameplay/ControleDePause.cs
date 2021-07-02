using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDePause : MonoBehaviour
{
    [SerializeField]
    private GameObject painelPause;
    [SerializeField, Range(0,1)]
    private float escalaDeTempoDurantePause;
    private bool jogoEstaParado;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.EstaoTocandoNaTela())
        {
            if (this.jogoEstaParado)
            {
                this.ContinuarJogo();
            }
        }
        else
        {
            if (!this.jogoEstaParado)
            {
                this.PararJogo();
            }
        }
    }

    private void PararJogo()
    {
        this.painelPause.SetActive(true);
        this.MudarEscalaDeTempo(this.escalaDeTempoDurantePause);
        this.jogoEstaParado = true;
    }

    private void ContinuarJogo()
    {
        StartCoroutine(EsperarEContinuarJogo());
    }

    private IEnumerator EsperarEContinuarJogo()
    {
        yield return new WaitForSecondsRealtime(0.2f);
        this.painelPause.SetActive(false);
        this.MudarEscalaDeTempo(1f);
        this.jogoEstaParado = false;
    }

    private bool EstaoTocandoNaTela()
    {
        return Input.touchCount > 0;
    }

    private void MudarEscalaDeTempo(float escala)
    {
        Time.timeScale = escala;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
    }
}
