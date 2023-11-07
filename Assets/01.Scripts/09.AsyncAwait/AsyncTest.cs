using System.Threading.Tasks;
using UnityEngine;

public class AsyncTest : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Start!!!");
        Test();
        Debug.Log("1");
    }

    private async void Test()
    {
        Debug.Log("2");
        await Task.Delay(7000);
        Debug.Log("3");
    }
}
