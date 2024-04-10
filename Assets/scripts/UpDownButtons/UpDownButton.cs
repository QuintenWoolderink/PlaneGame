using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class UpDownButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [Serializable]
    public enum Direction
    {
        Up,Down
    }

    [SerializeField]
    public Direction direction;

    [SerializeField]
    public PlayerControllerX playerController;

    void Start()
    {

        this.gameObject.SetActive(Application.isMobilePlatform);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (direction == Direction.Up)
        {
            playerController.verticalInput = -1;
        }
        else if (direction == Direction.Down)
        {
            playerController.verticalInput = 1;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        playerController.verticalInput = 0;
    }
}