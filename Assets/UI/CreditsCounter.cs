using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreditsCounter : MonoBehaviour
{
    public TextMeshProUGUI creditsTextObj;
    public string creditsCounterText = "Монет: ";

    private int collectedCredits = 0;

    private void Start()
    {
        UpdateText();
    }
    public void UpdateText()
    {
        creditsTextObj.text = creditsCounterText
            + collectedCredits.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            collectedCredits++;
            UpdateText();
        }
    }
}
