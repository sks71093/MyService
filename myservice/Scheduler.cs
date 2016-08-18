using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace myservice
{
    public partial class Scheduler : ServiceBase
    {
        public int i;
        private Timer timer1 = null;
        public Scheduler()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
           timer1 = new Timer();
            this.timer1.Interval = 1;
            this.timer1.Elapsed += timer1_tick;
            timer1.Enabled = true;
            i = 1;
            Library.WriteErrorLog("The timer been started");
        }

        private void timer1_tick(object sender, ElapsedEventArgs e)
        {
            
            Library.WriteErrorLog(String.Format("Task {0} has been completed", i));
            i++;
        }
        

        protected override void OnStop()
        {
            timer1.Enabled = false;
            Library.WriteErrorLog("Window Service has been Stopped");
           
        }
    }
}
