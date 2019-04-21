using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Timers;

namespace SimpleTimer
{
    [Activity(Label = "Timer Lam 3", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private Button startButton;
        private Button stopButton;
        private Button resetButton;
        private TextView clock;
        private double counter;
        System.Timers.Timer clockTimer = new System.Timers.Timer();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
            clock = FindViewById<TextView>(Resource.Id.timeCounter);
            startButton = FindViewById<Button>(Resource.Id.startButton);
            stopButton = FindViewById<Button>(Resource.Id.stopButton);
            resetButton = FindViewById<Button>(Resource.Id.resetButton);

            counter = 0;
            startButton.Click += Button_Click;
            stopButton.Click += Button_Click;
            resetButton.Click += Button_Click;

            clock.Text = counter.ToString();
            clockTimer.Interval = 1000;
            clockTimer.Elapsed += updateCounter;
            clockTimer.AutoReset = true;


            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (btn.Id)
            {
                case Resource.Id.startButton:
                    {
                        if (!clockTimer.Enabled)
                        {
                            clockTimer.Start();
                        }
                        break;
                    }

                case Resource.Id.stopButton:
                    {
                        if (clockTimer.Enabled)
                        {
                            clockTimer.Stop();
                        }
                        break;
                    }

                case Resource.Id.resetButton:
                    {
                        if (clockTimer.Enabled)
                        {
                            clockTimer.Stop();
                        }
                        resetCounter();
                        break;
                    }
            }
        }

        private void updateCounter(Object source, System.Timers.ElapsedEventArgs e)
        {
            counter++;
            RunOnUiThread(() =>
            {
                clock.Text = counter.ToString();
            });

        }

        private void resetCounter()
        {
            counter = 0;
            clock.Text = counter.ToString();
        }
    }
}
