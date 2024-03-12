using UnityEngine;

public class Steps : MonoBehaviour
{
    [SerializeField] private AudioSource _moveSound;

    private void Update(){
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) ||
        Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)){
            if (_moveSound.isPlaying) return;
            _moveSound.Play();
        }
        else{
            _moveSound.Stop();
        }
    }
}
