using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public Transform startPos;
    public GameObject ballPrefab;
    public int opposingPlayer;
    public AudioClip outSound;

    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.CompareTag("Ball"))
        {
            AudioSource.PlayClipAtPoint(outSound, other.transform.position, 1.0f);
            //A player has scored
            //update the score
            GameManager.addScore(opposingPlayer);

            //First destroy the ball
            Destroy(other.gameObject);

            //then make a new one in the center of the board
            if (GameManager.playing == true)
            {
                Instantiate(ballPrefab, startPos.position, Quaternion.identity);
            }
        }
    }
}
