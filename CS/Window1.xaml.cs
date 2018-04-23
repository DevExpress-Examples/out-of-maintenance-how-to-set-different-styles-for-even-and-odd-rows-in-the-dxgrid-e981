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
