﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Service
{
    public partial class Service1 : ServiceBase
    {
        Timer timer = new Timer(); 
        GestionTaches service = new GestionTaches();
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            service.taches();
            Console.WriteLine("Le service a commencé à  " + DateTime.Now);
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 86400000; //jour en millisecondes
            timer.Enabled = true;
        }

        protected override void OnStop()
        {
            service.taches();
            Console.WriteLine("Le service a été arreté à " + DateTime.Now);
        }

        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            service.taches();
            Console.WriteLine("Rappel du service à " + DateTime.Now);
        }
    }
}
