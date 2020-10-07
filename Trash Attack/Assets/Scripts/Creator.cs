using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Creator : MonoBehaviour
{
    public Camera cam;
    public GameObject[] Items;
    public GameObject StartButton;
    public GameObject Player;
    public GameObject OuterPlayer;
    public GameObject End;
    public GameObject RestartButton;
    public GameObject GameOverText;
    public GameObject Create;
    public GameObject ScoreText;
    public GameObject Controllers;
    public GameObject GarbageEnding;
    public GameObject RecyclingEnding;
    public GameObject Instructions;
    public GameObject startMenu;
    public GameObject ItemListButton;
    public GameObject ItemListTexts;
    public GameObject ItemListItems;
    public GameObject BackButton;
    public GameObject DifficultyButton;
    public GameObject DifficultyTitle;
    public GameObject EasyButton;
    public Text EasyText;
    public GameObject MediumButton;
    public Text MediumText;
    public GameObject HardButton;
    public Text HardText;
    public GameObject InsaneButton;
    public Text InsaneText;
    public static int DifficultyNumber = 2;
    public static float DifficultyTime = 2.5f;
    public static float DifficultyGravity = 10.0f;
    public GameObject BackgorundButton;
    public GameObject BackgorundScreen;
    public GameObject Title;
    public GameObject HomeScreen;
    public GameObject AllthewayBack;
    private float maxWidth;
    private int randItems;
    public static int Running = 0;
    
    void Start()
    {
        if (cam == null)
        {
            cam = Camera.main;
        }
        Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
        Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);
        maxWidth = targetWidth.x;
    }

    public void Home()
    {
        HomeScreen.SetActive(false);
        Title.SetActive(true);
        StartButton.SetActive(true);
        ItemListButton.SetActive(true);
        DifficultyButton.SetActive(true);
        BackgorundButton.SetActive(true);
    }

    public void GameStart ()
    {
        StartButton.SetActive(false);
        Player.SetActive(true);
        Create.SetActive(true);
        ScoreText.SetActive(true);
        ItemListButton.SetActive(false);
        DifficultyButton.SetActive(false);
        BackgorundButton.SetActive(false);
        OuterPlayer.SetActive(true);
        End.SetActive(true);
        Title.SetActive(false);
        Player.GetComponent<PlayerController>().enabled = true;
        AllthewayBack.SetActive(false);
        StartCoroutine(Spawn());
    }

    public void Restart()
    {
        GameOverText.SetActive(false);
        RestartButton.SetActive(false);
        Player.SetActive(true);
        Create.SetActive(true);
        Controllers.GetComponent<PlayerController>().enabled = true;
        OuterPlayer.SetActive(true);
        End.SetActive(true);
        GarbageEnding.SetActive(false);
        RecyclingEnding.SetActive(false);
        startMenu.SetActive(false);
        Score.scoreValue = 0;
        StartCoroutine(Spawn());
    }

    public void StartMenu()
    {
        GameOverText.SetActive(false);
        RestartButton.SetActive(false);
        GarbageEnding.SetActive(false);
        RecyclingEnding.SetActive(false);
        ItemListButton.SetActive(true);
        BackgorundButton.SetActive(true);
        Title.SetActive(true);
        BackButton.SetActive(false);
        ItemListItems.SetActive(false);
        ItemListTexts.SetActive(false);
        startMenu.SetActive(false);
        Score.scoreValue = 0;
        ScoreText.SetActive(false);
        Player.SetActive(false);
        StartButton.SetActive(true);
        DifficultyButton.SetActive(true);
        DifficultyTitle.SetActive(false);
        EasyButton.SetActive(false);
        MediumButton.SetActive(false);
        HardButton.SetActive(false);
        InsaneButton.SetActive(false);
        BackgorundScreen.SetActive(false);
        AllthewayBack.SetActive(true);
    }

    public void ItemListStart()
    {
        ItemListButton.SetActive(false);
        StartButton.SetActive(false);
        BackButton.SetActive(true);
        DifficultyButton.SetActive(false);
        ItemListItems.SetActive(true);
        ItemListTexts.SetActive(true);
        Title.SetActive(false);
        AllthewayBack.SetActive(false);
        BackgorundButton.SetActive(false);
    }

    public void Difficulty()
    {
        StartButton.SetActive(false);
        ItemListButton.SetActive(false);
        DifficultyButton.SetActive(false);
        BackButton.SetActive(true);
        DifficultyTitle.SetActive(true);
        EasyButton.SetActive(true);
        MediumButton.SetActive(true); ;
        HardButton.SetActive(true);
        InsaneButton.SetActive(true);
        Title.SetActive(false);
        AllthewayBack.SetActive(false);
        BackgorundButton.SetActive(false);
    }

    public void EasyDifficulty()
    {
        DifficultyNumber = 1; 
        EasyText.color = Color.white;
        MediumText.color = Color.black;
        HardText.color = Color.black;
        InsaneText.color = Color.black;
        DifficultyGravity = 5.0f;
        DifficultyTime = 3.0f;
    }

    public void MediumDifficulty()
    {
        DifficultyNumber = 2;
        EasyText.color = Color.black;
        MediumText.color = Color.white;
        HardText.color = Color.black;
        InsaneText.color = Color.black;
        DifficultyGravity = 10.0f;
        DifficultyTime = 2.5f;
    }

    public void HardDifficulty()
    {
        DifficultyNumber = 3;
        EasyText.color = Color.black;
        MediumText.color = Color.black;
        HardText.color = Color.white;
        InsaneText.color = Color.black;
        DifficultyGravity = 15.0f;
        DifficultyTime = 2.0f;
    }

    public void InsaneDifficulty()
    {
        DifficultyNumber = 4;
        EasyText.color = Color.black;
        MediumText.color = Color.black;
        HardText.color = Color.black;
        InsaneText.color = Color.white;
        DifficultyGravity = 30.0f;
        DifficultyTime = 1.0f;
    }

    public void WayBack()
    {
        GameOverText.SetActive(false);
        RestartButton.SetActive(false);
        GarbageEnding.SetActive(false);
        RecyclingEnding.SetActive(false);
        ItemListButton.SetActive(false);
        Title.SetActive(false);
        BackButton.SetActive(false);
        ItemListItems.SetActive(false);
        ItemListTexts.SetActive(false);
        startMenu.SetActive(false);
        Score.scoreValue = 0;
        ScoreText.SetActive(false);
        Player.SetActive(false);
        StartButton.SetActive(false);
        DifficultyButton.SetActive(false);
        DifficultyTitle.SetActive(false);
        EasyButton.SetActive(false);
        MediumButton.SetActive(false);
        HardButton.SetActive(false);
        InsaneButton.SetActive(false);
        BackgorundButton.SetActive(false);
        AllthewayBack.SetActive(true);
        HomeScreen.SetActive(true);
    }

    public void Background()
    {
        BackgorundScreen.SetActive(true);
        StartButton.SetActive(false);
        ItemListButton.SetActive(false);
        DifficultyButton.SetActive(false);
        BackButton.SetActive(true);
        DifficultyTitle.SetActive(false);
        EasyButton.SetActive(false);
        MediumButton.SetActive(false); ;
        HardButton.SetActive(false);
        InsaneButton.SetActive(false);
        Title.SetActive(false);
        AllthewayBack.SetActive(false);
        BackgorundButton.SetActive(false);
    }

    IEnumerator Spawn ()
    {
        Instructions.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        Instructions.SetActive(false);
        yield return new WaitForSeconds(2.0f);
        Physics2D.gravity = new Vector3(0, -DifficultyGravity, 0);
        while (true)
        {
            randItems = Random.Range(0, 18);
            Vector3 SpawnPosition = new Vector3(Random.Range(-maxWidth + 5.0f, maxWidth - 5.0f), transform.position.y, 0.0f);
            Quaternion SpawnRotation = Quaternion.identity;
            Instantiate (Items[randItems], SpawnPosition, SpawnRotation);
            yield return new WaitForSeconds(DifficultyTime);
        }
    }
}
