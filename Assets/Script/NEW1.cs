using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NEW1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int age = 20;
    void Start()
    {
            //연산자
            Debug.Log(10 + 3);
            Debug.Log(10 - 3);
            Debug.Log(10 * 3);
            Debug.Log(10 / 3);
            Debug.Log(10 % 3);
            Debug.Log("나는 " + age + "살");
        }

// Update is called once per frame
void Update()
    {
        
    }
}
