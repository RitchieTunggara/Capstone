using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class exitMini : MonoBehaviour
{

    public void exitScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }
}
