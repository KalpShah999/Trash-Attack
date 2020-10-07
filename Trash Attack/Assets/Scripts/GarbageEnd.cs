using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GarbageEnd : MonoBehaviour
{
    public GameObject creation;
    public GameObject gameoverText;
    public GameObject restartgameButton;
    public GameObject Controller;
    public GameObject GarbageEnding;
    public GameObject StartMenu;
    public GameObject Player;
    public static string CollidedObject;
    public Text GameEnd;

    private void OnTriggerEnter2D (Collider2D collider)
    {
        if (collider.gameObject.tag == "Recycling")
        {
            Score.scoreValue += 1;
            Creator.DifficultyGravity += 0.2f;
            Creator.DifficultyTime -= 0.02f;
        }

        if (collider.gameObject.tag == "Garbage")
        {
            creation.SetActive(false);
            collider.gameObject.name = collider.gameObject.name.Replace("(Clone)", "");
            CollidedObject = collider.gameObject.name;
            GameEnd.text = ("You Recycled " + CollidedObject + ". That Is Garbage!!");
            GarbageEnding.SetActive(true);
            Controller.GetComponent<PlayerController>().enabled = false;
            Player.SetActive(false);
            StartCoroutine(GameEnding());
        }
    }

    IEnumerator GameEnding ()
    {
        if (Creator.DifficultyNumber == 1)
        {
            Creator.DifficultyGravity = 5.0f;
            Creator.DifficultyTime = 3.0f; 
        } 
        if (Creator.DifficultyNumber == 2)
        {
            Creator.DifficultyGravity = 10.0f;
            Creator.DifficultyTime = 2.5f;
        }
        if (Creator.DifficultyNumber == 3)
        {
            Creator.DifficultyGravity = 15.0f;
            Creator.DifficultyTime = 2.0f;
        }
        if (Creator.DifficultyNumber == 4)
        {
            Creator.DifficultyGravity = 30.0f;
            Creator.DifficultyTime = 2.0f;
        }
        yield return new WaitForSeconds(1.0f);
        gameoverText.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        restartgameButton.SetActive(true);
        StartMenu.SetActive(true);
    }
}
