using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float firstTimer = 3;
    private float secondTimer = 0;
    public static float maxTime;
    public GameObject tube;
    [SerializeField] private GameObject trigger;
    [SerializeField] private float height;
    [SerializeField] private float destroyTimer;
    [SerializeField] private float additionalHeight = 0;
    [SerializeField] private int scoreMetter;

    private void Awake()
    {
        maxTime = 2f;
    }
    void Start()
    {
        Spawn(tube);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Spawn(tube);
        Spawn(trigger, Score.score, 25);
    }

    private void Spawn(GameObject newObject)
    {
        if (firstTimer > maxTime)
        {
            firstTimer = 0;
            GameObject copyOfNewObject = Instantiate(newObject);
            copyOfNewObject.transform.position = transform.position + new Vector3(0, Random.Range(-height + additionalHeight, height), 0);
            Destroy(copyOfNewObject, destroyTimer);
        }
        firstTimer += Time.deltaTime;
    }
    private void Spawn(GameObject newObject, float additionalCondition, int secondAdditionalCondition)
    {
        if(additionalCondition % secondAdditionalCondition == 0 && additionalCondition != 0)
        {
            if (secondTimer > 1)
            {
                secondTimer = 0;
                GameObject copyOfNewObject = Instantiate(newObject);
                copyOfNewObject.transform.position = transform.position + new Vector3(0, Random.Range(-height + additionalHeight, height), 0);
                Destroy(copyOfNewObject, destroyTimer);
            }
            secondTimer += Time.deltaTime;
        }
    }
    public static void ChangeTimer(ref float timer)
    {
        timer -= 0.10f;
    }
}
