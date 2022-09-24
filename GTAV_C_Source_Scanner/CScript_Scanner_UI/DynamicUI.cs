using System.Collections.Generic;
using System.Windows.Forms;

namespace NHA_CScriptScannerUI{
    public partial class DynamicUI : Form{
        private Form HOMEFORM;
        public static Dictionary<string, DynamicUI> Instances = new Dictionary<string, DynamicUI>();

        public DynamicUI(Form Form){
            InitializeComponent();
            var KEY = Form.Name;
            var OG_KEY = KEY;
            var KEY_ID = 1;
            while (Instances.ContainsKey(KEY))
                KEY = OG_KEY+"_"+(KEY_ID= KEY_ID+1).ToString();
            Instances.Add(Form.Name, this);
            HOMEFORM = Form;
            HomeButton.Click += (X, E) => SwitchToUI(HOMEFORM);
            SwitchToUI(HOMEFORM);
            Icon = HOMEFORM.Icon;
            Font = HOMEFORM.Font;
            BackColor = HOMEFORM.BackColor;
            ForeColor = HOMEFORM.ForeColor;
        }

        private List<Form> SubForms = new List<Form>();
        private Form CURRENTFORM = null;
        public void SwitchToUI(Form Form) {
            Controls.Clear();
            if (!SubForms.Contains(Form)){
                SubForms.Add(Form);
                Form.TextChanged += (X, E) => {
                    if (CURRENTFORM != null ? CURRENTFORM == Form : false)
                        Text = Form.Text;
                };    
            }
            CURRENTFORM=Form;
            Form.TopLevel = false;
            Form.Dock = DockStyle.Fill;
            Form.FormBorderStyle = FormBorderStyle.None;
            Form.WindowState = FormWindowState.Normal;
            Text =   Form.Text;
            MinimumSize = Form.MinimumSize;
            Form.Show();
            Controls.Add(Form);
            if(Form!=HOMEFORM){
            Controls.Add(PageOptions);
            PageOptions.SendToBack();
            }
            Form.BringToFront();
        }

    }
}
