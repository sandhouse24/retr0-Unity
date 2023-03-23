using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    void Update()
    {
     if (GameManager.instance.isGameover)
            gameObject.SetActive(false);
    }
}
