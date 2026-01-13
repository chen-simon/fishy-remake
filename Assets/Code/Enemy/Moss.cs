using Unity;
using UnityEngine;

public class Moss : MonoBehaviour, IEatable
{
    [SerializeField] private int _level = 1;

    public int GetLevel() { return _level; }

    public void Eat()
    {
        Destroy(gameObject);
    }
}
