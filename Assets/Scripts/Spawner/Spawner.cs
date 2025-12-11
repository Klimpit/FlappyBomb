using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour, IObserver
{
    private float timer = 0;
    public static float maxTime;
    public GameObject tube;
    [SerializeField] private GameObject trigger;
    [SerializeField] private float height;
    [SerializeField] private float destroyTimer;
    [SerializeField] private float additionalHeight;
    [SerializeField] private int scoreMetter;

    private void Awake()
    {
        maxTime = 2f;
    }
    
    private IEnumerator Spawn(GameObject newObject)
    {
        yield return new WaitForSeconds(1f);
        while (true)
        {
            GameObject copyOfNewObject = Instantiate(newObject);
            copyOfNewObject.transform.position = transform.position + new Vector3(0, Random.Range(-height + additionalHeight, height), 0);
            Destroy(copyOfNewObject, destroyTimer);

            yield return new WaitForSeconds(maxTime);
        }
    }
    private void Spawn(GameObject newObject, float additionalCondition, int secondAdditionalCondition)
    {
        if(additionalCondition % secondAdditionalCondition == 0 && additionalCondition != 0)
        {
            if (timer > 1)
            {
                timer = 0;
                GameObject copyOfNewObject = Instantiate(newObject);
                copyOfNewObject.transform.position = transform.position + new Vector3(0, Random.Range(-height + additionalHeight, height), 0);
                Destroy(copyOfNewObject, destroyTimer);
            }
            timer += Time.deltaTime;
        }
    }
    public static void ChangeTimer(ref float timer)
    {
        timer -= 0.10f;
    }
    public void UpdateOnStartGame()
    {
        StartCoroutine(Spawn(tube));
    }
    public void UpdateOnEndGame()
    {
        Destroy(this);
    }
}
