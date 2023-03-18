using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCanSpawner : MonoBehaviour
{
    private float timer = 0;
    private float maxTime;
    public GameObject trashCan;
    public float height;
    public float destroyTimer;
    public float additionalHeight = 0;

    void Start()
    {
        SpawnTrashCan();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MakeItHarder();
        if (timer > maxTime)
        {
            timer = 0;
            SpawnTrashCan();
        }
        timer += Time.deltaTime;
    }

    private void SpawnTrashCan()
    {
        GameObject newTrashCan = Instantiate(trashCan);
        newTrashCan.transform.position = transform.position + new Vector3(0, Random.Range(-height + additionalHeight, height), 0);
        Destroy(newTrashCan, destroyTimer);
    }
    private void MakeItHarder()
    {
        if (Score.score >= 0)
        {
            maxTime = 2f;
        }
        else if(Score.score > 25)
        {
            maxTime = 1.8f;
        }
        else if (Score.score > 50)
        {
            maxTime = 1.6f;
        }
        else if (Score.score > 75)
        {
            maxTime = 1.4f;
        }
        else if (Score.score > 100)
        {
            maxTime = 1.1f;
        }
    }
}
