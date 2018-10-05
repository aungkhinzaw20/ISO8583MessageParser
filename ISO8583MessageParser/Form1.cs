using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISO8583MessageParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtMsg.Text = GenerateISOMessage();
        }
        private string GenerateISOMessage()
        {
            string ISOPlainMessage;
            string ISOBitMap;
            string ISOMTI;
            ISOPlainMessage = txtHeader.Text.PadLeft(10,' ') + txtMTI.Text;

            ISOBitMap = "0111111111100000000000000000000000000000000000000000000000000000";
            ISOMTI = txtB2.Text.PadLeft(10, ' ') + txtB3.Text.PadLeft(10, ' ')
                     + txtB4.Text.PadLeft(10, ' ') + txtB5.Text.PadLeft(10, ' ')
                     + txtB6.Text.PadLeft(10, ' ') + txtB7.Text.PadLeft(10, ' ')
                     + txtB8.Text.PadLeft(10, ' ') + txtB9.Text.PadLeft(10, ' ')
                     + txtB10.Text.PadLeft(10, ' ') + txtB11.Text.PadLeft(10, ' ');

            
            //var Plaintextbyte = Encoding.ASCII.GetBytes(ISOPlainMessage);
            byte[] ba = Encoding.Default.GetBytes(ISOMTI);
            ISOMTI =  BitConverter.ToString(ba).Replace("-", "");
            ISOPlainMessage = ISOPlainMessage + ISOBitMap + ISOMTI;
            return ISOPlainMessage;
        }

        private void ParseISOMessage(string IncomeMsg)
        {
            string FBitMap;
            string SBitMap=string.Empty;
            string DElement;
            int DElemetCount = 0;

            //var base64EncodeByte = Convert.FromBase64String(IncomeMsg);
            //IncomeMsg = Encoding.ASCII.GetString(base64EncodeByte);           

            txtMTI.Text = IncomeMsg.Substring(10, 4);
            txtHeader.Text = IncomeMsg.Substring(0, 10);
            FBitMap = IncomeMsg.Substring(14, 64);
            if (FBitMap.Substring(0, 1) == "1")
                SBitMap = IncomeMsg.Substring(78, 64);

            byte[] ba = HexStringToBytes(IncomeMsg.Substring(txtHeader.Text.Length + txtMTI.Text.Length + FBitMap.Length + SBitMap.Length));
            DElement = Encoding.ASCII.GetString(ba);

            for (int i = 1; i < FBitMap.Length; i++)
            {
                if (FBitMap[i] == '1')
                    this.Controls[1].Controls["txtB" + (i + 1)].Text = DElement.Substring(DElemetCount * 10, 10).Trim();
                DElemetCount++;
            }
        }
        public byte[] HexStringToBytes(string hexString)
        {
            if (hexString == null)
                throw new ArgumentNullException("hexString");
            if (hexString.Length % 2 != 0)
                throw new ArgumentException("hexString must have an even length", "hexString");
            var bytes = new byte[hexString.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                string currentHex = hexString.Substring(i * 2, 2);
                bytes[i] = Convert.ToByte(currentHex, 16);
            }
            return bytes;
        }
        private void btnParse_Click(object sender, EventArgs e)
        {
            ParseISOMessage(txtMsg.Text);
        }
    }
   
}
