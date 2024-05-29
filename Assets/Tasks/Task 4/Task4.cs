using UnityEngine;

public class Task4 : MonoBehaviour
{
    [SerializeField] 
    private Transform _shelfPrefab;
    
    private void Start()
    {
        var prefab = Instantiate(_shelfPrefab); // Эту строку кода удалять нельзя

        Destroy(prefab.gameObject);
    }
}
