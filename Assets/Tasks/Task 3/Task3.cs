using UnityEngine;

public class Task3 : MonoBehaviour
{
    [SerializeField] 
    private Rigidbody _wallPrefab;
    
    private void Start()
    {
        var prefab = Instantiate(_wallPrefab);
        prefab.isKinematic = false;
    }
}
