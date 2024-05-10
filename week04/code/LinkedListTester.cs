public static class LinkedListTester {
    public static void Run() {
        // Sample Test Cases (may not be comprehensive) 
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        var ll = new LinkedList();
        ll.InsertTail(1);
        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(3);
        ll.InsertHead(4);
        ll.InsertHead(5);

        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 3, 2, 2, 2, 1};
        ll.InsertTail(0);
        ll.InsertTail(-1);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 3, 2, 2, 2, 1, 0, -1};

        var ll2 = new LinkedList();
        ll2.InsertTail(1);
        Console.WriteLine(ll2.ToString()); // <LinkedList>{1}
        Console.WriteLine(ll2.HeadAndTailAreNotNull()); // True

        var ll3 = new LinkedList();
        ll3.InsertHead(1);
        Console.WriteLine(ll3.ToString()); // <LinkedList>{1}
        ll3.InsertTail(2);
        Console.WriteLine(ll3.ToString()); // <LinkedList>{1,2}
        ll3.InsertHead(0);
        Console.WriteLine(ll3.ToString()); // <LinkedList>{0,1,2}
        ll3.InsertTail(3);
        Console.WriteLine(ll3.ToString()); // <LinkedList>{0,1,2,3}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        ll.RemoveTail();
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 3, 2, 2, 2, 1, 0}
        ll.RemoveTail();
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 3, 2, 2, 2, 1}

        ll3 = new LinkedList();
        ll3.RemoveTail();
        Console.WriteLine(ll3.ToString()); // <LinkedList>{}
        ll3.InsertHead(2);
        ll3.RemoveTail();
        Console.WriteLine(ll3.ToString()); // <LinkedList>{}
        Console.WriteLine(ll3.HeadAndTailAreNull()); // True

        ll3 = new LinkedList();
        ll3.RemoveTail();
        ll3.InsertTail(2);
        Console.WriteLine(ll3.ToString()); // <LinkedList>{2}
        ll3.RemoveTail();
        Console.WriteLine(ll3.ToString()); // <LinkedList>{}
        ll3.InsertTail(3);
        ll3.InsertHead(4);
        ll3.InsertTail(5);
        Console.WriteLine(ll3.ToString()); // <LinkedList>{4, 3, 5}
        ll3.RemoveTail();
        Console.WriteLine(ll3.ToString()); // <LinkedList>{4, 3}
        ll3.RemoveHead();
        Console.WriteLine(ll3.ToString()); // <LinkedList>{3}
        ll3.RemoveTail();
        Console.WriteLine(ll3.ToString()); // <LinkedList>{}

        Console.WriteLine("\n=========== PROBLEM 3 TESTS ===========");
        ll.InsertAfter(3, 35);
        ll.InsertAfter(5, 6);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 6, 4, 3, 35, 2, 2, 2, 1}
        ll.Remove(-1);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 6, 4, 3, 35, 2, 2, 2, 1}
        ll.Remove(3);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 6, 4, 35, 2, 2, 2, 1}
        ll.Remove(6);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 35, 2, 2, 2, 1}
        ll.Remove(1);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 35, 2, 2, 2}
        ll.Remove(7);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 35, 2, 2, 2}
        ll.Remove(5);
        Console.WriteLine(ll.ToString()); // <LinkedList>{4, 35, 2, 2, 2}
        ll.Remove(2);
        Console.WriteLine(ll.ToString()); // <LinkedList>{4, 35, 2, 2}

        var ll4 = new LinkedList();
        ll4.Remove(0);
        Console.WriteLine(ll4.ToString()); // <LinkedList>{}
        ll4.InsertHead(2);
        ll4.Remove(2);
        Console.WriteLine(ll4.ToString()); // <LinkedList>{}
        Console.WriteLine(ll4.HeadAndTailAreNull()); // True
        ll4.InsertHead(0);
        ll4.InsertHead(1);
        ll4.InsertHead(0);
        ll4.InsertHead(0);
        ll4.InsertAfter(0,2);
        Console.WriteLine(ll4.ToString()); // <linkedList>{0, 2, 0, 1, 0}
        ll4.Remove(2);
        Console.WriteLine(ll4.ToString()); // <linkedList>{0, 0, 1, 0}
        ll4.Remove(0);
        Console.WriteLine(ll4.ToString()); // <linkedList>{0, 1, 0}
        ll4.Remove(0);
        Console.WriteLine(ll4.ToString()); // <linkedList>{1, 0}
        ll4.Remove(1);
        Console.WriteLine(ll4.ToString()); // <linkedList>{0}
        ll4.Remove(0);
        Console.WriteLine(ll4.ToString()); // <linkedList>{}
        Console.WriteLine(ll4.HeadAndTailAreNotNull()); // False

        Console.WriteLine("\n=========== PROBLEM 4 TESTS ===========");
        ll.Replace(2, 10);
        Console.WriteLine(ll.ToString()); // <LinkedList>{4, 35, 10, 10}
        ll.Replace(7, 5);
        Console.WriteLine(ll.ToString()); // <LinkedList>{4, 35, 10, 10}
        ll.Replace(4, 100);
        Console.WriteLine(ll.ToString()); // <LinkedList>{100, 35, 10, 10}

        ll4.InsertHead(3);
        ll4.InsertTail(4);
        ll4.InsertAfter(3,5);
        ll4.InsertAfter(5,3);
        ll4.InsertAfter(3,4);
        ll4.InsertAfter(4,3);
        ll4.InsertAfter(3,5);
        Console.WriteLine(ll4.ToString()); // <LinkedList>{3, 5, 4, 3, 5, 3, 4}
        ll4.Replace(30, 10);
        Console.WriteLine(ll4.ToString()); // <LinkedList>{3, 5, 4, 3, 5, 3, 4}
        ll4.Replace(3,4);
        Console.WriteLine(ll4.ToString()); // <LinkedList>{4, 5, 4, 4, 5, 4, 4}
        ll4.Replace(4,5);
        Console.WriteLine(ll4.ToString()); // <LinkedList>{5, 5, 5, 5, 5, 5, 5}
        ll4.Replace(3,5);
        ll4.RemoveHead();
        Console.WriteLine(ll4.ToString()); // <LinkedList>{5, 5, 5, 5, 5, 5}
        ll4.Replace(4,5);
        Console.WriteLine(ll4.ToString()); // <LinkedList>{5, 5, 5, 5, 5, 5}
        ll4.Replace(5,0);
        Console.WriteLine(ll4.ToString()); // <LinkedList>{0, 0, 0, 0, 0, 0}

        Console.WriteLine("\n=========== PROBLEM 5 TESTS ===========");
        Console.WriteLine(ll.AsString()); // <IEnumerable>{100,35,10,10}
        Console.WriteLine(ll.Reverse().AsString()); // <IEnumerable>{10, 10, 35, 100}
        foreach(var item in ll){
            Console.WriteLine(item);
        } // 100 \n 35 \n 10 \n 10
        Console.WriteLine(""); // \n
        foreach(var item in ll.Reverse()){
            Console.WriteLine(item);
        } // 10 \n 10 \n 35 \n 100
    }
}