using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private PlayerBehaviour Player;

    private void Awake()
    {
        if (Instance == null) Instance = this;

        Player = FindAnyObjectByType<PlayerBehaviour>();

        if (Player == null)
        {
            Debug.LogError("No player found");
        }
        else
        {
            Debug.Log("Player found");
        }
    }

    public PlayerBehaviour GetPlayer()
    {
        return Player;
    }
}
