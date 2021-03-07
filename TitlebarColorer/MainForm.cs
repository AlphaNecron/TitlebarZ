using System;
using System.Drawing;
using System.Windows.Forms;
using TitlebarColorer.Utils;

namespace TitlebarColorer
{
    public partial class MainForm : Form
    {
        private Color _color = Color.White;

        public MainForm()
        {
            InitializeComponent();
            InitializeEvent();
        }

        private void Apply()
        {
            var color = Convert.ToInt32(BGR.FromColor(_color).ToHex(), 16);
            RegUtils.SetColorPrevalence(true);
            if (cbOption1.Checked) RegUtils.SetTitlebarColor(color);
            if (cbOption2.Checked) RegUtils.SetInactiveTitlebarColor(color);
            MessageBox.Show($"New titlebar color has been set!\nNew color: {color:X6}");
        }

        private void InitializeEvent()
        {
            trbRed.ValueChanged += (i, _) => OnColorChanged(i);
            trbGreen.ValueChanged += (i, _) => OnColorChanged(i);
            trbBlue.ValueChanged += (i, _) => OnColorChanged(i);
            btnApply.Click += (_, _) => Apply();
        }

        private void OnColorChanged(object i)
        {
            var sender = i as TrackBar;
            if (i == null)
            {
                trbRed.Value = _color.R;
                trbGreen.Value = _color.G;
                trbBlue.Value = _color.B;
                lbRed.Text = $@"R: {trbRed.Value}";
                lbGreen.Text = $@"G: {trbGreen.Value}";
                lbBlue.Text = $@"B: {trbBlue.Value}"; 
                return;
            }
            switch (sender?.Name) 
            { 
                case "trbRed": 
                    lbRed.Text = $@"R: {sender.Value}"; 
                    break;
                case "trbGreen":
                    lbGreen.Text = $@"G: {sender.Value}";
                    break;
                case "trbBlue":
                    lbBlue.Text = $@"B: {sender.Value}";
                    break;
            }
            _color = Color.FromArgb(255, trbRed.Value, trbGreen.Value, trbBlue.Value);
            colorPreview.BackColor = _color;
        }
    }

}