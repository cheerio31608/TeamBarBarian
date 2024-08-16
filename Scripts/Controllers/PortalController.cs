using UnityEngine;

public class PortalsController : MonoBehaviour
{
    [SerializeField] PortalType portalType;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Player.Instance.isPlayerInteracting = true;

            GameManager.Instance.MoveStageController.MoveToNextStage(portalType);
        }
    }
}