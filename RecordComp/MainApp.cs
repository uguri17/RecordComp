using System;

namespace RecordComp
{
    class CTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From} -> {To} : ${Amount}";
        }
    }

    record RTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From} -> {To} : ${Amount}";
        }
    }


    class MainApp
    {
        static void Main(string[] args)
        {
            CTransaction ctrA = new CTransaction()
            {
                From = "Alice",
                To = "Bob",
                Amount = 100
            };

            CTransaction ctrB = new CTransaction()
            {
                From = "Alice",
                To = "Bob",
                Amount = 100
            };

            Console.WriteLine(ctrA);
            Console.WriteLine(ctrB);
            Console.WriteLine($"trA == trB: {ctrA.Equals(ctrB)}");
            // class는 참조형식이라 주소를 비교하기에
            // 각 객체가 할당 되어 있는 주소가 다르기에 'false'가 나옴
            //----------------------------------------------------
            //

            RTransaction rtrA = new RTransaction()
            {
                From = "Alice",
                To = "Bob",
                Amount = 100
            };

            RTransaction rtrB = new RTransaction()
            {
                From = "Alice",
                To = "Bob",
                Amount = 100
            };

            Console.WriteLine(rtrA);
            Console.WriteLine(rtrB);
            Console.WriteLine($"trA == trB: {rtrA.Equals(rtrB)}");
            // 값을 비교해서 'True'가 나옴
        }
    }
}
