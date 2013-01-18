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

namespace int422_123b06.Project.Entities
{
    public partial class aspnet_PersonalizationPerUser
    {
        #region Primitive Properties
    
        public virtual System.Guid Id
        {
            get;
            set;
        }
    
        public virtual Nullable<System.Guid> PathId
        {
            get { return _pathId; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_pathId != value)
                    {
                        if (aspnet_Paths != null && aspnet_Paths.PathId != value)
                        {
                            aspnet_Paths = null;
                        }
                        _pathId = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<System.Guid> _pathId;
    
        public virtual Nullable<System.Guid> UserId
        {
            get { return _userId; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_userId != value)
                    {
                        if (aspnet_Users != null && aspnet_Users.UserId != value)
                        {
                            aspnet_Users = null;
                        }
                        _userId = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<System.Guid> _userId;
    
        public virtual byte[] PageSettings
        {
            get;
            set;
        }
    
        public virtual System.DateTime LastUpdatedDate
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual aspnet_Paths aspnet_Paths
        {
            get { return _aspnet_Paths; }
            set
            {
                if (!ReferenceEquals(_aspnet_Paths, value))
                {
                    var previousValue = _aspnet_Paths;
                    _aspnet_Paths = value;
                    Fixupaspnet_Paths(previousValue);
                }
            }
        }
        private aspnet_Paths _aspnet_Paths;
    
        public virtual aspnet_Users aspnet_Users
        {
            get { return _aspnet_Users; }
            set
            {
                if (!ReferenceEquals(_aspnet_Users, value))
                {
                    var previousValue = _aspnet_Users;
                    _aspnet_Users = value;
                    Fixupaspnet_Users(previousValue);
                }
            }
        }
        private aspnet_Users _aspnet_Users;

        #endregion
        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void Fixupaspnet_Paths(aspnet_Paths previousValue)
        {
            if (previousValue != null && previousValue.aspnet_PersonalizationPerUser.Contains(this))
            {
                previousValue.aspnet_PersonalizationPerUser.Remove(this);
            }
    
            if (aspnet_Paths != null)
            {
                if (!aspnet_Paths.aspnet_PersonalizationPerUser.Contains(this))
                {
                    aspnet_Paths.aspnet_PersonalizationPerUser.Add(this);
                }
                if (PathId != aspnet_Paths.PathId)
                {
                    PathId = aspnet_Paths.PathId;
                }
            }
            else if (!_settingFK)
            {
                PathId = null;
            }
        }
    
        private void Fixupaspnet_Users(aspnet_Users previousValue)
        {
            if (previousValue != null && previousValue.aspnet_PersonalizationPerUser.Contains(this))
            {
                previousValue.aspnet_PersonalizationPerUser.Remove(this);
            }
    
            if (aspnet_Users != null)
            {
                if (!aspnet_Users.aspnet_PersonalizationPerUser.Contains(this))
                {
                    aspnet_Users.aspnet_PersonalizationPerUser.Add(this);
                }
                if (UserId != aspnet_Users.UserId)
                {
                    UserId = aspnet_Users.UserId;
                }
            }
            else if (!_settingFK)
            {
                UserId = null;
            }
        }

        #endregion
    }
}
