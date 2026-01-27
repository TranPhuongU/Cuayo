using UnityEngine;

public class GroundScrollParent : MonoBehaviour
{
    public float speed = 2f;

    private float totalWidth;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;

        SpriteRenderer[] sprites = GetComponentsInChildren<SpriteRenderer>();

        foreach (var sr in sprites)
        {
            totalWidth += sr.bounds.size.x;
        }
    }

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.x <= startPos.x - totalWidth / 2f)
        {
            transform.position = startPos;
        }
    }
}
