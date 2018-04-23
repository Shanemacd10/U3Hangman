/* Shane MacDonald
 * U3Hangman
 * April 23, 2018
 * Program runs allows you to guess letter to form a word. If you get 6 wrong you lose
 */
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

namespace U3Hangman
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string word = "";
        int counter = 0;
        int timeswrong = 0;
        int length;
        int timesright = 0;

        public MainWindow()
        {
            InitializeComponent();
            System.IO.StreamReader streamReader = new System.IO.StreamReader("H:/hangman.txt");
            Random random = new Random();
            int rnd = random.Next(0, 10);
            while (counter <= rnd)
            {
               word = streamReader.ReadLine();
                counter++;
               
            }
            length = Convert.ToInt32(word.Length);
            for (int i = 0; i <= length; i++)
            {
                lblWord.Content = lblWord.Content + "_ ";
            }
            
        }

        private void btnFinalGuess_Click(object sender, RoutedEventArgs e)
        {
            if (txtGuessFinal.Text.ToLower() == word)
            {
                lblWord.Content = word;
                MessageBox.Show("You Win");
                Environment.Exit(0);
            }
            else
            {
                timeswrong++;
            }
        }
        public void replaceLbl(string x)
        {
            if (word.Contains(x))
            {
                for (int i = 0; i < length; i++)
                {
                    if (word[i] == x[0])
                    {
                        string temp = lblWord.Content.ToString().Remove(i * 2 + 2, 1);
                        temp = temp.Insert((i + 1) * 2, x);
                        lblWord.Content = temp;
                        timesright++;
                    }
                }
            }
            else
            {
                timeswrong++;
                elpsHead.Visibility = Visibility.Visible;

                if(timeswrong == 2)
                {
                    linBody.Visibility = Visibility.Visible;
                }

                if (timeswrong == 3)
                {
                    linLegLeft.Visibility = Visibility.Visible;
                }

                if (timeswrong == 4)
                {
                    linLegRight.Visibility = Visibility.Visible;
                }

                if (timeswrong == 5)
                {
                    linArmLeft.Visibility = Visibility.Visible;
                }

                if (timeswrong == 6)
                {
                    linArmRight.Visibility = Visibility.Visible;
                    MessageBox.Show("You Lose");
                    Environment.Exit(0);
                }
            }

            if(timesright == length)
            {
                MessageBox.Show("You Win");
                Environment.Exit(0);
            }

        }
        
        private void btnA_Click(object sender, RoutedEventArgs e)
        {
            btnA.Visibility = Visibility.Hidden;
            replaceLbl("a");
                    }

        private void btnB_Click(object sender, RoutedEventArgs e)
        {
            btnB.Visibility = Visibility.Hidden;
            replaceLbl("b");
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            btnC.Visibility = Visibility.Hidden;
            replaceLbl("c");
        }

        private void btnD_Click(object sender, RoutedEventArgs e)
        {
            btnD.Visibility = Visibility.Hidden;
            replaceLbl("d");
        }

        private void btnE_Click(object sender, RoutedEventArgs e)
        {
            btnE.Visibility = Visibility.Hidden;
            replaceLbl("e");
        }

        private void btnF_Click(object sender, RoutedEventArgs e)
        {
            btnF.Visibility = Visibility.Hidden;
            replaceLbl("f");
        }

        private void btnG_Click(object sender, RoutedEventArgs e)
        {
            btnG.Visibility = Visibility.Hidden;
            replaceLbl("g");
        }

        private void btnH_Click(object sender, RoutedEventArgs e)
        {
            btnH.Visibility = Visibility.Hidden;
            replaceLbl("h");
        }

        private void btnI_Click(object sender, RoutedEventArgs e)
        {
            btnI.Visibility = Visibility.Hidden;
            replaceLbl("i");
        }

        private void btnJ_Click(object sender, RoutedEventArgs e)
        {
            btnJ.Visibility = Visibility.Hidden;
            replaceLbl("j");
        }

        private void btnK_Click(object sender, RoutedEventArgs e)
        {
            btnB.Visibility = Visibility.Hidden;
            replaceLbl("k");
        }

        private void btnL_Click(object sender, RoutedEventArgs e)
        {
            btnL.Visibility = Visibility.Hidden;
            replaceLbl("l");
        }

        private void btnM_Click(object sender, RoutedEventArgs e)
        {
            btnM.Visibility = Visibility.Hidden;
            replaceLbl("m");
        }

        private void btnN_Click(object sender, RoutedEventArgs e)
        {
            btnN.Visibility = Visibility.Hidden;
            replaceLbl("n");
        }

        private void btnO_Click(object sender, RoutedEventArgs e)
        {
            btnO.Visibility = Visibility.Hidden;
            replaceLbl("o");
        }

        private void btnP_Click(object sender, RoutedEventArgs e)
        {
            btnP.Visibility = Visibility.Hidden;
            replaceLbl("p");
        }

        private void btnQ_Click(object sender, RoutedEventArgs e)
        {
            btnQ.Visibility = Visibility.Hidden;
            replaceLbl("q");
        }

        private void btnR_Click(object sender, RoutedEventArgs e)
        {
            btnR.Visibility = Visibility.Hidden;
            replaceLbl("r");
        }

        private void btnS_Click(object sender, RoutedEventArgs e)
        {
            btnS.Visibility = Visibility.Hidden;
            replaceLbl("s");
        }

        private void btnT_Click(object sender, RoutedEventArgs e)
        {
            btnT.Visibility = Visibility.Hidden;
            replaceLbl("t");
        }

        private void btnU_Click(object sender, RoutedEventArgs e)
        {
            btnU.Visibility = Visibility.Hidden;
            replaceLbl("u");
        }

        private void btnV_Click(object sender, RoutedEventArgs e)
        {
            btnV.Visibility = Visibility.Hidden;
            replaceLbl("v");
        }

        private void btnW_Click(object sender, RoutedEventArgs e)
        {
            btnW.Visibility = Visibility.Hidden;
            replaceLbl("w");
        }

        private void btnX_Click(object sender, RoutedEventArgs e)
        {
            btnX.Visibility = Visibility.Hidden;
            replaceLbl("x");
        }

        private void btnY_Click(object sender, RoutedEventArgs e)
        {
            btnY.Visibility = Visibility.Hidden;
            replaceLbl("y");
        }

        private void btnZ_Click(object sender, RoutedEventArgs e)
        {
            btnZ.Visibility = Visibility.Hidden;
            replaceLbl("z");
        }

        private void txtGuessFinal_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        
    }
    
}
