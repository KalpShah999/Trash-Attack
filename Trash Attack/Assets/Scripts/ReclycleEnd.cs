using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReclycleEnd : MonoBehaviour
{
    public GameObject create;
    public GameObject gameOverText;
    public GameObject restartGameButton;
    public GameObject Controls;
    public GameObject RecyclingEnding;
    public GameObject StartMenu;
    public GameObject End;
    public static string CollidedObject = ("Didn't Work");
    public string CloneText = ("(Clone)");
    public Text GameEnd;

    private void OnTriggerEnter2D(Collider2D collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Recycling")
        {
            create.SetActive(false);
            collisionInfo.gameObject.name = collisionInfo.gameObject.name.Replace("(Clone)", "");
            CollidedObject = collisionInfo.gameObject.name;
            GameEnd.text = ("You Garbaged " + CollidedObject + ". That Is Recycling!!");
            RecyclingEnding.SetActive(true);
            Controls.GetComponent<PlayerController>().enabled = false;
            End.SetActive(false);
            StartCoroutine(GameOver());
        }

        if (collisionInfo.gameObject.tag == "Garbage")
        {
            Score.scoreValue += 1;
            Creator.DifficultyGravity += 0.2f;
            Creator.DifficultyTime -= 0.02f;
        }
    }

    IEnumerator GameOver()
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
        gameOverText.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        restartGameButton.SetActive(true);
        StartMenu.SetActive(true);
    }
}
