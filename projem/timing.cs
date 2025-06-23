using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projem
{
    public class Timing
    {
        private readonly Timer timer;
        private readonly Label targetLabel;
        private int dotCount = 0;
        private string baseText;

        public Timing(Label label, string text = "Yükleniyor")
        {
            targetLabel = label;
            baseText = text;

            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            dotCount = (dotCount + 1) % 5;
            targetLabel.Text = baseText + new string('.', dotCount);
        }

        public void Start()
        {
            dotCount = 0;
            timer.Start();
        }

        public void Stop(string doneMessage = "Tamamlandı!")
        {
            timer.Stop();
            targetLabel.Text = doneMessage;
        }

        public void SetText(string newText)
        {
            baseText = newText;
        }

        // Daha genel, panel'e yükleme yapıp animasyonu yönetir
        public async Task LoadControlAsync<T>(Panel panel, Func<T> loadFunc, string loadingText = "Yükleniyor", string doneMessage = "Yükleme tamamlandı!") where T : Control
        {
            baseText = loadingText;
            Start();

            T control = await Task.Run(loadFunc);

            if (panel.InvokeRequired)
            {
                panel.Invoke(new Action(() =>
                {
                    panel.Controls.Clear();
                    panel.Controls.Add(control);
                }));
            }
            else
            {
                panel.Controls.Clear();
                panel.Controls.Add(control);
            }

            Stop(doneMessage);
        }

        // İşte kolay kullanım için fonksiyon
        public Task LoadToPanelAsync<T>(Panel panel, Func<T> loadFunc) where T : Control
        {
            return LoadControlAsync(panel, loadFunc);
        }
    }
}
