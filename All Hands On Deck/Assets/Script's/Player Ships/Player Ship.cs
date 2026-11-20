using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipController : MonoBehaviour
{
    public GameObject TopMoveUI;
    public GameObject BottomMoveUI;
    public GameObject LeftMoveUI;
    public GameObject RightMoveUI;

    public GameObject TopDetect;
    public GameObject BottomDetect;
    public GameObject LeftDetect;
    public GameObject RightDetect;

    public TopMoveDetector topMoveDetection;
    public BottomMoveDetector bottomDetection;
    public LeftMoveDetector leftMoveDetection;
    public RightMoveDetector rightMoveDetection;

    public float rayDistance = 1f;

    public LayerMask detectLayer;
    
    //GameObject MoveDetector;

    private bool shipClicked = false;

    private void Start()
    {
        TopMoveUI.SetActive(shipClicked);
        BottomMoveUI.SetActive(shipClicked);
        LeftMoveUI.SetActive(shipClicked);
        RightMoveUI.SetActive(shipClicked);
        //MoveDetector = GameObject.FindGameObjectsWithTag("Move Spaces");
    }
    void Update()
    {
        if (topMoveDetection.TopDetected)
        {
            Debug.Log("TopDetectWorking");
        }
            if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            /*Vector2 detect = TopDetect.transform.position;
            RaycastHit2D detection = Physics2D.Raycast(detect, Vector2.right, 1f, detectLayer);

            if(detection.collider != null)
            {
                Debug.Log("Ray Detected");
            }*/

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                shipClicked = !shipClicked;

                //if (topMoveDetection.TopDetected)
                TopMoveUI.SetActive(shipClicked);
                //if (bottomDetection.BottomDetected)
                BottomMoveUI.SetActive(shipClicked);
                //if (leftMoveDetection.LeftDetected)
                LeftMoveUI.SetActive(shipClicked);
                //if (rightMoveDetection.RightDetected)
                RightMoveUI.SetActive(shipClicked);


            }
            if (hit.collider != null && hit.collider.gameObject == LeftMoveUI)
            {
                this.transform.position = LeftMoveUI.transform.position;
                Debug.Log("Left Move UI Clicked");
            }
            if (hit.collider != null && hit.collider.gameObject == RightMoveUI)
            {
                this.transform.position = RightMoveUI.transform.position;
                Debug.Log("Right Move UI Clicked");
            }
            if (hit.collider != null && hit.collider.gameObject == TopMoveUI)
            {
                this.transform.position = TopMoveUI.transform.position;
                Debug.Log("Top Move UI Clicked");
            }
            if (hit.collider != null && hit.collider.gameObject == BottomMoveUI)
            {
                this.transform.position = BottomMoveUI.transform.position;
                Debug.Log("Bottom Move UI Clicked");
            }
        }
    }
}