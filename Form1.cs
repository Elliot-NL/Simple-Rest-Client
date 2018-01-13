using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_File___WinFormsREST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Makes HTTP web request, gets stream of data and reads data
            //input: http://dry-cliffs-19849.herokuapp.com/users.json
            //debugOutput("This is testing the output");

            RestClient rClient = new RestClient();
            rClient.endPoint = txtUrl.Text;
            debugOutput("Rest Client created");
            string strResponse = string.Empty;
            strResponse = rClient.makeRequest();
            debugOutput(strResponse);

        }

        private void debugOutput(string strDebugTest)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugTest + Environment.NewLine);
                textResponse.Text = textResponse + strDebugTest + Environment.NewLine;
                textResponse.SelectionStart = textResponse.TextLength;
                textResponse.ScrollToCaret();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
    }
}
