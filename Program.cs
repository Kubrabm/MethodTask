namespace MethodTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArraysTask
            //var array = new ArraysTasks();

            //int[] y = array.FindSqrtElements();

            #endregion

            #region NumberTasks
            var number = new NumberTasks();

            int n = number.EnterNumber();
            number.Print(n);
            #endregion

        }
    }
}