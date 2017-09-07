using System;
using System.Collections.Generic;
using System.Text;

namespace RentalManagementModels.Utility
{
    /// <summary>
    /// Represents the different states a model can have
    /// </summary>
    public enum ModelStates
    {
        /// <summary>
        /// There have been no changes since the item was last saved.
        /// </summary>
        NoChange = 0,

        /// <summary>
        /// The item is a new model that has not been persisted to a data store
        /// </summary>
        New = 1,

        /// <summary>
        /// the item has been changed since its last save
        /// </summary>
        Updated = 2,

        /// <summary>
        /// The item has been delted but not removed from the data store
        /// </summary>
        Deleted = 3
    }
}
