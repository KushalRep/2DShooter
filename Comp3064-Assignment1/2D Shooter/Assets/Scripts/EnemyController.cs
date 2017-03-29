/* Author Name: Kushal Parmar
 * Last Modified By: Kushal Parmar
 * Date Last Modified: 10/30/2016
 * Program Description: friendly and enemy movement across background.
 */
using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    [SerializeField]
    private float speed = 5f;


    private Vector2 _currentPosition;
    private Transform _transform = null;
    private int direction = 1;

    //Constants
    private const float startPosition = 500;
    private const float resetPosition = -224;


    // Use this for initialization
    void Start()
    {
        _transform = gameObject.transform;
        _currentPosition = _transform.position;
        //Reset();
    }

    void FixedUpdate()
    {

        _currentPosition = _transform.position;

        //move the enemy with the given speed

        _currentPosition -= new Vector2(speed, 0);

        _transform.position = _currentPosition;
        if (_transform.position.x < resetPosition)
        {

            Reset();

        }
    }

    //Rest enemy/friendly position
    public void Reset()
    {
        float currentY = Random.Range(-119, 120);
        _currentPosition = new Vector2((startPosition), currentY);
        _transform.localScale = new Vector2(direction, 1);
        _transform.position = _currentPosition;

    }

}
