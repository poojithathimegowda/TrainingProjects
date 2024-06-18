
    public class OuterClass
    {
        private class InnerClass
        {
            public void InnerMethod()
            {
                Console.WriteLine("Inner method called");
            }
        }

         public void OuterMethod()
        {
            InnerClass innerObj = new InnerClass();
            innerObj.InnerMethod();

           
        }
    }



