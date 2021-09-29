using System;
using Day14LinkedList;
using System.Collections.Generic;
using Day14LinkedList.UC2_LinkedList;
using Day14LinkedList.UC3_LinkedList;
using Day14LinkedList.UC5_LinkedList;
using Day14LinkedList.UC4_LinkedList;
using Day14LinkedList.UC6_LinkedList;
using Day14LinkedList.UC7_LinkedList;
using Day14LinkedList.UC8_LinkedList;
using Day14LinkedList.UC9_LinkedList;
using Day14LinkedList.UC10_LinkedList;

namespace Day14LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region UC1
            //UC1_CreateSimpleLinkedList list = new UC1_CreateSimpleLinkedList();
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            //Console.WriteLine("\n Final Sequence ");
            //list.Display();
            //#endregion

            //#region UC2
            //UC2_Add30n56to70 list1 = new UC2_Add30n56to70();
            //list1.Add(70);
            //list1.Display();
            //list1.InsertAtParticularPosition(1, 30);
            //list1.InsertAtParticularPosition(1, 56);
            //Console.WriteLine("\n Final Sequence ");
            //list1.Display();
            //#endregion

            //#region UC3
            //UC3_Add30n70to56 list2 = new UC3_Add30n70to56();
            //list2.Add(56);
            //list2.Display();
            //list2.Append(30);
            //list2.Append(70);
            //Console.WriteLine("\n Final Sequence ");
            //list2.Display();
            //#endregion

            // #region UC4
            //UC4_Add30in56n70 list3 = new UC4_Add30in56n70();
            //list3.Add(56);
            //list3.Add(70);
            //list3.Display();
            //list3.InsertAtParticularPosition(2, 30);
            //Console.WriteLine("\n Final Sequence ");
            //list3.Display();
            //#endregion

            #region UC5
            UC5_Del1stEle list4 = new UC5_Del1stEle();
            list4.Add(56);
            list4.Add(30);
            list4.Add(70);
            list4.Display();
            list4.RemoveFirstNode();
            Console.WriteLine("\n Final Sequence ");
            list4.Display();
            #endregion

            //#region UC6
            //UC6_DelLastEle list5 = new UC6_DelLastEle();
            //list5.Add(56);
            //list5.Add(30);
            //list5.Add(70);
            //list5.Display();
            //list5.RemoveLastNode();
            //Console.WriteLine("\n Final Sequence ");
            //list5.Display();
            //#endregion

            //#region
            //UC7_Search30 list6 = new UC7_Search30();
            //list6.Add(56);
            //list6.Add(30);
            //list6.Add(70);
            //list6.Display();
            //list6.Search(30);
            //Console.WriteLine("\n Final Sequence ");
            //list6.Display();
            //#endregion

            //#region UC8
            //UC8_Insert40aft30 list7 = new UC8_Insert40aft30();
            //list7.Add(56);
            //list7.Add(30);
            //list7.Add(70);
            //list7.Display();
            //list7.Search(30);
            //list7.InsertAtParticularPosition(2, 40);
            //Console.WriteLine("\n Final Sequence ");
            //list7.Display();
            //#endregion

            //#region UC9
            //UC9_SearchnDel40fromSeq list8 = new UC9_SearchnDel40fromSeq();
            //list8.Add(56);
            //list8.Add(30);
            //list8.Add(40);
            //list8.Add(70);
            //list8.Display();
            ////list8.Search(40);
            //list8.Delete(40);
            //Console.WriteLine("\n Final Sequence ");
            //list8.Display();
            //Console.WriteLine("\ncount= "+ list8.Count());
            //#endregion

            //#region UC10
            //UC10_SortedLinkedList list9 = new UC10_SortedLinkedList();
            //list9.Add(56);
            //list9.Add(30);
            //list9.Add(40);
            //list9.Add(70);
            //Console.WriteLine("\n Sequence");
            //list9.Display();
            //list9.Sort(56);
            //list9.Sort(30);
            //list9.Sort(40);
            //list9.Sort(70);
            //Console.WriteLine("\n Final Sequence ");
            //list9.Display();
            //#endregion

            Console.ReadKey();
        }
    }
}
