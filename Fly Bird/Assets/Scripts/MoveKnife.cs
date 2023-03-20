using UnityEngine;

public class MoveKnife : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime, Space.World);

        if (transform.position.x < -8.38f)
            Destroy(gameObject);
    }

}
