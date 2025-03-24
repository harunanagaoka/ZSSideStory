using UnityEngine;

public class CharacterStatus : MonoBehaviour
{
    private float m_placeNum = 0;

    public float PlaceNum { get { return m_placeNum; } }

    public void SetRandomPlaceNum(int max)
    {
        m_placeNum = Random.Range(0, max);
    }
}
