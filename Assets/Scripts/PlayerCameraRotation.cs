using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraRotation : MonoBehaviour
{
    float xRotation = 0f;
    public float MouseSensitivity = 150f;
    public float rotationPower = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayerWithMouse();
    }

    private void RotatePlayerWithMouse() {

        float mouseX = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(0f, xRotation, 0f);
        transform.Rotate(Vector3.up, mouseX);
    }

    private float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
         return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
}
