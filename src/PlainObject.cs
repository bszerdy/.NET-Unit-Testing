using System;

namespace QuickTesting
{
    /// <summary>
    /// Simple object to store values
    /// </summary>
    public class PlainObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        private DBClass dbClass;

        /// <summary>
        /// Constructor injection of the Dao object
        /// </summary>
        /// <param name="dbClass"></param>
        public PlainObject(DBClass dbClass)
        {
            if (dbClass == null)
                throw new ArgumentNullException("DBClass is null");

            this.dbClass = dbClass;
        }

        /// <summary>
        /// Save the current object data to the database
        /// </summary>
        /// <returns>Success of save</returns>
        public bool SaveToDb()
        {
            return this.dbClass.Save(this);
        }

        /// <summary>
        /// Update the current object data in the database
        /// </summary>
        /// <returns>Success of update</returns>
        public bool UpdateToDb()
        {
            return this.dbClass.Update(this);
        }

        /// <summary>
        /// Remove the current object from the database
        /// </summary>
        /// <returns>Success of removal</returns>
        public bool RemoveFromDb()
        {
            return this.dbClass.Delete(this.Id);
        }
    }
}
