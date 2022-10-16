using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private Transform chrBody; // 캐릭터 몸
    
    [SerializeField]
    private Transform cameraBox; // 카메라


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        LookAround();
    }

    void Move()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        bool isMove = (moveInput.magnitude != 0);

        if (isMove)
        {
            Vector3 lookForward = new Vector3(cameraBox.forward.x, 0f, cameraBox.forward.z).normalized;
            Vector3 lookRight = new Vector3(cameraBox.right.x, 0f, cameraBox.right.z).normalized;
            Vector3 moveDir = (lookForward * moveInput.y + lookRight * moveInput.x);


            chrBody.forward = lookForward; // 카메라가 바라보는 방향으로 컨트롤
            // chrBody.forward = moveDir; // 캐릭터가 이동하는 방향으로 컨트롤
            transform.position += moveDir * Time.deltaTime * moveSpeed;
        }
    }
    void LookAround()
    {
        Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X")); // 각각 x, y 축 회전 값
        Vector3 camAngle = cameraBox.rotation.eulerAngles;

        float x = camAngle.x - mouseDelta.x;
        x = Mathf.Clamp(x, -90f, 90f);
        cameraBox.rotation = Quaternion.Euler(x, camAngle.y + mouseDelta.y, camAngle.z);
    }
}
