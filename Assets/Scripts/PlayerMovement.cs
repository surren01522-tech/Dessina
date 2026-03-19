using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;         //플레이어 이동속도

    public float minX = -14f;            //플레이어가 움직일 수 있는 범위
    public float maxX = 14f;
    public float minZ = -14f;
    public float maxZ = 14f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 moveDir = new Vector3(x, 0f, z).normalized;

        Vector3 nextPosition = transform.position + moveDir * moveSpeed * Time.deltaTime;

        nextPosition.x = Mathf.Clamp(nextPosition.x, minX, maxX);
        nextPosition.z = Mathf.Clamp(nextPosition.z, minZ, maxZ);

        transform.position =  nextPosition;

        if(moveDir != Vector3.zero)
        {
            transform.forward = moveDir;
        }  
    }
}
