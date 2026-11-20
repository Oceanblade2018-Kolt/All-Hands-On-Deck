using UnityEngine;

public class TopMoveDetector : MonoBehaviour
{
    public bool TopDetected = false;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /*private void OnCollisionEnter(Collision2D collision)
    {
        if (collision.gameObject.tag == "Move Spaces")
        {
            TopDetected = true;
        }
    }*/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Move Spaces")
        {
            Debug.Log("Top Move Is Detecting Move Space");
            TopDetected = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Move Spaces")
        {
            //Debug.Log("Bottom Move Exited");
            TopDetected = false;
        }
    }
}
