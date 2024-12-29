using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score = 0;
    public Bank bank;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text=bank.coins.ToString();
    }
    private void Update()
    {
        scoreText.text = bank.coins.ToString();
    }
}
