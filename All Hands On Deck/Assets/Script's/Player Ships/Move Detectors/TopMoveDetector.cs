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
            TopDetected = true;
        }
    }
}
