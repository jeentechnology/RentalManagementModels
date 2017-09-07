using System;
using System.Collections.Generic;
using System.Text;

namespace RentalManagementModels.Utility
{
    /// <summary>
    /// represents the base class for an implementation of a model using IModel
    /// </summary>
    public abstract class ModelBase : IModel
    {
        /// <summary>
        /// The Id that identifies the model in a data store
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The current state of the model
        /// </summary>
        public ModelStates State { get; private set; }

        private ModelStates restoreState;

        /// <summary>
        /// Called by a property when the status is changed
        /// </summary>
        public void PropertyChanged()
        {
            if (State == ModelStates.NoChange)
                State = ModelStates.Updated;
        }

        /// <summary>
        /// Called by a child ctor for the initial setup of the model
        /// </summary>
        protected void SetupModel(bool isNew)
        {
            if (isNew)
                State = ModelStates.New;
            else
                State = ModelStates.NoChange;
        }

        /// <summary>
        /// Reset the state of the model typically used after hydrating or deserializing
        /// </summary>
        /// <param name="isNew"></param>
        public void ResetState(bool isNew)
        {
            SetupModel(isNew);
        }

        /// <summary>
        /// Sets the state to deleted and updates the restore state in case the delete needs to be undone.
        /// </summary>
        public void Delete()
        {
            restoreState = State;
            State = ModelStates.Deleted;
        }

        /// <summary>
        /// Restores a deleted model to what it was when it was deleted.
        /// </summary>
        public void Restore()
        {
            if (State == ModelStates.Deleted)
                State = restoreState;
        }
    }
}
