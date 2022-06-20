using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;

    // "awake" is called when the script instance is being laoded.
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // This is for movement (kind of like awake).
    private void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y); // (x, y, z)

        if (Input.GetKey(KeyCode.Space))
            body.velocity = new Vector2(body.velocity.x, speed);

    }




}
