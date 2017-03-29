/* Author Name: Kushal Parmar
 * Last Modified By: Kushal Parmar
 * Date Last Modified: 10/30/2016
 * Program Description: Points/lives system for player
 */
using UnityEngine;
using System.Collections;

public class blueUFO
{

    public HUD _hud = null;

    private static blueUFO _instance = null;

    public static blueUFO Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new blueUFO();
            }
            return _instance;
        }
    }

    private int _points = 0;

    public int Points
    {
        get
        {
            return _points;
        }
        set
        {
            _hud.updateDisplay();
            _points = value;
            if (_points <= 0)
            {
                _hud.Win();
            }
        }
    }

    private int _lives = 0;

    public int Lives
    {
        get
        {
            return _lives;
        }
        set
        {
            _lives = value;
            _hud.updateDisplay();
            if (_lives <= 0)
            {
                _hud.endGame();
            }
        }
    }

}
