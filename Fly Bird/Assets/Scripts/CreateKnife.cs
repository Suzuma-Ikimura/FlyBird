using System.Collections;
using UnityEngine;

public class CreateKnife : MonoBehaviour
{
    [SerializeField] private float waitTime = 1f;
    public GameObject knife;
    private bool isSpawn;

    private void Update()
    {
        if (!isSpawn)
        {
           StartCoroutine(CreateK());
            isSpawn = true;
        }
    }

    private IEnumerator CreateK()
    {
        while (true)
        {
            Instantiate(knife, new Vector2(3.75f, Random.Range(-4.39f, 3.81f)), Quaternion.identity);
            yield return new WaitForSeconds(waitTime);  
        }
    }

}
