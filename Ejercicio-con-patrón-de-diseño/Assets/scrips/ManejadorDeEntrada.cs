using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejadorDeEntrada : MonoBehaviour
{
  
   private IComando comandoSaltar;
   private IComando comandoAtacar;

   private Jugador jugador;

    void Start()
    {
        jugador = FindObjectOfType<Jugador>();

        comandoSaltar = new ComandoSaltar(jugador);
        comandoAtacar = new ComandoAtacar(jugador);
    }

    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 direccionMovimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical);
        if (direccionMovimiento != Vector3.zero)
        {
            jugador.Mover(direccionMovimiento.normalized);
        }



        if(Input.GetKeyDown(KeyCode.Space))
        {
            comandoSaltar.Ejecutar();
        }

        if(Input.GetKeyDown(KeyCode.K))
        {
            comandoAtacar.Ejecutar();
        }
    }
}
