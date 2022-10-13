using UnityEngine;

public class Initer : MonoBehaviour
{
    [SerializeField] private UIController uIController;
    [SerializeField] private Spawner spawner;
    private void Awake()
    {
        uIController.OnSpawnDataChanged += spawner.Setup;
    }
}
