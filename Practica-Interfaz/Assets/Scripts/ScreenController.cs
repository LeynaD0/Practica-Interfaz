using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScreenController : MonoBehaviour
{
    [SerializeField]
    GameObject screenGame, screenIntro, player;

    [SerializeField]
    TMP_InputField inputPlayerName;

    [SerializeField]
    TextMeshProUGUI name;

    // Start is called before the first frame update
    void Start()
    {
        screenGame.SetActive(false);
        player.SetActive(false);
        screenIntro.SetActive(true);
        
    }

    public void EmpezarJuego()
    {
        screenGame.SetActive(true);
        player.SetActive(true);
        screenIntro.SetActive(false);
        Debug.Log(inputPlayerName.text);
        name.text = inputPlayerName.text;
    }
}
