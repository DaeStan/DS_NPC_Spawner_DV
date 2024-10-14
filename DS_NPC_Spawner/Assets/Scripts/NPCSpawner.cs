using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory m_Factory;

    public INPC m_Farmer;
    public INPC m_Beggar;
    public INPC m_Shopowner;

    public void SpawnVillagers()
    {
        m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
        m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
        m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);

        m_Beggar.Speak();
        m_Farmer.Speak();
        m_Shopowner.Speak();
    }
}
