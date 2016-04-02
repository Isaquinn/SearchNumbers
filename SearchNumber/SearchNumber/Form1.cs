using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace SearchNumber
{
    public partial class Form1 : Form
    {
        static Stopwatch stopwatch = new Stopwatch();
        static TimeSpan ts;
        static List<string> numbers = new List<string>();
        int value;
        static int contador;
        static Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void GerarNumeros_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            contador = numbers.Count;
            while (contador < 1000)
            {
                value = random.Next(0,5000);
                contador++;
                NoRepeat(value.ToString());
                BubbleSort(numbers);
               
            }
            listBox1.Items.AddRange(numbers.ToArray());

        }
        static void NoRepeat(string item)
        {

            if (!numbers.Contains(item))
            {

                numbers.Add(item);
            }
            else
            {
               contador--;
            }
        }
        static void BubbleSort(List<string> numeros)
        {
            for (int i = 0; i < numeros.Count; i++)
            {
                for (int k = i + 1; k < numeros.Count; k++)
                {
                    if (int.Parse(numeros[i]) > int.Parse(numeros[k]))
                    {
                        int temp = int.Parse(numeros[i]);
                        numeros[i] = numeros[k];
                        numeros[k] = temp.ToString();
                    }
                }
            }
        }

        private void SearchLinear_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            int search = int.Parse(textBox1.Text) ;

            int result = linearSearch(numbers, search.ToString());

            if (result == -1)
            {
                MessageBox.Show("O número não existe na lista");
                return;
            }
            stopwatch.Stop();
            ts = stopwatch.Elapsed;
            //Precisa ser resolvido
            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",ts.TotalHours + "Horas", ts.TotalMinutes + "Minutos", ts.TotalSeconds + "Segundos", ts.TotalMilliseconds + "Milesimos");
           

            MessageBox.Show("O valor " + search + " está no índice " + result + " e isso levou " + ts);
        }
        public static int linearSearch(List<string> list, string value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int BinarySearch(List<string> list,string valor)
        {
            stopwatch.Restart();
            int min = 0;
            int max = list.Count - 1;
            while (max >= min)
            {
                
                int mid = (min + max) / 2;

               
                if (int.Parse(list[mid]) < int.Parse(valor)) min = mid + 1;  

                else if (int.Parse(list[mid]) > int.Parse(valor)) max = mid - 1;

                else {
                    stopwatch.Stop();
                    MessageBox.Show(" O valor " + valor+ " foi encontrado na posição " + mid + " e isso levou " + stopwatch.Elapsed);
                    return mid; 
                } 
            }
            MessageBox.Show("O número não existe na lista");
            return -1;
        }
        private void SearchBinary_Click(object sender, EventArgs e)
        {
            
            int sercah = int.Parse(textBox1.Text);
            BinarySearch(numbers,sercah.ToString());
            
        }
    }
}
