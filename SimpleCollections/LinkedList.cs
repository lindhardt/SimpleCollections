﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCollections
{
    public class LinkedList
    {
        private class ListNode
        {
            private Object _item;

            public Object Item
            {
                get { return _item; }
                set { _item = value; }
            }


            // Reference to next node in list
            private ListNode _nextNode = null;
            public ListNode NextNode
            {
                get { return _nextNode; }
                set { _nextNode = value; }
            }
        }

        private ListNode _firstNode = null;
        private int _length = 0;
        public int Length
        {
            get { return _length; }
            private set { _length = value; }
        }

        //TODO: Implement Indexer this[int i]

        public Object Add(Object item)
        {
            var node = new ListNode();
            node.Item = item;

            if (_firstNode == null)
            {
                _firstNode = node;
            }
            else
            {
                ListNode currentNode = _firstNode;
                while (currentNode.NextNode != null )
                {
                    currentNode = currentNode.NextNode;
                }

                currentNode.NextNode = node;
            }
            _length++;

            return item;
        }

        //TODO: Implement int Length()
        //public int Length()
        //{
        //    return _length;
        //}

        //TODO: Implement Object First()
        //TODO: Implement Object RemoveFirst()

        //TODO: Implement Object Last()
        //TODO: Implement Object RemoveLast()

        //TODO: Implement Object InsertAfter(Object item, Object newItem)
        //TODO: Implement Object InsertBefore(Object item, Object newItem)
        //TODO: Implement Object Insert(int index, Object Item)

        //TODO: Implement Object Remove(Object item)

        // Test Method remove before release
        public void PrintList()
        {
            ListNode currentNode = _firstNode;
            while (currentNode.NextNode != null)
            {
                Console.WriteLine(currentNode.Item);
                currentNode = currentNode.NextNode;
            }
            Console.WriteLine(currentNode.Item);
        }

    }
}
