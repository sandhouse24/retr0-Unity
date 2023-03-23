using UnityEngine;

// 왼쪽 끝으로 이동한 배경을 오른쪽 끝으로 재배치하는 스크립트
public class BackgroundLoop : MonoBehaviour 
{
    private float width; // 배경의 가로 길이

    private void Awake() //start()와 같이 초기 1회 자동 실행되는 유니티 이벤트 메서드지만 실행 시점이 한 프레임 더 빠름
    {
        BoxCollider2D backgroundCollider = GetComponent<BoxCollider2D>();
        width = backgroundCollider.size.x;
    }

    private void Update() 
    {
        if (transform.position.x <= -width)
            Reposition();
    }

    // 위치를 리셋하는 메서드
    private void Reposition() 
    {
        Vector2 offset = new Vector2(width * 2f, 0);
        transform.position = (Vector2) transform.position + offset;
    }
}