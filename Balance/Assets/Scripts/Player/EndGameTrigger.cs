using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class EndGameTrigger : MonoBehaviour
{

    public GameObject EndTheGame;
    public GameObject VolumeZero;
    public GameObject NoTerrein;
    public GameObject OffPlayer;
    public GameObject TrasCanvasPos;
    public GameObject youLostText;
    public GameObject timeLeftText;

    //public GameObject EndTheGameByTime0;
    public bool youLostByTime = false;
    public TimeController timeController;
    public Score scoreScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        timeController.enMarcha = false;
        
        Debug.Log("Trigger");
        EndTheGame.SetActive(true);
        timeLeftText.SetActive(true);
        NoTerrein.SetActive(false);
        VolumeZero.SetActive(false);
        OffPlayer.SetActive(false);
        TrasCanvasPos.transform.position = new Vector2(448, 315);

    }

    public void MuertePorTiempo()
    {
        Debug.Log("Muerte Por Tiempo");
        EndTheGame.SetActive(true);
        NoTerrein.SetActive(false);
        VolumeZero.SetActive(false);
        OffPlayer.SetActive(false);
        youLostText.SetActive(true);
        TrasCanvasPos.SetActive(false);
    }
}
