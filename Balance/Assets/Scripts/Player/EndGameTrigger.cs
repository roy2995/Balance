using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameTrigger : MonoBehaviour
{

    public GameObject EndTheGame;
    public GameObject VolumeZero;
    public GameObject NoTerrein;
    public GameObject OffPlayer;
    public GameObject TrasCanvasPos;

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
        Debug.Log("Trigger");
        EndTheGame.SetActive(true);
        NoTerrein.SetActive(false);
        VolumeZero.SetActive(false);
        OffPlayer.SetActive(false);
        TrasCanvasPos.transform.position = new Vector2(448, 315);

    }

}
