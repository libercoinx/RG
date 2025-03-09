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

            //绑定事件
            myClock.OnTick += update;
            myClock.OnAlarm += alarming;
        }

        //更新显示时间
        private void update(DateTime currentTime)
        {
            hourOut.Invoke(new Action(() => hourOut.Text = currentTime.Hour.ToString()));
            minOut.Invoke(new Action(() => minOut.Text = currentTime.Minute.ToString()));
            secOut.Invoke(new Action(() => secOut.Text = currentTime.Second.ToString()));
        }

        //触发alarm事件，显示“时间到”
        private void alarming()
        {
            alarmLabel.Invoke(new Action(() => alarmLabel.Visible = true));
            Debug.WriteLine("alarming");
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Alarm Set!");
            myClock.setAlarm((int)hourIn.Value, (int)minIn.Value, (int)secIn.Value);
            alarmLabel.Visible = false;    //显示“时间到”
            alarmTimeLabel.Text = hourIn.Value.ToString() + " : " + minIn.Value.ToString() + " : " + secIn.Value.ToString();    //设置ui界面显示的闹铃时间
        }
    }
}
