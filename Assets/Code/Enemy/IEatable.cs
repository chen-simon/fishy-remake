using UnityEngine;

public interface IEatable
{
    /// <summary>
    /// Get the cuurent level of the eatable
    /// </summary>
    public int GetLevel();

    /// <summary>
    /// Consume the eatable
    /// </summary>
    public void Eat();
}
