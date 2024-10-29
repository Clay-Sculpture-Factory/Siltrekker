using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shijiao : MonoBehaviour
{
    // Start is called before the first frame update
    public float mouseSensitivity = 2f; // 鼠标灵敏度

    private float rotationX = 0f; // 俯仰角度
    private CharacterController characterController;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked; // 锁定鼠标光标
    }

    // Update is called once per frame
    void Update()
    {
        // 获取鼠标输入
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f); // 限制俯仰角度

        // 应用旋转
        transform.localRotation = Quaternion.Euler(rotationX, transform.localEulerAngles.y + mouseX, 0);
    }
}
