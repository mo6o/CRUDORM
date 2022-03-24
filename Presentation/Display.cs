using System;
using System.Collections.Generic;
using System.Text;
using minecraft.Data;
using minecraft.Business;
namespace minecraft.Presentation
{
    class Display
    {
        private int closeOperationId = 6;
        private ProductBusiness productBusiness = new ProductBusiness();
        public Display()
        {
            Input();
        }
        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string('', 18) + "MENU" + new string(''',18));
                Console.WriteLine(new string '-', 40));
            Console.WriteLine("1.List all entriess");
    }

}
