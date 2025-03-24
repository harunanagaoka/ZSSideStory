using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "ScriptableObjects/CharacterData")]
public class CharacterData : ScriptableObject
{
    [SerializeField]
    private ParamsData m_paramsData = new ParamsData();

    public ParamsData Params {  get { return m_paramsData; } private set { m_paramsData = value; } }

    public enum Pattern
    {
        Memeshino_Toka,
        Max
    }

    [System.Serializable]
    public class ParamsData
    {
        [SerializeField, Header("好感度の最小値")]
        private float m_minLikability = 0f;

        [SerializeField, Header("好感度の最大値")]
        private float m_maxLikability = 0f;

        [SerializeField, Header("SAN値の最小値")]
        private float m_minSUN = 0f;

        [SerializeField, Header("SAN値の最大値")]
        private float m_maxSUN = 0f;

        public float MinLikability { get { return m_minLikability; } private set { m_minLikability = value; } }
        public float MaxLikability { get { return m_maxLikability; } private set { m_maxLikability = value; } }
        public float MinSun { get { return m_minSUN; } private set { m_minSUN = value; } }
        public float MaxSUN { get { return m_maxSUN; } private set { m_maxSUN = value; } }

    }
}
