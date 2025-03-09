using System;
using System.Diagnostics;
using System.Threading;

namespace clock
{
    public delegate void TickEvent(DateTime time);
    public delegate void AlarmEvent();
    public class Clock
    {
        private DateTime currentTime;    //当前时间
        private DateTime alarmTime;    //响铃时间
        public TickEvent? OnTick;    //走时事件
        public AlarmEvent? OnAlarm;    //响铃事件

        public Clock()
        {
            currentTime = DateTime.Now;
            alarmTime = new DateTime();
            timerRun();
        }

        //设置响铃时间
        public void setAlarm(int hour, int min, int sec)
        {
            alarmTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, hour, min, sec);
        }

        public void timerRun()
        {
            System.Threading.Timer timer = new System.Threading.Timer(_ =>
            {
                //一秒刷新一次
                currentTime = DateTime.Now;
                if (OnTick != null) OnTick(currentTime);    //刷新winform时间显示
                if ((OnAlarm != null) && (currentTime.ToString("HH:mm:ss") == alarmTime.ToString("HH:mm:ss")))    //只截取时分秒
                {
                    OnAlarm();    //触发响铃
                    Debug.WriteLine("Alarming from timer");
                }
            }, null, 0, 1000);
            //System.Threading.Timer timer1 = new System.Threading.Timer(_ =>
            //{
            //    if ((OnAlarm != null) && (currentTime.ToString("yyyy-MM-dd HH:mm:ss") == alarmTime.ToString("yyyy-MM-dd HH:mm:ss")))
            //    {
            //        OnAlarm();
            //        Debug.WriteLine("Alarming from timer");    //触发响铃
            //    }
            //}, null, 0, 1);
        }
    }
}
