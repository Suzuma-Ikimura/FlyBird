using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 targetPos;
    
    public GameObject player;
    [SerializeField] private float Speed = 5f;

    private void Update()
    {
#if UNITY_ANDROID
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                targetPos = Camera.main.ScreenToWorldPoint(touch.position);
            }
        }
#endif

#if UNITY_EDITOR
        if (Input.GetMouseButton(0)) {
            targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
#endif
        if (targetPos.y < -4.40f)
            targetPos.y = -4.40f;

        if (targetPos.y > 3.85f)
            targetPos.y = 3.85f;

        float step = Speed * Time.deltaTime;
        player.transform.position = Vector3.MoveTowards(player.transform.position, new Vector3(player.transform.position.x, targetPos.y, player.transform.position.z), step);
    }
}
