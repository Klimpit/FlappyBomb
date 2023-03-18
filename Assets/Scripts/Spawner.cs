using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float timer = 0;
    private float maxTime = 2f;
    public GameObject tube;
    public float height;
    public float destroyTimer;
    public float additionalHeight = 0;

    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MakeItHarder();
        if (timer > maxTime)
        {
            timer = 0;
            Spawn();
        }
        timer += Time.deltaTime;
    }

    private void Spawn()
    {
        GameObject newTrashCan = Instantiate(tube);
        newTrashCan.transform.position = transform.position + new Vector3(0, Random.Range(-height + additionalHeight, height), 0);
        Destroy(newTrashCan, destroyTimer);
    }
    private void MakeItHarder()
    {
        
    }
}
