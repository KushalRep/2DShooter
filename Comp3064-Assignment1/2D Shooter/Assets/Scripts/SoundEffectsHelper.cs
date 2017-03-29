/* Author Name: Kushal Parmar
 * Last Modified By: Kushal Parmar
 * Date Last Modified: 10/30/2016
 * Program Description: Collision sounds script.
 */

/*
 * Source:https://www.youtube.com/watch?v=Ywaygt7Fwms
 * Author: J.A. Whye
 */
using UnityEngine;
using System.Collections;

public class SoundEffectsHelper : MonoBehaviour {

    public static SoundEffectsHelper Instance;

    public AudioClip explosionSound;
    public AudioClip moneySound;

    void Awake()
    {
        // Register the singleton
        if (Instance != null)
        {
            Debug.LogError("Multiple instances of SoundEffectsHelper!");
        }
        Instance = this;
    }

    public void MakeExplosionSound()
    {
        MakeSound(explosionSound);
    }

    public void friendCollisionSound()
    {
        MakeSound(moneySound);
    }

    //Play a given sound
    private void MakeSound(AudioClip originalClip)
    {
        // As it is not 3D audio clip, position doesn't matter.
        AudioSource.PlayClipAtPoint(originalClip, transform.position);
    }
}
