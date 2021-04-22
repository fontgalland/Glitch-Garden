using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] int health = 5;
    Text healthText;
    [SerializeField] int damageImpact = 1;

    // Start is called before the first frame update
    void Start()
    {
        healthText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        healthText.text = health.ToString();
    }


    private void Update()
    {
        
    }

    public void TakeLife()
    {
            health -= damageImpact;
            UpdateDisplay();
        if(health <= 0)
        {
            FindObjectOfType<LevelLoad>().LoadYouLoseGame();
        }
    }


}
