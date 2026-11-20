using UnityEngine;

public class BottomMoveDetector : MonoBehaviour
{
    public bool BottomDetected = false;


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
            Debug.Log("Bottom Move Is Detecting Move Space");
            BottomDetected = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Move Spaces")
        {
            //Debug.Log("Bottom Move Exited");
            BottomDetected = false;
        }
    }
}
