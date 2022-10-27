using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    [SerializeField] int min, seg;
    [SerializeField] Text tiempo;

    private float tiempoRestante;
    public bool enMarcha;

    public GameObject EndGameTriggerByTIME;//make ref. in inspector window

    private void Start()
    {
        tiempoRestante = (min * 60) + seg;
        enMarcha = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (enMarcha)
        {
            //restar segundos
            tiempoRestante -= Time.deltaTime;
            if (tiempoRestante < 1)
            {
                enMarcha = false;
                //llama al script EndGameTrigger y ejecute la función MuertePorTiempo
                EndGameTriggerByTIME.GetComponent<EndGameTrigger>().MuertePorTiempo();
            }
            //para actualizar el temporizador
            int tempMin = Mathf.FloorToInt(tiempoRestante / 60);//obtener minutos
            int tempSeg = Mathf.FloorToInt(tiempoRestante % 60); //obetner segundos
            tiempo.text = string.Format("{00:00}:{01:00}",tempMin,tempSeg);
        }
    }
}
