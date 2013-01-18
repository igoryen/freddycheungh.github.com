//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace int422_123b06.Entities
{
    public partial class User_songs
    {
        #region Primitive Properties
    
        public virtual int u_userSong_id
        {
            get;
            set;
        }
    
        public virtual string u_user_id
        {
            get { return _u_user_id; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_u_user_id != value)
                    {
                        if (User != null && User.u_user_id != value)
                        {
                            User = null;
                        }
                        _u_user_id = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private string _u_user_id;
    
        public virtual string song_id
        {
            get { return _song_id; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_song_id != value)
                    {
                        if (Song != null && Song.song_id != value)
                        {
                            Song = null;
                        }
                        _song_id = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private string _song_id;

        #endregion
        #region Navigation Properties
    
        public virtual Song Song
        {
            get { return _song; }
            set
            {
                if (!ReferenceEquals(_song, value))
                {
                    var previousValue = _song;
                    _song = value;
                    FixupSong(previousValue);
                }
            }
        }
        private Song _song;
    
        public virtual User User
        {
            get { return _user; }
            set
            {
                if (!ReferenceEquals(_user, value))
                {
                    var previousValue = _user;
                    _user = value;
                    FixupUser(previousValue);
                }
            }
        }
        private User _user;

        #endregion
        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupSong(Song previousValue)
        {
            if (previousValue != null && previousValue.User_songs.Contains(this))
            {
                previousValue.User_songs.Remove(this);
            }
    
            if (Song != null)
            {
                if (!Song.User_songs.Contains(this))
                {
                    Song.User_songs.Add(this);
                }
                if (song_id != Song.song_id)
                {
                    song_id = Song.song_id;
                }
            }
            else if (!_settingFK)
            {
                song_id = null;
            }
        }
    
        private void FixupUser(User previousValue)
        {
            if (previousValue != null && previousValue.User_songs.Contains(this))
            {
                previousValue.User_songs.Remove(this);
            }
    
            if (User != null)
            {
                if (!User.User_songs.Contains(this))
                {
                    User.User_songs.Add(this);
                }
                if (u_user_id != User.u_user_id)
                {
                    u_user_id = User.u_user_id;
                }
            }
            else if (!_settingFK)
            {
                u_user_id = null;
            }
        }

        #endregion
    }
}
