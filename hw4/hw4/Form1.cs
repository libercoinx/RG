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
            //����ѡ���ļ��Ի���
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "��ѡ��һ���ı��ļ�";
            openFileDialog.Filter = "�ı��ļ� (*.txt)|*.txt";

            //�û����ȷ��
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputPath1 = openFileDialog.FileName;
                label_filepath1.Text = inputPath1;
            }
        }

        private void button_choose2_Click(object sender, EventArgs e)
        {
            //����ѡ���ļ��Ի���
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "��ѡ��һ���ı��ļ�";
            openFileDialog.Filter = "�ı��ļ� (*.txt)|*.txt";

            //�û����ȷ��
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
                //�ϲ������ļ�
                string outputPath = @".\Data";
                //������Data�ļ����򴴽�
                if (!Directory.Exists(outputPath))
                {
                    Directory.CreateDirectory(outputPath);
                }
                outputPath = Path.Combine(outputPath, output_filename.Text + ".txt");
                if (File.Exists(outputPath))
                {
                    DialogResult msRs;
                    msRs = MessageBox.Show("���ļ��Ѵ��ڣ��Ƿ񸲸ǣ�", "Attention", MessageBoxButtons.YesNo);
                    if (msRs == DialogResult.Yes)
                    {
                        using (StreamWriter sw = new StreamWriter(outputPath, false, System.Text.Encoding.Default))
                        {
                            //���м��룬��ֹ���
                            for (string s = sr1.ReadLine(); s != null; s = sr1.ReadLine())
                            {
                                sw.WriteLine(s);
                            }
                            for (string s = sr2.ReadLine(); s != null; s = sr2.ReadLine())
                            {
                                sw.WriteLine(s);
                            }
                        }
                        //��ʾ�ɹ��Ի���
                        MessageBox.Show("�ɹ������ļ���" + outputPath);
                    }
                }
                else
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(outputPath, true, System.Text.Encoding.Default))
                        {
                            //���м��룬��ֹ���
                            for (string s = sr1.ReadLine(); s != null; s = sr1.ReadLine())
                            {
                                sw.WriteLine(s);
                            }
                            for (string s = sr2.ReadLine(); s != null; s = sr2.ReadLine())
                            {
                                sw.WriteLine(s);
                            }
                        }
                        //��ʾ�ɹ��Ի���
                        MessageBox.Show("�ɹ������ļ���" + outputPath);
                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show("�ļ�����Ч������������");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected error:" + ex.Message);
                    }
                }
                //�ر�read�ļ���
                sr1.Close();
                sr2.Close();
            }
            catch
            {
                MessageBox.Show("��Ч�����ļ�");
            }
        }
    }
}
