using Hydro;

namespace RazorTest.Views.Components
{
    public class Counter : HydroComponent
    {
        public int Count { get; set; }

        public void Add()
        {
            Count++;
        }
    }
}
