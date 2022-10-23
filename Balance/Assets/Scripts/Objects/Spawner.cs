using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("boxes Prefabs")]
    [SerializeField] private GameObject[] boxes;

    public float swarmerInterval = 3.5f;


    private IEnumerator spawnMinion(float intreval, GameObject box){
        yield return new WaitForSeconds(intreval);
        GameObject newMinion = Instantiate(box, new Vector3(Random.Range(-1.5f, 1.5f), 3.5f, 0), Quaternion.identity);
        StartCoroutine(spawnMinion(intreval, box));
    }

    private void Start() {
        //only test
        StartCoroutine(spawnMinion(swarmerInterval,boxes[0]));
    }
}
