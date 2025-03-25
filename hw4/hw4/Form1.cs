namespace hw4
{
    public partial class Form1 : Form
    {
        private string inputPath1 = "";
        private string inputPath2 = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_choose1_Click(object sender, EventArgs e)
        {
            //弹出选择文件对话框
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "请选择一个文本文件";
            openFileDialog.Filter = "文本文件 (*.txt)|*.txt";

            //用户点击确定
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputPath1 = openFileDialog.FileName;
                label_filepath1.Text = inputPath1;
            }
        }

        private void button_choose2_Click(object sender, EventArgs e)
        {
            //弹出选择文件对话框
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "请选择一个文本文件";
            openFileDialog.Filter = "文本文件 (*.txt)|*.txt";

            //用户点击确定
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputPath2 = openFileDialog.FileName;
                label_filepath2.Text = inputPath2;
            }
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr1 = new StreamReader(inputPath1, System.Text.Encoding.Default);
                StreamReader sr2 = new StreamReader(inputPath2, System.Text.Encoding.Default);
                //合并两个文件
                string outputPath = @".\Data";
                //不存在Data文件夹则创建
                if (!Directory.Exists(outputPath))
                {
                    Directory.CreateDirectory(outputPath);
                }
                outputPath = Path.Combine(outputPath, output_filename.Text + ".txt");
                if (File.Exists(outputPath))
                {
                    DialogResult msRs;
                    msRs = MessageBox.Show("该文件已存在，是否覆盖？", "Attention", MessageBoxButtons.YesNo);
                    if (msRs == DialogResult.Yes)
                    {
                        using (StreamWriter sw = new StreamWriter(outputPath, false, System.Text.Encoding.Default))
                        {
                            //逐行加入，防止溢出
                            for (string s = sr1.ReadLine(); s != null; s = sr1.ReadLine())
                            {
                                sw.WriteLine(s);
                            }
                            for (string s = sr2.ReadLine(); s != null; s = sr2.ReadLine())
                            {
                                sw.WriteLine(s);
                            }
                        }
                        //显示成功对话框
                        MessageBox.Show("成功生成文件：" + outputPath);
                    }
                }
                else
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(outputPath, true, System.Text.Encoding.Default))
                        {
                            //逐行加入，防止溢出
                            for (string s = sr1.ReadLine(); s != null; s = sr1.ReadLine())
                            {
                                sw.WriteLine(s);
                            }
                            for (string s = sr2.ReadLine(); s != null; s = sr2.ReadLine())
                            {
                                sw.WriteLine(s);
                            }
                        }
                        //显示成功对话框
                        MessageBox.Show("成功生成文件：" + outputPath);
                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show("文件名无效，请重新输入");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected error:" + ex.Message);
                    }
                }
                //关闭read文件流
                sr1.Close();
                sr2.Close();
            }
            catch
            {
                MessageBox.Show("无效输入文件");
            }
        }
    }
}
