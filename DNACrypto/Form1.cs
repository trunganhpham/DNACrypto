using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNACrypto
{
    public partial class Form1 : Form
    {
        enum CryptoType
        {
            DNA,
            RNA
        };

        DNACryptoLIB.CryptoLIB cryptoLIB;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            if (radDNA.Checked)
            {               
                SwitchCryptoLIBType(CryptoType.DNA);
            }
            else
            {                
                SwitchCryptoLIBType(CryptoType.RNA);
            }        
            string encryptedText = cryptoLIB.GetEncryptedText(txtWords.Text);
            txtDNAEncrypt.Text = encryptedText;
        }

        private void btnSearchString_Click(object sender, EventArgs e)
        {
            try
            {
                SwitchCryptoLIBType(CryptoType.DNA);
                int result = cryptoLIB.IsEncryptedTextContainsString(txtSourceDNAText.Text, txtSearchASCII.Text);
                txtSearchIndex.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGetASCIIFromStrand_Click(object sender, EventArgs e)
        {
            SwitchCryptoLIBType(CryptoType.DNA);
            try
            {
                string result = cryptoLIB.GetASCIIFromComplemetaryEncodedText(txtComplemenraryStrand.Text);
                txtASCIIResult.Text = result;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SwitchCryptoLIBType(CryptoType type)
        {
            if(type == CryptoType.DNA)
            {
                if(cryptoLIB == null)
                {
                    cryptoLIB = new DNACryptoLIB.DNACrypto();
                }
                else if (cryptoLIB.GetType() == typeof(DNACryptoLIB.DNACrypto))
                {
                    return;
                }
                else
                {
                    cryptoLIB = new DNACryptoLIB.DNACrypto();
                }
            }
            else
            {
                if (cryptoLIB == null)
                {
                    cryptoLIB = new DNACryptoLIB.RNACrypto();
                }
                else if (cryptoLIB.GetType() == typeof(DNACryptoLIB.RNACrypto))
                {
                    return;
                }
                else
                {
                    cryptoLIB = new DNACryptoLIB.RNACrypto();
                }
            }            
        }

        private void btnGetLCS_Click(object sender, EventArgs e)
        {
            SwitchCryptoLIBType(CryptoType.DNA);
            try
            {
                string result = cryptoLIB.FindLongestCommonSubSequence(txtStrand1.Text, txtStrand2.Text);
                txtLCSResult.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
