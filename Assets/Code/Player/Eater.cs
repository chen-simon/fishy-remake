using UnityEngine;
using UnityEngine.Events;

public class Eater : MonoBehaviour
{
    public UnityEvent<int> eatEvent;

    public int level;

    void OnTriggerEnter2D(Collider2D collision)
    {
        var eatable = collision.GetComponent<IEatable>();
        if (eatable == null) return;

        var eatableLevel = eatable.GetLevel();
        if (eatableLevel >= level) return;

        eatable.Eat();
        eatEvent.Invoke(eatableLevel);
    }
}
