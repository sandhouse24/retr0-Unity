using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidbody;
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed; //���� ������Ʈ�� ���� �������� speed��ŭ�� �ӵ�
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();//�扟�� ��� ������Ʈ���� PlayerController ������Ʈ ��������

            if (playerController != null)//PlayerController ������Ʈ�� �������µ� �����ߴٸ�
                playerController.Die();
        }

        if (other.tag == "Wall")
            gameObject.SetActive(false);
    }
}
