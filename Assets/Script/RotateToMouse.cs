using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToMouse : MonoBehaviour
{
    [SerializeField]
    private float rotCamXAxisSpeed = 5;     //카메라 x축회전속도
    [SerializeField]
    private float rotCamYAxisSpeed = 3;     //카메라 y축회전속도

    private float limitMinX = -80;          //카메라 x축 최소 회전범위 
    private float limitMaxX = 50;           //카메라 y축 최대 회전범위
    private float eulerAngleX;
    private float eulerAngleY;

    public void UpdateRotate(float mouseX,float mouseY)
    {
        eulerAngleY += mouseX * rotCamYAxisSpeed;       //마우스 좌우 이동 카메라 y축회전
        eulerAngleX -= mouseY * rotCamXAxisSpeed;       //마우스 상하 이동 카메라 x축회전

        eulerAngleX = ClampAngle(eulerAngleX, limitMinX, limitMaxX);      //카메라 x축회전인경우 범위설정

        transform.rotation = Quaternion.Euler(eulerAngleX, eulerAngleY, 0);
    }

    private float ClampAngle(float angle,float min,float max)
    {
        if (angle < -360) angle += 360;
        if (angle > 360) angle -= 360;

        return Mathf.Clamp(angle, min, max);
    }
}
