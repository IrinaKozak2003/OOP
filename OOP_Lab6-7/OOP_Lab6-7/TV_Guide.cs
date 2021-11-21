using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class TvGuide<Director>
    {
        public List<Director> _list;

        public TvGuide(List<Director> list)
        {
            _list = new List<Director>();
        }

        public TvGuide()
        {
            _list = new List<Director>();
        }

        public void Add(Director item)
        {
            _list.Add(item);
        }

        public void Delete(Director item)
        {
            _list.Remove(item);
        }

        public int Count()
        {
            return _list.Count;
        }

       
    }
}