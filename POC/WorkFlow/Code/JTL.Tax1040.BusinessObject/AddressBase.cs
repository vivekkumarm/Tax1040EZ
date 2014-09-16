/*
Copyright                   : Copyright Jeevan Technologies
File Name                   : AddressBase.cs
Description                 : This is the base class for Address related objects.
Author                      : Saravanan N.
Created Date                : 11th March 2014
 
Modification History:
---------------------
*/

using System;
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.BusinessObject
{
    /// <summary>
    /// Contains Basic methods for Address related classes.
    /// </summary>
    public class AddressBase
    {
        #region Public Member variables
        public event EventHandler HasChanged;
        #endregion

        #region Private Member variables
        private ObjectState mObjectState;
        #endregion

        #region Constructor
        public AddressBase(ObjectState state)
        {
            mObjectState = state;
        }
        #endregion

        #region Public SET Methods
        /// <summary>
        /// Flags the object instance as Modified.
        /// </summary>
        public void SetModified()
        {
            if (mObjectState == ObjectState.Current)
            {
                mObjectState = ObjectState.Modified;
                FireHasChanged();
            }
        }

        /// <summary>
        /// Flags the object instance as Current.
        /// </summary>
        public void SetCurrent()
        {
            mObjectState = ObjectState.Current;
        }
        #endregion

        #region Private methods
        private void FireHasChanged()
        {
            if (HasChanged != null)
                HasChanged(this, new EventArgs());
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets the state of the object.
        /// </summary>
        /// <remarks>Identifies the state of the object with respect to the persistence layer (New, Modified, Deleted, Current).</remarks>
        public ObjectState ObjectState
        {
            get
            {
                return mObjectState;
            }
        }
        #endregion
    }
}
