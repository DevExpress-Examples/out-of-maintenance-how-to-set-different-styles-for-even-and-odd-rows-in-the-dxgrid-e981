// Developer Express Code Central Example:
// How to set different styles for even and odd rows in the DXGrid
// 
// The following example demonstrates how to mark odd and even rows in a grid with
// different background colors.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E981

using System.Windows;

namespace OddEvenRows {

    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }
    }

    public class SimpleData {
        public string Column1 { get; set; }
        public int Column2 { get; set; }

        public SimpleData() { }

        public SimpleData(string str1, int int2) {
            Column1 = str1;
            Column2 = int2;
        }
    }
}
