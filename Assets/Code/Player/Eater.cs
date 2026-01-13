using UnityEngine;

public class Eater : MonoBehaviour
{
    public int level;

    void OnTriggerEnter2D(Collider2D collision)
    {
        var eatable = collision.GetComponent<IEatable>();
        if (eatable == null) return;

        if (eatable.GetLevel() >= level) return;

        eatable.Eat();
    }
}
