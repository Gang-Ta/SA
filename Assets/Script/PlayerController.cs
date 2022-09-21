using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{       
    private RotateToMouse rotateToMouse;        //마우스 이동으로 카메라회전

    private void Awake()
    {
        Cursor.visible = false;         //마우스커서 안보이게
        Cursor.lockState = CursorLockMode.Locked;   //현위치고정

        rotateToMouse = GetComponent<RotateToMouse>();
    }

    private void Update()
    {
        UpdateRotate();
    }
    private void UpdateRotate()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        rotateToMouse.UpdateRotate(mouseX, mouseY);
    }
}
