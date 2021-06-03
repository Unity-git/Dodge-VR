using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
using UnityEngine.UI;

public class PlayerListScript : RealtimeComponent<PlayerListModel>
{
    public Text _playerList;
    public RealtimeAvatarManager _avatarManager;

    private void OnEnable()
    {
        _avatarManager.avatarCreated += AvatarChangedUpdatePlayerList;
        _avatarManager.avatarDestroyed += AvatarChangedUpdatePlayerList;
    }

    private void AvatarChangedUpdatePlayerList(RealtimeAvatarManager avatarManager, RealtimeAvatar avatar, bool isLocalAvatar)
    {
        SetPlayerList();
    }

    protected override void OnRealtimeModelReplaced(PlayerListModel previousModel, PlayerListModel currentModel)
    {
        if (previousModel != null)
        {
            previousModel.playerListDidChange -= PlayerListDidChange;
        }
        if (currentModel != null)
        {
            if (currentModel.isFreshModel)
            {
                model.playerList = "";
            }

            UpdatePlayerList();
            currentModel.playerListDidChange += PlayerListDidChange;
        }
    }

    private void PlayerListDidChange(PlayerListModel model, string value)
    {
        UpdatePlayerList();
    }

    private void UpdatePlayerList()
    {
        _playerList.text = model.playerList;
    }

    private void SetPlayerList()
    {
        int playerID = 0;
        model.playerList = "";

        foreach (var avataritem in _avatarManager.avatars)
        {
            playerID = avataritem.Key + 1;
            model.playerList += "SpaceMan " + playerID + "\n";
        }
    }
}
