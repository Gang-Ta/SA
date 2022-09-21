using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{       
    private RotateToMouse rotateToMouse;        //���콺 �̵����� ī�޶�ȸ��

    private void Awake()
    {
        Cursor.visible = false;         //���콺Ŀ�� �Ⱥ��̰�
        Cursor.lockState = CursorLockMode.Locked;   //����ġ����

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
