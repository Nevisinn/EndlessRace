// using System.Collections;
// using System.Collections.Generic;
// using System.Runtime.InteropServices;
// using TMPro;
// using UnityEngine;

// public class PlayerInfo
// {
//     [SerializeField]
//     public int Money;

//     [SerializeField]
//     public List<GameObject> purchasedCars;
//     public int lastCar;

//     // [DllImport("__Internal")]
//     // private static extern void SaveExtern(string data);

//     // [DllImport("__Internal")]
//     // private static extern void LoadExtern();
// }

// public class Progresss : MonoBehaviour
// {
//     [SerializeField]
//     private TextMeshProUGUI totalMoney;
//     public PlayerInfo playerInfo;
//     public static Progresss Instance;

//     private void Awake()
//     {
//         if (Instance == null)
//         {
//             transform.parent = null;
//             DontDestroyOnLoad(gameObject);
//             Instance = this;
//         }
//         else
//         {
//             Destroy(gameObject);
//         }
//         totalMoney.text = playerInfo.Money.ToString();
//     }
// }
