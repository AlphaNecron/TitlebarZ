using System;
using System.Drawing;
using System.Windows.Forms;
using TitlebarZ.Utils;

namespace TitlebarZ
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
            MessageBox.Show(
                $"New titlebar color has been applied!\nNew color: #{BGR.StripAlpha(BGR.FromColor(_color).ToRGBHex()):X6}");
        }

        private void InitializeEvent()
        {
            trbRed.ValueChanged += (i, _) => OnColorChanged((TrackBar) i);
            trbGreen.ValueChanged += (i, _) => OnColorChanged((TrackBar) i);
            trbBlue.ValueChanged += (i, _) => OnColorChanged((TrackBar) i);
            btnApply.Click += (_, _) => Apply();
            btnReset.Click += (_, _) =>
            {
                RegUtils.ResetCustomization();
                MessageBox.Show(@"Titlebar color has been reset!");
            };
        }

        private void OnColorChanged(TrackBar i)
        {
            switch (i.Name)
            {
                case "trbRed":
                    lbRed.Text = $@"R: {i.Value}";
                    break;
                case "trbGreen":
                    lbGreen.Text = $@"G: {i.Value}";
                    break;
                case "trbBlue":
                    lbBlue.Text = $@"B: {i.Value}";
                    break;
            }

            _color = Color.FromArgb(trbRed.Value, trbGreen.Value, trbBlue.Value);
            lbColor.ForeColor = _color.GetBrightness() >= 0.5F
                ? Color.Black
                : _color.GetBrightness() <= 0.5F
                    ? Color.White
                    : Color.Gray;
            colorPreview.BackColor = _color;
            lbColor.Text = $@"#{BGR.StripAlpha(BGR.FromColor(_color).ToRGBHex()):X6}";
        }
    }
}