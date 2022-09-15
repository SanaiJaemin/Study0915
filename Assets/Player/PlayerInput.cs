using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Start is called before the first frame update
    public Queue<int> InputsKey = new Queue<int>();

    private int rightIndex = 1;
    private int leftIndex = 2;

    private void Awake()
    {
        
    }
    void Start()
    {
       
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
           
            InputsKey.Enqueue(rightIndex);
            Debug.Log($"{InputsKey.Peek()}");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
           
            InputsKey.Enqueue(leftIndex);
            Debug.Log($"{InputsKey.Peek()}");
        }

    }

 
    
}
