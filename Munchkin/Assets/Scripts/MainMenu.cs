using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    [SerializeField] private Button ButtonPlay;

    private void Awake()
    {
        ButtonPlay.onClick.AddListener(OnButtonPlayClick);
    }

    private void OnButtonPlayClick()
    {
        Debug.Log("PLAY");
    }
}
