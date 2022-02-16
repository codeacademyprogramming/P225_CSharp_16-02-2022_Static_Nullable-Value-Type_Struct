namespace P225NullableValueTypeEnumStruct
{
    struct AreaCalculate
    {
        public int A;
        public int B;
        public int C { get; set; }


        //public AreaCalculate(int a, int b)
        //{
        //    A = a;
        //    B = b;
        //    C = 3;
        //}

        //public AreaCalculate(int a)
        //{
        //    A = a;
        //    B = 7;
        //}

        public int Calculate()
        {
            return A * B;
        }
    }
}
