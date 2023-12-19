using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public int currentGold;
    public TMP_Text goldText;

    public void AddGold(int goldToAdd)
    {
        currentGold += goldToAdd;
        goldText.text = "Gold: " + currentGold;
    }
}

