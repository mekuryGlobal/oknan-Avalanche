using System.Numerics;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ReadERC20Balance : MonoBehaviour
{
    // Chain == Chain name connecting
    [SerializeField] private string chain = "avalanche";

    // Network == The network RPC name
    [SerializeField] private string network = "testnet";

    // USDC address == Token Contract Address
    [SerializeField] private string contract = "0xA422d2D7851Ec6EA2E930ec30d0935f74C54dc66";

    // RPC
    [SerializeField] private string rpc = "https://api.avax-test.network/ext/bc/C/rpc";



    public Text balancetxt;
 


    private string balance1;




    // Start is called before the first frame update

    public async void Start()
    {
        string account = PlayerPrefs.GetString("Account");
        
        BigInteger balanceOf = -1;

       
        balanceOf = await ERC20.BalanceOf(chain, network, contract, account, rpc);


        if (balanceOf == -1)
        {
            Debug.Log("Nothing");
        }

        if (balanceOf != null) balance1 = balanceOf.ToString();
        
        string balance = balance1.Substring(0, 5);

        balancetxt.text = "Balance: " + balance;
    }


   

   



}

