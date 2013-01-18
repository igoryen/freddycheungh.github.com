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
    public partial class author
    {
        #region Primitive Properties
    
        public virtual System.Guid author_id
        {
            get;
            set;
        }
    
        public virtual string name
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<comment> comments
        {
            get
            {
                if (_comments == null)
                {
                    var newCollection = new FixupCollection<comment>();
                    newCollection.CollectionChanged += Fixupcomments;
                    _comments = newCollection;
                }
                return _comments;
            }
            set
            {
                if (!ReferenceEquals(_comments, value))
                {
                    var previousValue = _comments as FixupCollection<comment>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= Fixupcomments;
                    }
                    _comments = value;
                    var newValue = value as FixupCollection<comment>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += Fixupcomments;
                    }
                }
            }
        }
        private ICollection<comment> _comments;

        #endregion
        #region Association Fixup
    
        private void Fixupcomments(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (comment item in e.NewItems)
                {
                    item.author = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (comment item in e.OldItems)
                {
                    if (ReferenceEquals(item.author, this))
                    {
                        item.author = null;
                    }
                }
            }
        }

        #endregion
    }
}
