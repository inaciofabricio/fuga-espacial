using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir : MonoBehaviour
{
    [SerializeField]
    private Transform alvo;
    [SerializeField]
    private float forca;
    private Rigidbody2D fisica;

    private void Awake()
    {
        this.fisica = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (this.alvo != null)
        {
            var deslocamento = alvo.position - this.transform.position;
            deslocamento = deslocamento.normalized;
            deslocamento *= this.forca;
            this.fisica.AddForce(deslocamento, ForceMode2D.Force);
        }
    }

    internal void SetAlvo(Transform alvo)
    {
        this.alvo = alvo;
    }
}
