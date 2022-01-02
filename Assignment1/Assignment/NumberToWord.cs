using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class NumberToWord
    {
        static void Main() {
            int[] n=new int[20];
            string word = ToWord(n);
            Console.WriteLine(word);
        }
        static String ToWord(int[] n) {
            string word="";
            for (int i = 0; i < n.Length; i++) {
                switch (n[i]) {
                    case 0 :
                        word=word+" Zero";
                        break;
                    case 1 :
                        word = word + " One";
                        break;
                    case 2 :
                        word=word+" Two";
                        break;
                    case 3:
                        word = word+ " Three";
                        break;
                    case 4:
                        word = word + " Four";
                        break;
                    case 5:
                        word = word + " Five";
                        break;
                    case 6:
                        word = word + " Six";
                        break;
                    case 7:
                        word = word + " Seven";
                        break;
                    case 8:
                        word = word + " Eight";
                        break;
                    case 9:
                        word = word + " Nine";
                        break;

                }
            }
            return word;
        }
    }
}
