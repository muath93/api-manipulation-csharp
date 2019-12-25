using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton1_ClickAsync ( object sender, EventArgs e)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");

            HttpResponseMessage res = client.GetAsync("/users").Result;

            var json = res.Content.ReadAsStringAsync().Result;

            var data = JsonConvert.DeserializeObject<List<RootObject>>(json);

          //  Console.WriteLine(data);

            dataGridView1.DataSource = data;



        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //Delete
        }

        private async void button2_Click(object sender, EventArgs e)
        {

            var id = t_id.Text;

            if (id !="")
            {
               
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");

                HttpResponseMessage res = await client.GetAsync("/users/" + id);

                var json = await res.Content.ReadAsStringAsync();

               var data = JsonConvert.DeserializeObject<RootObject>(json);

                List<RootObject> primes = new List<RootObject>();

                primes.Add(data);
            
                Console.WriteLine(primes);

                dataGridView1.DataSource = primes;
            }

         
        }
    }
}
