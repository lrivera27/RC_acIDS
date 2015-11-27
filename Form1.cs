using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReleaseACIDS
{
    public partial class MainMenu_form : Form
    {
        /*Constructor*/

        public MainMenu_form()
        {
            InitializeComponent();
        }

        /*Class Variables*/

        //Enums to make panel Switching more readable
        public enum Panel { HIDS, NIDS, ABOUT, MAINMENU}

        /*Buttons*/

        //Hids Button, starting point of all PC monitoring
        private void hids_btn_Click(object sender, EventArgs e)
        {
            changePanel(Panel.HIDS);
        }

        //NIDS Button, starting point of all snort monitoring
        private void nids_btn_Click(object sender, EventArgs e)
        {
            changePanel(Panel.NIDS);
        }

        /*Class Methods*/

        //Switches between panels
        private void changePanel(Panel panel)
        {
            //Making sure every panel is not visible
            main_Panel.Visible = false;
            hids_Panel.Visible = false;
            nids_Panel.Visible = false;
            
            switch (panel)
            {
                case Panel.HIDS:
                    hids_Panel.Visible = true;
                    Text = "HIDS Menu";
                    break;

                case Panel.NIDS:
                    nids_Panel.Visible = true;
                    Text = "NIDS Menu";
                    break;

                case Panel.ABOUT:
                    //about_panel.Visible - true;
                    //Text = "About";
                    break;

                case Panel.MAINMENU:
                    main_Panel.Visible = true;
                    Text = "Main Menu";
                    break;
            }
        }
    }
}
