using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuReturn : MonoBehaviour
{
    public GameObject RestartMenu;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Knife")) {
            Destroy(collision.gameObject);
            Lose();
        }
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void Lose()
    {
        RestartMenu.SetActive(true);
        Time.timeScale = 0f;
    }

}


