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
            BottomDetected = true;
        }
    }
}
