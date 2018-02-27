namespace Benchmark
{
    public abstract class Test
    {
        protected const int RUN_AMOUNT = 100000000;


        public void RunCSharpTests(){

            for(int i = 0; i < RUN_AMOUNT; i++)
                TestCSharp();
            
        }

        public void RunFSharpTests(){

            for(int i = 0; i < RUN_AMOUNT; i++)
                TestFSharp();
            
        }

        protected abstract void TestCSharp();
        protected abstract void TestFSharp();

    }
    
}