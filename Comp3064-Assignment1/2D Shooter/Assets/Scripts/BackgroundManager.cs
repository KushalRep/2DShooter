/* Author Name: Kushal Parmar
 * Last Modified By: Kushal Parmar
 * Date Last Modified: 10/30/2016
 * Program Description: Scrolls and resets the background to beginning.
 */
using UnityEngine;
using System.Collections;

public class BackgroundManager : MonoBehaviour
{

    [SerializeField]
    float speed = 5f;

    private Transform _transform = null;
    private Vector2 _currentPosition;

    //Constants
    private const float startPos = 312f;
    private const float resetPos = -0f;

    // Use this for initialization
    void Start()
    {

        _transform = gameObject.transform;
        _currentPosition = _transform.position;

        //Reset the position
        Reset();
    }

    // Update is called once per frame
    void Update()
    {

        //scrolling background implementation
        _currentPosition = _transform.position;
        _currentPosition -= new Vector2(speed, 0);
        _transform.position = _currentPosition;

        if (gameObject.transform.position.x < resetPos)
            Reset();
    }

    public void Reset()
    {

        //Reset backgorund
        _currentPosition = new Vector2(startPos, 0);
        _transform.position = _currentPosition;


    }


}
