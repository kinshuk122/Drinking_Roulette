using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextTurn : MonoBehaviour
{
    public void NextMove()
    {
        SceneManager.LoadScene("Game");
    }
}
