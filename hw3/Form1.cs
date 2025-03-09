using clock;
using System.Diagnostics;

namespace hw3
{
    public partial class Form1 : Form
    {
        private Clock myClock;
        public Form1()
        {
            myClock = new Clock();

            InitializeComponent();

            //���¼�
            myClock.OnTick += update;
            myClock.OnAlarm += alarming;
        }

        //������ʾʱ��
        private void update(DateTime currentTime)
        {
            hourOut.Invoke(new Action(() => hourOut.Text = currentTime.Hour.ToString()));
            minOut.Invoke(new Action(() => minOut.Text = currentTime.Minute.ToString()));
            secOut.Invoke(new Action(() => secOut.Text = currentTime.Second.ToString()));
        }

        //����alarm�¼�����ʾ��ʱ�䵽��
        private void alarming()
        {
            alarmLabel.Invoke(new Action(() => alarmLabel.Visible = true));
            Debug.WriteLine("alarming");
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Alarm Set!");
            myClock.setAlarm((int)hourIn.Value, (int)minIn.Value, (int)secIn.Value);
            alarmLabel.Visible = false;    //��ʾ��ʱ�䵽��
            alarmTimeLabel.Text = hourIn.Value.ToString() + " : " + minIn.Value.ToString() + " : " + secIn.Value.ToString();    //����ui������ʾ������ʱ��
        }
    }
}
