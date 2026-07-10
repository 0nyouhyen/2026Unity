using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NEW1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int age = 20;
    int count = 1;
    void Start()
    {
            //연산자
            Debug.Log(10 + 3);
            Debug.Log(10 - 3);
            Debug.Log(10 * 3);
            Debug.Log(10 / 3);
            Debug.Log(10 % 3);
            Debug.Log("나는 " + age + "살");

        if (age>=20)
        {
            Debug.Log("성인입니다.");
        }
        else
        {
            Debug.Log("미성년자입니다. ");
        }
        for (int i = 0; i < 10; i++) ;
        {
            Debug.Log("Start 실행 후: " + i + "번 반복");
        }
        while (count <= 7)
        {
            Debug.Log("Whiel 반복 중: " + count + "번 반복");
        }
    }

// Update is called once per frame
void Update()
    {
        
    }
}
