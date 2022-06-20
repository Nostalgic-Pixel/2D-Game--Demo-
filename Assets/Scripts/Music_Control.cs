using UnityEngine;

public class Music_Control : MonoBehaviour
{
    public static Music_Control instance;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        
        if (instance == null)
        {
            instance = this;
        }

        else
        {
            Destroy(gameObject);
        
        }

    }

}
