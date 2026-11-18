using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipController : MonoBehaviour
{
    public GameObject TopMoveUI;
    public GameObject BottomMoveUI;
    public GameObject LeftMoveUI;
    public GameObject RightMoveUI;

    private bool shipClicked = false;

    private void Start()
    {
        TopMoveUI.SetActive(shipClicked);
        BottomMoveUI.SetActive(shipClicked);
        LeftMoveUI.SetActive(shipClicked);
        RightMoveUI.SetActive(shipClicked);
    }
    void Update()
    {



        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                shipClicked = !shipClicked;

                TopMoveUI.SetActive(shipClicked);
                BottomMoveUI.SetActive(shipClicked);
                LeftMoveUI.SetActive(shipClicked);
                RightMoveUI.SetActive(shipClicked);
            }
            if (hit.collider != null && hit.collider.gameObject == LeftMoveUI)
            {
                this.transform.position = LeftMoveUI.transform.position;
                Debug.Log("yawn");
            }
            if (hit.collider != null && hit.collider.gameObject == RightMoveUI)
            {
                this.transform.position = RightMoveUI.transform.position;
                Debug.Log("yawn");
            }
            if (hit.collider != null && hit.collider.gameObject == TopMoveUI)
            {
                this.transform.position = TopMoveUI.transform.position;
                Debug.Log("yawn");
            }
            if (hit.collider != null && hit.collider.gameObject == BottomMoveUI)
            {
                this.transform.position = BottomMoveUI.transform.position;
                Debug.Log("yawn");
            }
        }




    }
}