using UnityEngine;

public class Cell : MonoBehaviour, ICell
{
    [SerializeField] private SpriteRenderer mainSpriteRenderer;
    public SpriteRenderer MainSpriteRenderer => mainSpriteRenderer;
    public int Id { get; set; }
}
