/* Author Name: Kushal Parmar
 * Last Modified By: Kushal Parmar
 * Date Last Modified: 10/30/2016
 * Program Description: collison with enemy and friend.
 */
using UnityEngine;
using System.Collections;

public class CollisionScript : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        //collision implementation
        if (other.gameObject.tag == "enemy")
        {
            blueUFO.Instance.Lives -= 1;
            Debug.Log("Collision with " + other.gameObject.tag);

            SoundEffectsHelper.Instance.MakeExplosionSound();
        }
        else if (other.gameObject.tag == "friend")
        {
            blueUFO.Instance.Points -= 10;
            Debug.Log("Collision with " + other.gameObject.tag);

            SoundEffectsHelper.Instance.friendCollisionSound();
        }
    }
}
