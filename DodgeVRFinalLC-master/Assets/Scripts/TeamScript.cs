using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;

public class TeamScript : RealtimeComponent<TeamModel>
{
    public GameObject endButton;
    public RealtimeAvatarManager _avatarManager;

    private void OnEnable()
    {
        _avatarManager.avatarCreated += AvatarChangedUpdatePlayerCount;
        _avatarManager.avatarDestroyed += AvatarLeftUpdatePlayerCount;
    }

    private void AvatarChangedUpdatePlayerCount(RealtimeAvatarManager avatarManager, RealtimeAvatar avatar, bool isLocalAvatar)
    {
        model.playerCount++;
    }

    private void AvatarLeftUpdatePlayerCount(RealtimeAvatarManager avatarManager, RealtimeAvatar avatar, bool isLocalAvatar)
    {
        model.playerCount--;
        if (model.playerCount >= 2 )
        {          
            endButton.SetActive(false);
        }
        else
        {
            endButton.SetActive(true);
        }
    }
}
