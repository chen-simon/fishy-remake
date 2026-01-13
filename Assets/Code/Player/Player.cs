using UnityEngine;

public class Player : MonoBehaviour
{
    private int level;

    [SerializeField] private Eater eater;

    void Start()
    {
        eater.eatEvent.AddListener(Eat);
    }

    void Eat(int level)
    {
        
    }
}
