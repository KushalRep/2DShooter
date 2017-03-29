/* Author Name: Kushal Parmar
 * Last Modified By: Kushal Parmar
 * Date Last Modified: 10/30/2016
 * Program Description: Canvas to display labels and different states of the game.
 */
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{

    [SerializeField]
    Text pointsLabel = null;

    [SerializeField]
    Text livesLabel = null;

    [SerializeField]
    Text gameOver = null;

    [SerializeField]
    Text youWin = null;

    [SerializeField]
    Text score = null;

    [SerializeField]
    Button start = null;

    [SerializeField]
    GameObject player = null;


    void initialize()
    {
        gameOver.gameObject.SetActive(false);
        youWin.gameObject.SetActive(false);
        score.gameObject.SetActive(false);
        player.gameObject.SetActive(false);
        blueUFO.Instance._hud = this;
    }

    void Start()
    {
        initialize();
    }
    void FixedUpdate()
    {
        updateDisplay();
    }

    public void updateDisplay()
    {
        pointsLabel.text = "Points: " + blueUFO.Instance.Points;
        livesLabel.text = "Lives: " + blueUFO.Instance.Lives;
    }

    public void endGame()
    {
        //code to show GameOver and score and disable player
        gameOver.gameObject.SetActive(true);
        score.gameObject.SetActive(true);
        player.gameObject.SetActive(false);
        start.gameObject.SetActive(true);
        score.text = blueUFO.Instance.Points.ToString();

    }
    //code to show You Win and disable player
    public void Win()
    {
        youWin.gameObject.SetActive(true);
        score.gameObject.SetActive(false);
        player.gameObject.SetActive(false);
        start.gameObject.SetActive(true);
        score.text = blueUFO.Instance.Points.ToString();

    }
    //code to restart game activate player and disable labels except lives and score
    public void RestartButtonClick()
    {
        //disable labels
        gameOver.gameObject.SetActive(false);
        youWin.gameObject.SetActive(false);
        score.gameObject.SetActive(false);
        //activate player
        player.gameObject.SetActive(true);
        start.gameObject.SetActive(false);
        //set players lives and points
        blueUFO.Instance.Lives = 3;
        blueUFO.Instance.Points = 100;

        Debug.Log("Button click");

    }
}
