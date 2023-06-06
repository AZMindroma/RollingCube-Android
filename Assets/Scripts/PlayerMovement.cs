using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigid;

    public float force = 2000f;
    public float sideForce = 500f;

    float screenWidth = Screen.width;

    void FixedUpdate()
    {
        rigid.AddForce(0, 0, force * Time.deltaTime);

        Touch touch = Input.GetTouch(0);
        if (touch.position.x > screenWidth/2)
        {
            rigid.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (touch.position.x < screenWidth / 2)
        {
            rigid.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rigid.position.y < -5f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
        
    }
}
