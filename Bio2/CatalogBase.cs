using System.Collections.Generic;
using System.Linq;

namespace Bio2
{
    public abstract class CatalogBase<TDomainClass> where TDomainClass : DomainClassBase
    {
        /// <summary>
        /// Keep track of keys for objects
        /// </summary>
        private static int _keyCount = 1;

        /// <summary>
        /// Uses a Dictionary to store domain objects,
        /// so they can be looked up using a key value
        /// </summary>
        private Dictionary<int, TDomainClass> _items;

        #region Constructor

        protected CatalogBase()
        {
            _items = new Dictionary<int, TDomainClass>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Returns all domain objects in a List
        /// </summary>
        public List<TDomainClass> All
        {
            get { return _items.Values.ToList(); }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds a single domain object to the collection
        /// </summary>
        /// <param name="obj">The domain object to add</param>
        public void Add(TDomainClass obj)
        {
            obj.Key = _keyCount++;
            _items.Add(obj.Key, obj);
        }

      


        #endregion
    }
}