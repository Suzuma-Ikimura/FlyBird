using UnityEngine;

public class CreateBG : MonoBehaviour
{
    public GameObject now_bg, bg_create;
    private GameObject new_bg;

    private void Update()
    {
        if (now_bg.transform.position.x <= -1f && new_bg == null)
            CreateBg();
        else if (new_bg != null && new_bg.transform.position.x <= 1f)
            CreateBg();

    }
    private void CreateBg()
    {
        if (now_bg.transform.position.x < -10f) {
            Destroy(now_bg);
            now_bg = new_bg; }

        new_bg = Instantiate(bg_create, new Vector2(20.56f, 0f), Quaternion.identity) as GameObject;

    }

}

