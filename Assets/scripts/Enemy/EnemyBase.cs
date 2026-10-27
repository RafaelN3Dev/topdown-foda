using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    [Header("Base parameters")]

    [SerializeField] private int lives;
    [SerializeField] private float moveSpeed;

    private PlayerBehaviour playerRef;
    private Vector3 playerPos;

    private void Start()
    {
        playerRef = GameManager.Instance.GetPlayer();
    }

    private void Update()
    {
        playerPos = (playerRef.transform.position - transform.position);
        transform.position =
            Vector3.MoveTowards(transform.position, playerPos, moveSpeed * Time.deltaTime);
        Debug.Log("Following player");
    }

}
