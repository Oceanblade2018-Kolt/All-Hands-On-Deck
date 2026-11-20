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
        if (collision.gameObject.tag == "Move Spaces")
        {
            LeftDetected = true;
        }
    }
}
