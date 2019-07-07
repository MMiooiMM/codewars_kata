using System;
using System.Collections.Generic;

namespace Kata._5kyu
{
    //https://www.codewars.com/kata/515bb423de843ea99400000a
    public class PaginationHelper<T>
    {
        private IList<T> _collection;
        private readonly int _itemsPerPage;

        public PaginationHelper(IList<T> collection, int itemsPerPage)
        {
            _collection = collection;
            _itemsPerPage = (itemsPerPage < 0) ? 0 : itemsPerPage;
        }

        public int ItemCount
        {
            get
            {
                return _collection.Count;
            }
        }

        public int PageCount
        {
            get
            {
                return (Int32)Math.Ceiling(_collection.Count / (double)_itemsPerPage);
            }
        }

        public int PageItemCount(int pageIndex)
        {
            if (pageIndex < 0)
                return -1;
            int _Count = (_collection.Count - (pageIndex * _itemsPerPage));
            return (_Count > 0) ? ((_Count >= _itemsPerPage) ? _itemsPerPage : _Count) : -1;
        }

        public int PageIndex(int itemIndex)
        {
            if (itemIndex < 0)
                return -1;
            if (PageCount == 0 || _collection.Count == 0)
                return -1;
            if (itemIndex >= _collection.Count)
                return -1;
            return (itemIndex / _itemsPerPage) >= PageCount ? -1 : (itemIndex / _itemsPerPage);
        }
    }
}