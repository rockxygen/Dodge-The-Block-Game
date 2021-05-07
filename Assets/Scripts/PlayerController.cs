using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 12f;
    public float mapWidth = 5f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal") * Time.fixedDeltaTime * playerSpeed;
        Vector2 newPosition = rb.position + Vector2.right * x;
        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);
        rb.MovePosition(newPosition);
    }

    void OnCollisionEnter2D()
    {
        Debug.Log("Shot");
        FindObjectOfType<GameController>().EndGame();
    }
}
