using System;
using System.Collections;

namespace QuickTesting
{
    /// <summary>
    /// Fake Dao
    /// </summary>
    public class DBClass
    {
        /// <summary>
        /// Local storage object
        /// </summary>
        private Hashtable hashTable = new Hashtable();

        /// <summary>
        /// Public accessor of local storage object
        /// </summary>
        public Hashtable DataBase
        {
            get { return this.hashTable; }
        }

        public DBClass() { }

        /// <summary>
        /// Save the object in storage
        /// </summary>
        /// <param name="po">Object to save</param>
        /// <returns>Success of storing</returns>
        public virtual bool Save(PlainObject po)
        {
            this.hashTable.Add(po.Id, po);
            return this.hashTable.ContainsKey(po.Id);
        }

        /// <summary>
        /// Update the object by replacement
        /// </summary>
        /// <param name="po">Object to update</param>
        /// <returns>Success of update</returns>
        public virtual bool Update(PlainObject po)
        {
            this.hashTable[po.Id] = po;
            return this.hashTable.ContainsKey(po.Id);
        }

        /// <summary>
        /// Removes the object from storage
        /// </summary>
        /// <param name="Id">The id of the object to remove</param>
        /// <returns>Success of removal</returns>
        public virtual bool Delete(int Id)
        {
            this.hashTable.Remove(Id);
            return this.hashTable.ContainsKey(Id);
        }
    }
}
