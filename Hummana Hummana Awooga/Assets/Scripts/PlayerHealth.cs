using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{

    public int health = 5;
    public TextMeshProUGUI healthText;

    void Update()
    {
        healthText.text = "" + health;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string otherTag = collision.gameObject.tag;
        if (otherTag == "Enemy")
        {
            health--;
            if (health <= 0)
            {
                SceneManager.LoadScene("Loser");
            }
        }
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("Loser");
    }
}

