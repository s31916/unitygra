using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public string mainWord = "default";
    public TextMeshProUGUI mainWordText;
    public TextMeshProUGUI livesCountText;
    public TextMeshProUGUI messageText;
    public TMP_InputField inputField;
    public int livesCount = 10;
    // Start is called before the first frame update
    void Start()
    {
        mainWordText.text = mainWord;
        livesCountText.text = $"Zostało {livesCount} prób";
    }

    public void OnClick()

    {
        Debug.Log($"Guzik zostal klikniety");
        livesCount = livesCount - 1;
        livesCountText.text = $"Zostało {livesCount} prób";

        if (mainWord == inputField.text)
        {
            messageText.text = $"Poprawne słowo zostało wpisane";
            return;
        }
        if (mainWord.Length != inputField.text.Length)
        {
            messageText.text = $"Niepoprawne słowo zostało wpisane- zła liczba liter";
            return;
        }
        int bullCount = CountBulls();
        int cowCount = CountCows();
        messageText.text = $"Bulls: {bullCount} and Cows: {cowCount}";

    }
    public int CountBulls()
    {
        int result = 0;
        for (int i = 0; i< mainWord.Length; i++)
        {
            if (mainWord[i] != inputField.text[i] && mainWord.Contains(inputField.text[i]) )
                
                    
                    }

        return 0; }

    public int CountCows()
    { return 0; }



    // Update is called once per frame
    void Update()
    {

    }
}
