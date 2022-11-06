using UnityEngine;
using UnityEngine.SceneManagement;

public class coinScripts : MonoBehaviour
{
    [SerializeField] private Vector3 rotationAxeis;
    [SerializeField] private float _rotationSpeed = 15f;
    private string sceaneName = "name";
    void Start()
    {
        
    }

    
    void Update()
    {
       transform.Rotate(rotationAxeis*Time.deltaTime*_rotationSpeed);
    }
    private void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"){ 
        this.gameObject.SetActive(false);
        //SceneManager.LoadScene(sceaneName);
        }
    }


}//class
