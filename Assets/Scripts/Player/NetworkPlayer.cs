using Unity.Netcode;
using UnityEngine;
using UnityEngine.Networking;
#pragma warning disable 618
#pragma warning restore 618

namespace Players
{
#pragma warning disable 618
    public class NetworkPlayer : NetworkBehaviour
#pragma warning restore 618
    {
        [SerializeField] private GameObject playerPrefab;
        private GameObject playerCharacter;

        private void Start()
        {
            SpawnCharacter();
        }

        private void SpawnCharacter()
        {
            if (!IsServer)
            {
                return;
            }

            playerCharacter = Instantiate(playerPrefab, transform.position, transform.rotation);
            

            SpawnWithClientAuthority(playerCharacter, connectionToClient);
        }
    }
}
