using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ThinkLib;

namespace MyStrings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int length(string a)
        {
            int number = 0;
            foreach(char letter in a)
            {
                number++;
            }
            return number;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(length("hello"), 5);
            Tester.TestEq(length("csc"), 3);
            Tester.TestEq(length("visual studio"), 13);
            Tester.TestEq(length("university"), 10);
            Tester.TestEq(length("rhodes"), 6);

        }
        bool contains(string b,string c)
        {
            foreach(char letter in b)
            {
                string d = Convert.ToString(letter);
                if (d == c)
                {
                    return true;
                }
            }
            return false;
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(contains("hello", "e"), true);
            Tester.TestEq(contains("csc", "b"), false);
            Tester.TestEq(contains("visual studio", "d"), true);
            Tester.TestEq(contains("university", "z"), false);
            Tester.TestEq(contains("rhodes", "o"), true);

        }
        int IndexOf(string e,string f)
        {
            int index = 0;
            foreach(char letter in e)
            {
                string g = Convert.ToString(letter);
                if(g == f)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(IndexOf("hello", "l"), 2);
            Tester.TestEq(IndexOf("csc", "d"), -1);
            Tester.TestEq(IndexOf("visual studio", "a"), 4);
            Tester.TestEq(IndexOf("university", "y"), 9);
            Tester.TestEq(IndexOf("rhodes", "r"), 0);
        }
        string Insert(string h,string i,int j)
        {
            int index = 0;
            string k = "";
            while(index< j)
            {
                string l = Convert.ToString(h[index]);
                k = k + l;
                index++;
            }
            k = k + i;
            int number = 0;
            foreach (char letter in h)
            {
                number++;
            }
            while (index >=j && index < number)
            {
                string m = Convert.ToString(h[index]);
                k = k + m;
                index++;
            }
            return k;

        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(Insert("helo", "l", 2), "hello");
            Tester.TestEq(Insert("cc", "s", 1), "csc");
            Tester.TestEq(Insert("visua studio", "l", 5), "visual studio");
            Tester.TestEq(Insert("universty", "i", 7), "university");
            Tester.TestEq(Insert("hodes", "r", 0), "rhodes");

        }
        string replace(string n,string o,string p)
        {
            int q = IndexOf(n, o);
            int index = 0;
            string r = "";
            int number = 0;
            foreach (char letter in n)
            {
                number++;
            }
            while (index< q)
            {
                string s = Convert.ToString(n[index]);
                r = r + s;
                index++;
            }
            r = r + p;
            index++;
            while (index < number)
            {
                string t = Convert.ToString(n[index]);
                r = r + t;
                index++;
            }
            return r;
        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(replace("halo", "a", "el"), "hello");
            Tester.TestEq(replace("cdc", "d", "s"), "csc");
            Tester.TestEq(replace("visuak studio", "k", "l"), "visual studio");
            Tester.TestEq(replace("univasity", "a", "er"), "university");
            Tester.TestEq(replace("rhodes", "s", "nts"), "rhodents");
        }
        string delete(string s,string t)
        {
            int u = IndexOf(s, t);
            int index = 0;
            string v = "";
            while (index < u)
            {
                string w = Convert.ToString(s[index]);
                v = v + w;
                index++;
            }
            int number = 0;
            foreach (char letter in s)
            {
                number++;
            }
            index++;
            while (index < number)
            {
                string x = Convert.ToString(s[index]);
                v = v + x;
                index++;
            }
            return v;


        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(delete("hallo", "l"), "halo");
            Tester.TestEq(delete("csdc", "d"), "csc");
            Tester.TestEq(delete("visuyal studio", "y"), "visual studio");
            Tester.TestEq(delete("universioty", "o"), "university");
            Tester.TestEq(delete("rhowdes", "w"), "rhodes");
        }
    }
}
