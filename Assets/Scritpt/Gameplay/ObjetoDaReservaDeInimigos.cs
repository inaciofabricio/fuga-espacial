using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoDaReservaDeInimigos : MonoBehaviour
{
    private ReservaDeInimigos reservaDeInimigos;

    public void Devolver()
    {
        this.reservaDeInimigos.DevolverInimigo(this.gameObject);
    }

    public void SetReserva(ReservaDeInimigos reservaDeInimigos)
    {
        this.reservaDeInimigos = reservaDeInimigos;
    }
}
