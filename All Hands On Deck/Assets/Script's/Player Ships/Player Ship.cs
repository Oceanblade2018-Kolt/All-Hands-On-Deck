using Unity.VisualScripting;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{

    [SerializeField] private GameObject ship;
    [SerializeField] private GameObject TopMoveUI;
    [SerializeField] private GameObject BottomMoveUI;
    [SerializeField] private GameObject LeftMoveUI;
    [SerializeField] private GameObject RightMoveUI;

    void Start()
    {

    }



    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        TopMoveUI.SetActive(true);
        BottomMoveUI.SetActive(true);
        LeftMoveUI.SetActive(true);
        RightMoveUI.SetActive(true);
    }
    private void OnMouseUp()
    {
        TopMoveUI.SetActive(false);
        BottomMoveUI.SetActive(false);
        LeftMoveUI.SetActive(false);
        RightMoveUI.SetActive(false);
    }

}
