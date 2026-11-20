using Unity.VisualScripting;
using UnityEngine;

public class LeftMoveDetector : MonoBehaviour
{
    public bool LeftDetected = false;


    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "DetectZone")
        {
            Debug.Log("Left Move Is Detecting Move Space");
            LeftDetected = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Move Spaces")
        {
            //Debug.Log("Bottom Move Exited");
            LeftDetected = false;
        }
    }
}
