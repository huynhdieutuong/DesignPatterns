using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_SOLID
{
    public static class InterfaceSegregation
    {
        public static void Main()
        {

        }
    }

    public class Document { }

    // IMachine is large. When implement OldFashionedPrinter, we don't need implement Fax & Scan method
    //public interface IMachine
    //{
    //    void Print(Document d);
    //    void Fax(Document d);
    //    void Scan(Document d);
    //}

    //public class MultiFunctionPrinter : IMachine
    //{
    //    public void Fax(Document d)
    //    {
    //        // Do something
    //    }

    //    public void Print(Document d)
    //    {
    //        // Do something
    //    }

    //    public void Scan(Document d)
    //    {
    //        // Do something
    //    }
    //}

    //public class OldFashionedPrinter : IMachine
    //{
    //    public void Fax(Document d)
    //    {
    //        // Yep
    //    }

    //    public void Print(Document d)
    //    {
    //        // Nope
    //    }

    //    public void Scan(Document d)
    //    {
    //        // Nope
    //    }
    //}

    // Split MultiFunctionPrinter into IPrinter, IScanner, IFaxer
    public interface IPrinter
    {
        void Print(Document document);
    }
    public interface IScanner
    {
        void Scan(Document document);
    }
    public interface IFaxer
    {
        void Print(IFaxer faxer);
    }

    public interface IMultiFunctionPrinter : IPrinter, IScanner, IFaxer
    {

    }

    public class MultiFunctionPrinter : IMultiFunctionPrinter
    {
        public void Print(Document document)
        {
            // Do something
        }

        public void Print(IFaxer faxer)
        {
            // Do something
        }

        public void Scan(Document document)
        {
            // Do something
        }
    }

    public class OldFashionedPrinter : IPrinter
    {
        public void Print(Document document)
        {
            // Do something
        }
    }
}
