using UnityEngine;

public class RightMoveDetector : MonoBehaviour
{
    public bool RightDetected = false;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Move Spaces")
        {
            Debug.Log("Right Move Is Detecting Move Space");
            RightDetected = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Move Spaces")
        {
            //Debug.Log("Bottom Move Exited");
            RightDetected = false;
        }
    }
}
