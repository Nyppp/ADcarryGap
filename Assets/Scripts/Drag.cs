using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour
{
    
    private Rigidbody AlRigidbody;
    private RaycastHit hit;
    private Vector3 Egg_pos; // 선택할 돌의 위치
    private Vector3 Power_pos; // 마우스 버튼을 놓은 위치
    private Vector3 new_pos; // 위 두 지점간의 차이를 저장할 변수
    public static GameObject Egg = null;

    private bool isDead = false;

    /*
    public float speed = 0f;
    private float MaxSpeed = 8000;
    private float MaxDistance = 9000;
    private float MinDistance = 20;
    */

    // Start is called before the first frame update
    void Start()
    {
        AlRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead) return;

        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    private void Die()
    {
        AlRigidbody.velocity = Vector3.zero;
        isDead = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Dead" && !isDead) Die();
    }

    private void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray.origin, ray.direction, out hit))
        {
            Egg = hit.collider.gameObject;
            Egg_pos = Input.mousePosition;
            Debug.Log("알 선택");
        }
    }   

    private void OnMouseUp()
    {
        Power_pos = Input.mousePosition;
        new_pos = new Vector3((Egg_pos.x - Power_pos.x), 0, (Egg_pos.y - Power_pos.y));

        if (AlggagiManager.shoot == true)
        {
            AlRigidbody.AddForce(new_pos * 20);
            AlggagiManager.shoot = false;
        }
    }

}
