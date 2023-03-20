using UnityEngine;
using UnityEngine.UI;

public class SetBestScore : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Text>().text = "Best Score: " + PlayerPrefs.GetInt("score").ToString();    
    }
}
