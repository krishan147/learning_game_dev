using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    void Start()
    {
        int playerLives = 10;

        while (playerLives > 0)
        {
            Debug.Log("Still alive!");
            playerLives--;
        }

        Debug.Log("Player koooo'd");

        Character hero = new Character();
        Debug.LogFormat("Hero: {0} - {1} EXP", hero.name, hero.exp);

        Character heroine = new Character("Agatha");
        Debug.LogFormat("Hero: {0} - {1} EXP", heroine.name, heroine.exp);

    }
}