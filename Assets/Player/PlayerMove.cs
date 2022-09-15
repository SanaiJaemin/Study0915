using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private Transform startPosition;
    [SerializeField]
    private Transform endPosition;

    public PlayerInput _playerInput;

    void Start()
    {

    }

    private void Update()
    {


        if (_playerInput.InputsKey.Peek() == 1) // 인덱스가 0이거나 스타트좌표일때
        {
            transform.position = Vector3.Lerp(transform.position, endPosition.position, Time.deltaTime);

            if (transform.position == endPosition.position )
            {
                _playerInput.InputsKey.Dequeue();

            }


        }
        else if (_playerInput.InputsKey.Peek() == 2)
        {
            transform.position = Vector3.Lerp(transform.position, startPosition.position, Time.deltaTime);
            if (transform.position == startPosition.position)
            {
                _playerInput.InputsKey.Dequeue();

            }

        }



    }


}
