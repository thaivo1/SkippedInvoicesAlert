using System;

namespace SkippedInvoicesAlert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SkippedInvoicesAlert project starts");

            string sInvoiceData = GetInvoiceData();

            string sEmail = SendEmailToCustomers();



            Console.WriteLine("Press any key to continue.");
            Console.Read();

        }

        public static string GetInvoiceData()
        {
            Console.WriteLine("Start GetInvoiceData()");

            Console.WriteLine("End GetInvoiceData()");
            return "Done get data";
        }

        public static string SendEmailToCustomers()
        {
            Console.WriteLine("Start SendEmailToCustomers()");

            Console.WriteLine("End SendEmailToCustomers()");
            return "Done sending email";
        }

        public static string RecordActionsToDatabase()
        {
            Console.WriteLine("Start RecordActionsToDatabase()");

            Console.WriteLine("End RecordActionsToDatabase()");
            return "Done record action to database";
        }
    }


}
