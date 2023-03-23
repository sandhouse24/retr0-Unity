﻿using UnityEngine;

// 발판으로서 필요한 동작을 담은 스크립트
public class Platform : MonoBehaviour {
    public GameObject[] obstacles; // 장애물 오브젝트들
    private bool isScoreAdded = false; // 플레이어 캐릭터가 밟았었는가

    // 컴포넌트가 활성화될때 마다 매번 실행되는 메서드
    private void OnEnable() 
    {
        isScoreAdded = false;
        for (int i = 0; i<obstacles.Length; i++)
        {
            if (Random.Range(0, 3) == 0)
                obstacles[i].SetActive(true);
            else
                obstacles[i].SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player" && !isScoreAdded)
        {
            isScoreAdded = true;
            GameManager.instance.AddScore(1);
        }
    }
}