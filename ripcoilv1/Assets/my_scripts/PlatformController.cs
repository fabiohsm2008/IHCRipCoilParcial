using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public float paddleSpeed = 10f;
    private float xpose = 0.0f;
    public Vector3 playerPos = new Vector3(0, -22f, -400);

    void Update()
    {
        float xPos = transform.position.x;
        //float xPosaux = 0.0f;
        if (KinectM.instance.IsAvailable)
        {
            xPos = KinectM.instance.PaddlePosition;

        }
        else
        {
            xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
            
        }
        if (xPos > 2)
        {
            xpose += 2.5f;
        }
        else if (xPos < -2)
        {
            xpose -= 2.5f;
        }
        //Debug.Log("xpos: " + xPos);
        // playerPos = new Vector3(Mathf.Clamp(xPos, -200f, 200f), -22f, -400f);
        playerPos = new Vector3(Mathf.Clamp(xpose, -200f, 200f), -22f, -400f);
      //  Debug.Log("playerPos: " + playerPos);
        transform.position = playerPos;
    }
}
