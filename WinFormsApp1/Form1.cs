using System.Collections.ObjectModel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1() {
            Test();
            InitializeComponent();
        }
        /// <summary>
        /// Test is a private static method that outputs a message to the console.
        /// </summary>
        private static void Test()
        {
        	Console.WriteLine("Test method has been called.");
        }

        #region Overrides of Form

        /// 
        protected override void SetVisibleCore(
	        bool value)
        {

        }

		#endregion
	}
    
    
}
