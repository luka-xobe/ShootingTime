using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] Transform playerCamera = null;
    [SerializeField] float mouseSensetivity = 3.5f;

    float cameraPitch = 0.0f;
    //public float mouseSensetivity = 100f;

    //public Transform playerBody;

    //float xRotation = 0f;
    //float yRotation = 0f;

    //private Vector3 rotateValue;

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //float mouseX = Input.GetAxis("Mouse X") * mouseSensetivity * Time.deltaTime;
        //float mouseY = Input.GetAxis("Mouse Y") * mouseSensetivity * Time.deltaTime;

        //xRotation -= mouseY;
        //yRotation += mouseX;
        //xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //Vector3 LeftRihgtLook = new Vector3(0f, mouseY, 0f);

        //transform.localRotation = Quaternion.Euler(mouseX, 0f, 0f);
        //playerBody.Rotate(Vector3.up * mouseX);
        //playerBody.Rotate(Vector3.left * mouseY);

        //rotateValue = new Vector3(mouseX, mouseY, 0);
        //transform.eulerAngles = transform.eulerAngles - rotateValue;



        //Vector3 moveX = new Vector3(mouseX, 0f, 0f);
        //Vector3 moveY = new Vector3(0f, mouseY, 0f);

        //playerBody.Rotate(Vector3.up * mouseX);
        // playerBody.Rotate(Vector3.down * -mouseX);
        // playerBody.Rotate(Vector3.up * mouseY);
        // playerBody.Rotate(Vector3.left * -mouseY);

        UpdateMouseLook();
    }



    void UpdateMouseLook()
    {
        Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        cameraPitch -= mouseDelta.y * mouseSensetivity;

        cameraPitch = Mathf.Clamp(cameraPitch, -90.0f, 90.0f);

        playerCamera.localEulerAngles = Vector3.right * cameraPitch;

        transform.Rotate(Vector3.up * mouseDelta.x * mouseSensetivity);
    }
}
