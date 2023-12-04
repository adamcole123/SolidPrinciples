namespace InterfaceSegregationPrinciple.GoodExample
{
    public class OPS : U1Ops, U2Ops, U3Ops
    {
        public void OP1()
        {
            Console.WriteLine("12");
        }

        public void OP2()
        {
            Console.WriteLine("2");
        }

        public void OP3()
        {
            Console.WriteLine("3");
        }
    }
}
