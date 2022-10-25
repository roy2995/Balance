using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("boxes Prefabs")]
    [SerializeField] private GameObject[] boxes;

    public float swarmerInterval = 3.5f;

    public Transform spawnerPosition;
    private float balanceStickLeftLimitDistance = -29f, balanceStickRightLimitDistance = 29f;
    private float leftCubeSpawnPosition, rightCubeSpawnPosition;

    private IEnumerator spawnMinion(float intreval, GameObject box) {
        leftCubeSpawnPosition = balanceStickLeftLimitDistance + spawnerPosition.position.x;
        rightCubeSpawnPosition = balanceStickRightLimitDistance + spawnerPosition.position.x;

        yield return new WaitForSeconds(intreval);
        GameObject newMinion = Instantiate(box, new Vector3(Random.Range(leftCubeSpawnPosition, rightCubeSpawnPosition), spawnerPosition.position.y, spawnerPosition.position.z), Quaternion.identity);
        StartCoroutine(spawnMinion(intreval, box));

    }

    private void Start() {
        //only test
        StartCoroutine(spawnMinion(swarmerInterval,boxes[0]));
    }
}
