using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.Properties;
using System.Globalization;
using System.Collections;

namespace UserControls
{
    public partial class ucsChooseLocation : UserControl
    {
        public ucsChooseLocation()
        {
            InitializeComponent();
        }
        public List<Button> buttons { get; set; }
        public List<MapsData> Maps { get; set; }
        public void BitmapNButtonsInit()
        {

            buttons = new List<Button>();



            buttons.Add(btnSeoul);
            buttons.Add(btnBusan);
            buttons.Add(btnIncheon);
            buttons.Add(btnDaegu);
            buttons.Add(btnGwangju);
            buttons.Add(btnDaejeon);
            buttons.Add(btnUlsan);
            buttons.Add(btnSejong);
            buttons.Add(btnGyeonggi);
            buttons.Add(btnGangwon);
            buttons.Add(btnChungbuk);
            buttons.Add(btnChungnam);
            buttons.Add(btnGyeongbuk);
            buttons.Add(btnGyeongnam);
            buttons.Add(btnJeonbuk);
            buttons.Add(btnJeonnam);
            buttons.Add(btnJeju);
        }

        private void UcsChooseLocation_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                BitmapNButtonsInit();
                buttons.ForEach(x => x.MouseEnter += OnMouseEnter);
                buttons.ForEach(x => x.MouseLeave += OnMouseLeave);
                buttons.ForEach(x => x.Click += OnButtonClick);

                pictureBox.Image = Resources.전국지도;
                Maps = Resources.ResourceManager
                           .GetResourceSet(CultureInfo.CurrentCulture, true, true)
                           .Cast<DictionaryEntry>()
                           .Where(x => x.Value.GetType() == typeof(Bitmap))
                           .Select(x => new MapsData
                           {
                               Name = x.Key.ToString(),
                               Image = (Bitmap)x.Value
                           })
                           .ToList();
            }
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;

            foreach (var map in Maps)
            {
                if (map.Name == button.Text)
                    pictureBox.Image = map.Image;
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            pictureBox.Image = Resources.전국지도;
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;

            foreach (var x in buttons)
            {
                if (button.Text == x.Text)
                {
                    //CitySelect form = new CitySelect(x.Text);
                    //form.ShowDialog();
                }
            }
        }
    }
}
