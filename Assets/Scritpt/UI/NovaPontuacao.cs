using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NovaPontuacao : MonoBehaviour
{
    [SerializeField]
    private TextoDinamico textoPontuacao;
    [SerializeField]
    private TextoDinamico textoNome;
    [SerializeField]
    private Ranking ranking;

    private string id;
    private Pontuacao pontuacao;

    void Start()
    {
        int totalDePontos = this.GetPontuacao();
        this.textoPontuacao.AtualizarTexto(totalDePontos);
        string nomeJogador = this.GetNome();
        this.textoNome.AtualizarTexto(nomeJogador);
        this.id = this.ranking.AdicionarPontuacao(totalDePontos, nomeJogador);
    }

    private string GetNome()
    {
        if (PlayerPrefs.HasKey("UltimoJogador"))
        {
            return PlayerPrefs.GetString("UltimoJogador");
        }
        else
        {
            return "Jogador";
        }
    }

    private int GetPontuacao()
    {
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
        var totalDePontos = 0;
        if (this.pontuacao != null)
        {
            totalDePontos = this.pontuacao.Pontos;
        }

        return totalDePontos;
    }

    public void AlterarNome(string nome)
    {
        this.ranking.AlterarNome(nome, this.id);
        PlayerPrefs.SetString("UltimoJogador", nome);
    }
}
