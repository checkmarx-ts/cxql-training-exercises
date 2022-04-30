namespace Test
{
    class Test
    {
        private String testOne(int i)
        {
            switch (i)
            {
                case 1:
                    return "One";
                case 2:
                    return "Two";
                default:
                    return "More than two";
            }
        }

        private int testTwo(bool val)
        {
            switch (val)
            {
                case true:
                    return 1;
                case false:
                    return 0;
            }
        }
    }
}
