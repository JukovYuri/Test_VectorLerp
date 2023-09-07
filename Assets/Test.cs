using UnityEngine;

public class Test : MonoBehaviour
{
    public Transform transformRed;
    public Transform transformGreen;
    public Transform transformBase1;
    public Transform transformBase2;

    private Vector2 dir1;
    private Vector2 dir2;
    private float t;

    void Start()
    {
        CalcDir();
    }

    private void CalcDir()
    {
        dir1 = transformRed.position - transformBase1.position;
        dir2 = transformGreen.position - transformBase2.position;
    }

    void Update()
    {
        Vector2 dir = Vector2.Lerp(dir1, dir2, t / 10);
        Vector2 pos = Vector2.Lerp(transformBase1.position, transformBase2.position, t / 10);
        Debug.DrawRay(pos, dir, Color.yellow);
        Debug.DrawRay(transformBase1.position, dir1, Color.red);
        Debug.DrawRay(transformBase2.position, dir2, Color.green);
        t += Time.deltaTime;
    }
}
