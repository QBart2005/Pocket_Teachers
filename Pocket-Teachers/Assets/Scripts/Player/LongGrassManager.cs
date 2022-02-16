using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LongGrassManager : MonoBehaviour
{
    public Tilemap LongGrassTM;
    public Tile m_Empty;
    public Tile LGTile;
    public LayerMask grassLayer;

    void Update()
    {
        CheckForLonggrass();
    }

    private void CheckForLonggrass()
    {
        if(Physics2D.OverlapCircle(transform.position, 0.3f, grassLayer) != null)
        {
            Vector3Int i_position = new Vector3Int(Mathf.RoundToInt(transform.position.x), Mathf.RoundToInt(transform.position.y), Mathf.RoundToInt(transform.position.z));
            LongGrassTM.SetTile(i_position, LGTile);
        }else{
            Vector3Int i_position = new Vector3Int(Mathf.RoundToInt(transform.position.x), Mathf.RoundToInt(transform.position.y), Mathf.RoundToInt(transform.position.z));
            LongGrassTM.SetTile(i_position, m_Empty);
        }
    }
}
