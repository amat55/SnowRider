using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float tourqeSpeed = 5f;
    Rigidbody2D rb2d;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(tourqeSpeed);
        }
        else if( Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-tourqeSpeed);
        }
    }
}
