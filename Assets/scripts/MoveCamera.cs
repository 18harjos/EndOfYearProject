using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public Transform player;
    private void Start()
    {
        Time.timeScale = 1f;
    }
    void Update() {
            transform.position = player.transform.position;
        
                
    }
}
