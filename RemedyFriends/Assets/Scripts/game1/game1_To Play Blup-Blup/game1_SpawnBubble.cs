﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 게임 진행 + 점수 계산 한번에
// 위에말고 랜덤생성, 움직임
public class game1_SpawnBubble : MonoBehaviour
{

    // 진주조개 방법으로 도전
    // 그러나 진주조개는 Clone으로 복제해서 랜덤생성하고 이 경우는 각각의 객체에
    // 랜덤 시간값을 줘서 각각이 랜덤생성 되도록 한다.(그래서 랜덤생성 및 삭제함수에서 각각 위치 지정함)

    public bool enableSpawn = false;
    public GameObject Bubble1;
    public GameObject Bubble2;
    public GameObject Bubble3;
    public GameObject Bubble4;
    public GameObject Bubble5;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBubble1", 0, 2.2f);
        InvokeRepeating("SpawnBubble2", 0, 2.1f);
        InvokeRepeating("SpawnBubble3", 0, 2.4f);
        InvokeRepeating("SpawnBubble4", 0, 2.3f);
        InvokeRepeating("SpawnBubble5", 0, 2.35f);
    }


    // Bubble 랜덤생성 및 삭제 함수
    void SpawnBubble1()
    {
        if (enableSpawn)
        {
            GameObject game1_blup_bubble1 = Instantiate(Bubble1, new Vector3(-0.3f, 1.18f, 0), Quaternion.identity);

            // 일정 시간 뒤에 Bubble Clone 삭제
            Destroy(game1_blup_bubble1, 2f);
        }
    }

    void SpawnBubble2()
    {
        if (enableSpawn)
        {
            GameObject game1_blup_bubble2 = Instantiate(Bubble2, new Vector3(4.67f, -2.95f, 0), Quaternion.identity);

            // 일정 시간 뒤에 Bubble Clone 삭제
            Destroy(game1_blup_bubble2, 2f);
        }
    }

    void SpawnBubble3()
    {
        if (enableSpawn)
        {
            GameObject game1_blup_bubble3 = Instantiate(Bubble3, new Vector3(-8.83f, 0.1899997f, 0), Quaternion.identity);

            // 일정 시간 뒤에 Bubble Clone 삭제
            Destroy(game1_blup_bubble3, 2f);
        }
    }

    void SpawnBubble4()
    {
        if (enableSpawn)
        {
            GameObject game1_blup_bubble4 = Instantiate(Bubble4, new Vector2(-5.08f, -3.97f), Quaternion.identity);

            // 일정 시간 뒤에 Bubble Clone 삭제
            Destroy(game1_blup_bubble4, 2f);
        }
    }

    void SpawnBubble5()
    {
        if (enableSpawn)
        {
            GameObject game1_blup_bubble5 = Instantiate(Bubble5, new Vector2(9, -0.5800003f), Quaternion.identity);

            // 일정 시간 뒤에 Bubble Clone 삭제
            Destroy(game1_blup_bubble5, 2f);
        }
    }

}