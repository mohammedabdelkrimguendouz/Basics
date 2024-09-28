using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Threading;


namespace Serial_Key_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = Color.GreenYellow;
        }
        private void button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.SteelBlue;
        }

        public enum enCharType
        {
            SmallLetter = 1, CapitalLetter = 2, Digit = 3, MixChars = 4, SmallAndCapitalLetter = 5,
            SmallLetterAndDigigt = 6, CapitalLetterAndDigit = 7
        };

        enum enModeListKeys { Show,Hide}

        enModeListKeys ModeListKeys = enModeListKeys.Hide;

        stInfoGenerateKeys InfoGenerateKeys;
        public struct stInfoGenerateKeys
        {
            public enCharType CharType;
            public int SerialCount;
            public int CharPerSection;
            public int NumberOfSection;
            public string SepartoreSction;
        }

        private void SetInfoGenerateKeys()
        {
            InfoGenerateKeys.CharPerSection = (int)nudCharsPerSection.Value;
            InfoGenerateKeys.SepartoreSction = txtSeperatoreKey.Text;
            InfoGenerateKeys.NumberOfSection = (int)nudSection.Value;
            InfoGenerateKeys.SerialCount = (int)nudSerialCount.Value;
            InfoGenerateKeys.CharType = GetCharTypeKey();
        }

        private bool IsCheckBoxCheked()
        {
            if (chkLowerCase.Checked || chkNumber.Checked || chkUpperCase.Checked)
                return true;
            return false;
        }
        
        private void ClearListKeys()
        {
            listView1.Items.Clear();
            lblNumberSerial.Text = "0";
            btnClearListKeys.Enabled = false;
            listView1.Enabled = false;
        }
        private void AddKeyToList(string Key)
        {
            ListViewItem Item = new ListViewItem();
            Item.ImageIndex = 0;
            Item.SubItems.Add(Key);
            Item.Tag = Key;
            listView1.Items.Add(Item);
            
        }
        private char GetRandomCharacter()
        {
            enCharType CharType = InfoGenerateKeys.CharType;
            int seed;
            Random random;
            using (System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
            {
                byte[] buffer = new byte[4];
                rng.GetBytes(buffer);
                seed = BitConverter.ToInt32(buffer, 0);
                random = new Random(seed);
            }


            if (CharType == enCharType.MixChars)
            {
                CharType = (enCharType)random.Next(1,4);
            }
            else if(CharType == enCharType.SmallAndCapitalLetter)
            {
                CharType = (enCharType)random.Next(1, 3);
            }
            else if (CharType == enCharType.CapitalLetterAndDigit)
            {
                CharType = (enCharType)random.Next(2, 4);
            }
            else if (CharType == enCharType.SmallLetterAndDigigt)
            {
                int[] RandArray= new int[2] { 1, 3 };
                CharType = (enCharType)RandArray[random.Next(2)];
            }

            
            switch (CharType)
            {
                case enCharType.SmallLetter:
                    {
                        return (char)random.Next(97, 123);
                        
                    }
                case enCharType.CapitalLetter:
                    {
                        
                        return (char)random.Next(65, 91);
                        
                        
                    }
                case enCharType.Digit:
                    {
                        return (char)random.Next(48, 57);
                        
                    }       
            }
            return '0';
        }

        private enCharType GetCharTypeKey()
        {
            if (chkLowerCase.Checked && chkNumber.Checked && chkUpperCase.Checked)
                return enCharType.MixChars;
            if(chkLowerCase.Checked && chkNumber.Checked)
                return enCharType.SmallLetterAndDigigt;
            if (chkLowerCase.Checked && chkUpperCase.Checked)
                return enCharType.SmallAndCapitalLetter;
            if (chkUpperCase.Checked && chkNumber.Checked)
                return enCharType.CapitalLetterAndDigit;
            if(chkNumber.Checked)
                return enCharType.Digit;
            if (chkLowerCase.Checked)
                return enCharType.SmallLetter;
            return enCharType.CapitalLetter;
        }
           
        private void ShowAndHideList()
        {
            if (ModeListKeys == enModeListKeys.Hide)
            {
                this.Height = 591;
                listView1.Visible = true;
                btnShowListKeys.Text = "Hide List Keys";
                ModeListKeys = enModeListKeys.Show;
            }
            else
            {
                listView1.Visible = false;
                btnShowListKeys.Text = "Show List Keys";
                ModeListKeys = enModeListKeys.Hide;
                this.Height = 200;
            }
        }

        private string GenerateWord()
        {
            string Word = "";
            for (short i = 1; i <= InfoGenerateKeys.CharPerSection; i++)
            {
                
                Word += GetRandomCharacter();
            }
            return Word;
        }
        private void GenerateKey()
        {
            string Key = "";
            for(int i=1;i<InfoGenerateKeys.NumberOfSection;i++)
            {
                Key += GenerateWord() + " " + InfoGenerateKeys.SepartoreSction + " ";
            }
            Key += GenerateWord();
            AddKeyToList(Key);
        }
        private void GenerateKeys()
        {
            for (short i = 1; i <= InfoGenerateKeys.SerialCount; i++)
            {
                GenerateKey();   
            }
        }

        private void Add()
        {
            if (IsCheckBoxCheked())
            {
                SetInfoGenerateKeys();

                if (listView1.Items.Count + InfoGenerateKeys.SerialCount > 50)
                {
                    MessageBox.Show("Max Number Of Keys Is 50 ! ", "Werning",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                    if (MessageBox.Show("Do You Want clear List Keys . ", "Clear",
                           MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) == DialogResult.OK)
                    {
                        if (MessageBox.Show("Are You Sure ? . ", "Confirm",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                        {
                            ClearListKeys();
                        }
                    }

                    return;
                }

                GenerateKeys();
                lblNumberSerial.Text = (Convert.ToUInt32(lblNumberSerial.Text) + InfoGenerateKeys.SerialCount).ToString();
                btnClearListKeys.Enabled = true;
                listView1.Enabled = true;
            }
            else
                MessageBox.Show("Please select character set! ", "Character set error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        private void Generate()
        {
            if (IsCheckBoxCheked())
            {
                ClearListKeys();
                btnClearListKeys.Enabled = true;
                listView1.Enabled = true;
                SetInfoGenerateKeys();
                lblNumberSerial.Text = InfoGenerateKeys.SerialCount.ToString();
                GenerateKeys();
            }
            else
                MessageBox.Show("Please select character set! ", "Character set error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Generate();
        }
        private void btnAddSerialKeys_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnShowListKeys_Click(object sender, EventArgs e)
        {
            
            ShowAndHideList();
        }

        private void btnClearListKeys_Click(object sender, EventArgs e)
        {
            ClearListKeys();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                Clipboard.SetText(listView1.SelectedItems[0].Tag.ToString());
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
             nudSerialCount.Value = 1;
             Add();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                lblNumberSerial.Text = (Convert.ToInt32(lblNumberSerial.Text) - 1).ToString();
            }
                 
        }
    }
}
