using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static GameManager GetGameManager()
    { 
        return instance;
    }
    private void Awake()
    {
        instance = this;
    }
    [SerializeField]
    private GameObject ball;
    private void Start()
    {
        StartGame();
    }
    public void StartGame()
    {
        Instantiate(ball, Vector3.zero, Quaternion.identity);
    }
}
