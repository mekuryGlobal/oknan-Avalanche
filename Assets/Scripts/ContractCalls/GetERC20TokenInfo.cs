using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class GetERC20TokenInfo : MonoBehaviour
{
    // Chain == Chain name connecting
    [SerializeField] private string chain = "avalanche";

    // Network == The network RPC name
    [SerializeField] private string network = "testnet";

    // USDC address == Token Contract Address
    [SerializeField] private string contract = "0xA422d2D7851Ec6EA2E930ec30d0935f74C54dc66";

    

    public Text tokenName;
    public Text tokenSymbol;

   public async void Start()
    {
        BigInteger totalSupply = await ERC20.TotalSupply(chain, network, contract);
        Debug.Log(totalSupply);

        string symbol = await ERC20.Symbol(chain, network, contract);
        Debug.Log(symbol);

        string name = await ERC20.Name(chain, network, contract);
        //This method Retrieves the token balance oh DongoPiks
        tokenName.text = "Token: " + name;
        tokenSymbol.text = "Symbol: " + symbol;
        Debug.Log(name);


        

        

    }
}
