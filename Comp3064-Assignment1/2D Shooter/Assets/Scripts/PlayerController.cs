/* Author Name: Kushal Parmar
 * Last Modified By: Kushal Parmar
 * Date Last Modified: 10/30/2016
 * Program Description: player movements and player boundary.
 */
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
   
    [SerializeField]
    private float speed = 1;

    private Transform _transform = null;
    private float _playerInput;
    private Vector2 _currentPosition;

    //Constants
    private const float top = 122;
    private const float bottom = -119;
    private const float left = -164;
    private const float right = 405;

    //initialization
    void Start()
    {

        _transform = gameObject.transform;
        _currentPosition = _transform.position;
    }


    void FixedUpdate()
    {

        _currentPosition = gameObject.transform.position;

        //Read Input and move the player object

        _playerInput = Input.GetAxis("Vertical");
        _currentPosition = _transform.position;
        if (_playerInput > 0)
        {
            _currentPosition += new Vector2(0, speed);
        }
        if (_playerInput < 0)
        {
            _currentPosition -= new Vector2(0, speed);
        }
        checkBounds();
        _transform.position = _currentPosition;

        _playerInput = Input.GetAxis("Horizontal");
        _currentPosition = _transform.position;
        //move right
        if (_playerInput > 0)
        {
            _currentPosition += new Vector2(speed, 0);
        }
        //move left
        if (_playerInput < 0)
        {
            _currentPosition -= new Vector2(speed, 0);
        }
        checkBounds();

        _transform.position = _currentPosition;

  
    }
    //Bounds on top,bottom,left,right
    private void checkBounds()
    {
        if (_currentPosition.y < bottom)
        {
            _currentPosition.y = bottom;
        }
        if (_currentPosition.y > top)
        {
            _currentPosition.y = top;
        }
        if (_currentPosition.x < left)
        {
            _currentPosition.x = left;
        }
        if (_currentPosition.x > right)
        {
            _currentPosition.x = right;
        }
    }
}
