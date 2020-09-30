using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace English_test_app
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();

        int Right = 0;
        int Wrong = 50;

        public Form1()
        {
            InitializeComponent();
            dt.Columns.Add("Question", typeof(string));
            dt.Columns.Add("Answer", typeof(string));
            dt.Columns.Add("Result", typeof(string));
        }

        private void bt_File_Read__Click(object sender, EventArgs e)
        {
            txt_Box_.Text = "";

            string filePath = txt_Dir_.Text + "/" + txt_Name_.Text;

            string filePathAsw = txt_Dir_.Text + "/DapAn_01.txt";
            string[] lines = File.ReadAllLines(filePathAsw);

            StreamReader rd = new StreamReader(filePath);

            string Test = rd.ReadToEnd();

            if (File.Exists(filePath))
            {
                txt_Box_.Text = Test;
            }
            else
            {
                txt_Box_.Text = "file ko ton tai";
            }

            /*ý tưởng:
             Nhấn vào nút đọc file: nó đọc file text r in ra text box
            r sử dụng hàm split? đọc file đó lên dãy question::
            -- dùng hàm lặp cho tới hết file, 
            --tìm các chữ question, 
            --cho n = 1 rồi ++ lên mỗi lần lặp, bỏ
            chữ question + i vào bảng vào Bảng, rồi xuống hàng
            --
            
            //lặp từ row 1-> i
            // add vào column 0 trong row
            //i lấy từ số Question trong text box

            //int count = Test.Split('Question').Length - 1;
            //int count = Test.Count(f => f == "QQ");
            //txt_True_.Text  = Convert.ToString(count);

            //count(Predicate< 'T'>);



            ////Predicate<in Test > ("question");
            //string[] a = str.Split(' ');

            //// search for pattern in string 
            //int count = 0;
            //for (int i = 0; i < a.Length; i++)
            //{

            //    // if match found increase count 
            //    if (word.Equals(a[i]))
            //        count++;
            //}
        */


            for (int i = 1; i <= lines.Length; i++)
            {
                this.dataGridView1.Rows.Add("QuesTion " + i);
            }




        }

        private void bt_Answer__Click(object sender, EventArgs e)
        {

            

            string filePath = txt_Dir_.Text + "/DapAn_01.txt";

            StreamReader rd = new StreamReader(filePath);

            string Test = rd.ReadToEnd();




            string[] lines = File.ReadAllLines(filePath);

            Right = 0;
            Wrong = lines.Length;

            for (int i = 0; i < lines.Length; i++)
            {
                dataGridView1.Rows[i].Cells[2].Value = lines[i];

            }

            
            for (int j = 0; j < lines.Length; j++)
            {
                if(dataGridView1.Rows[j].Cells[1].Value != null)
                {
                    if (dataGridView1.Rows[j].Cells[1].Value.ToString() == lines[j])
                    {
                        Right++;
                        Wrong--;
                    }
                }
                
            }

            txt_True_.Text = Convert.ToString(Right);
            txt_False_.Text = Convert.ToString(Wrong);

            //var lines = rd.ReadLine();
            //var values = lines.Split('B');
            //txt_False_.Text = values[0];


            //{
            //    while (!rd.EndOfStream)
            //    {
            //        var line = rd.ReadLine();
            //        var values = line.Split('B');
            //        var rowIndex = dataGridView1.Rows.Add();
            //        txt_False_.Text = values[0];
            //        for (int i = 0; i < values.Length; i++)
            //        {
            //            dataGridView1.Rows[3].Cells[i].Value = values[i];
            //        }
            //    }
            //}

            //string[] lines = File.ReadAllLines(filePath); //50
            //string[] Values;
            //txt_True_.Text = Convert.ToString(lines.Length);


            //for ( int i = 0; i< lines.Length; i++)
            //{
            //    Values = lines[i].ToString().Split('\t');
            //    string[] row = new string[Values.Length];



            //    for (int j = 0; j < Values.Length; j++)
            //    {
            //        row[j] = Values[j].Trim();
            //    }


        }    

           



    }

        /*ý tưởng: như trên
         dùng hàm lặp, tìm chữ cái rồi bỏ vô bảng
        khi có kí tự xuống dòng thì kết thúc 1 hàng 
        
         sau đó dùng lặp so sáng 2 bảng asw vs result, đúng sai ++ lên, r cho lại lên box
        */


    
}
