using NModbus;
using NModbus.Device;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Modbus_String
{
    public partial class Form1 : Form
    {
        // Variabili classe
        private List<Label> registerLabels;
        private List<TextBox> registerValues;

        public Form1()
        {
            InitializeComponent();

            // Aggiungo le varie labels
            registerLabels = new List<Label>();
            registerLabels.Add(lblReg1);
            registerLabels.Add(lblReg2);
            registerLabels.Add(lblReg3);
            registerLabels.Add(lblReg4);
            registerLabels.Add(lblReg5);
            registerLabels.Add(lblReg6);
            registerLabels.Add(lblReg7);
            registerLabels.Add(lblReg8);
            registerLabels.Add(lblReg9);
            registerLabels.Add(lblReg10);
            registerLabels.Add(lblReg11);
            registerLabels.Add(lblReg12);
            registerLabels.Add(lblReg13);
            registerLabels.Add(lblReg14);
            registerLabels.Add(lblReg15);
            registerLabels.Add(lblReg16);

            // Aggiungo i valori
            registerValues = new List<TextBox>();
            registerValues.Add(txtReg1);
            registerValues.Add(txtReg2);
            registerValues.Add(txtReg3);
            registerValues.Add(txtReg4);
            registerValues.Add(txtReg5);
            registerValues.Add(txtReg6);
            registerValues.Add(txtReg7);
            registerValues.Add(txtReg8);
            registerValues.Add(txtReg9);
            registerValues.Add(txtReg10);
            registerValues.Add(txtReg11);
            registerValues.Add(txtReg12);
            registerValues.Add(txtReg13);
            registerValues.Add(txtReg14);
            registerValues.Add(txtReg15);
            registerValues.Add(txtReg16);

            // Imposto le impostazioni di default
            txtIpAddress.Text = Properties.Settings.Default.LastIPAddress;
            txtPort.Text = Properties.Settings.Default.Port;
            txtSlaveID.Text = Properties.Settings.Default.SlaveID;
            txtFirstRegister.Text = Properties.Settings.Default.FirstRegister;
        }

        // Metodo per leggere le variabili Modbus e trasformarle in stringa
        private void btnReadFromModbus_Click(object sender, EventArgs e)
        {
            // Cambio il cursore in clessidra
            Cursor.Current = Cursors.WaitCursor;

            // Valido la stringa inserita
            string ipAddress = txtIpAddress.Text;
            String pattern = @"\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";
            if (!Regex.IsMatch(ipAddress, pattern))
            {
                MessageBox.Show("Ci sono errori nel campo Indirizzo IP, riprova.", "Input non valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIpAddress.SelectAll();
                Cursor.Current = Cursors.Default;
                return;
            }

            // Ottengo le informazion inserite
            int port = int.Parse(txtPort.Text);
            byte slaveID = byte.Parse(txtSlaveID.Text);
            ushort startAddress = ushort.Parse(txtFirstRegister.Text);

            // Correggo il primo registro Modbus
            if (startAddress >= 40001)
            {
                startAddress -= 40001;
            }
            else if (startAddress > 49999)
            {
                startAddress = 9966;
            }
            else
            {
                startAddress -= 1;
            }

            // Creo un client Modbus TCP
            TcpClient client = new TcpClient();
            try
            {
                client = new TcpClient(ipAddress, port);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante la connessione. " + ex.ToString(), "Errore di connessione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor.Current = Cursors.Default;
                Console.WriteLine(ex.ToString());
                return;
            }
            IModbusMaster master = new ModbusFactory().CreateMaster(client);
            master.Transport.ReadTimeout = 500;

            // Leggo 16 holding registers (32 char) a partire dallo startAddress
            try
            {
                int index = 0;
                string message = "";
                ushort[] registers = master.ReadHoldingRegisters(slaveID, startAddress, 16);
                foreach (ushort pezzo in registers)
                {
                    // Aggiorno le info a video
                    registerLabels[index].Text = (startAddress + index + 40001).ToString();
                    registerValues[index].Text = pezzo.ToString();

                    // Converto da DEC a HEX e quindi in stringa
                    string hexValue = pezzo.ToString("X");
                    string hex1 = convertHex(string.Join("", hexValue.Take(2)));
                    string hex2 = convertHex(string.Join("", hexValue.Skip(2)));
                    message += hex1;
                    message += hex2;
                    index++;
                }
                txtString.Text = message;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante la lettura dei registri Modbus. " + ex.ToString(), "Errore di lettura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Chiudo la connessione col client
                client.Close();
            }

            // Salvo i valori appena usati come default
            Properties.Settings.Default.LastIPAddress = txtIpAddress.Text;
            Properties.Settings.Default.Port = txtPort.Text;
            Properties.Settings.Default.SlaveID = txtSlaveID.Text;
            Properties.Settings.Default.FirstRegister = txtFirstRegister.Text;
            Properties.Settings.Default.Save();

            // Ripristino il cursore
            Cursor.Current = Cursors.Default;
        }

        private void btnWriteToModbus_Click(object sender, EventArgs e)
        {
            // Cambio il cursore in clessidra
            Cursor.Current = Cursors.WaitCursor;

            // Valido la stringa inserita
            string ipAddress = txtIpAddress.Text;
            String pattern = @"\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";
            if (!Regex.IsMatch(ipAddress, pattern))
            {
                MessageBox.Show("Ci sono errori nel campo Indirizzo IP, riprova.", "Input non valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIpAddress.SelectAll();
                Cursor.Current = Cursors.Default;
                return;
            }

            // Ottengo le informazion inserite
            int port = int.Parse(txtPort.Text);
            byte slaveID = byte.Parse(txtSlaveID.Text);
            ushort startAddress = ushort.Parse(txtFirstRegister.Text);

            // Correggo il primo registro Modbus
            if (startAddress >= 40001)
            {
                startAddress -= 40001;
            }
            else if (startAddress > 49999)
            {
                startAddress = 9966;
            }
            else
            {
                startAddress -= 1;
            }

            // Creo un client Modbus TCP
            TcpClient client = new TcpClient();
            try
            {
                client = new TcpClient(ipAddress, port);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante la connessione. " + ex.ToString(), "Errore di connessione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor.Current = Cursors.Default;
                Console.WriteLine(ex.ToString());
                return;
            }
            IModbusMaster master = new ModbusFactory().CreateMaster(client);
            master.Transport.ReadTimeout = 500;

            // Divido la stringa ogni due caratteri
            List<String> chunks = new List<String>();
            for (int i = 0; i < txtString.Text.Length; i += 2)
            {
                if (i + 2 <= txtString.Text.Length)
                {
                    chunks.Add(txtString.Text.Substring(i, 2));
                }
                else
                {
                    chunks.Add(txtString.Text.Substring(i));
                }
            }

            // Scrivo 16 registri (32 char) a partire dallo startAddress
            try
            {
                int index = 0;
                // Itero tutti i pezzi di stringa
                foreach (String chunk in chunks)
                {
                    string hex1 = ((int)chunk[0]).ToString("X2");
                    string hex2 = "0";
                    if (chunk.Length > 1)
                    {
                        hex2 = ((int)chunk[1]).ToString("X2");
                    }
                    string temphex = hex1 + hex2;
                    int value = Convert.ToInt32(temphex, 16);
                    registerLabels[index].Text = (startAddress + index + 40001).ToString();
                    registerValues[index].Text = value.ToString();
                    ushort currentIndex = (ushort)index;
                    master.WriteSingleRegister(slaveID, Convert.ToUInt16(startAddress + currentIndex), Convert.ToUInt16(value));
                    index++;
                }

                // Se non ho scritto tutti i 16 registri riempio quelli rimanenti con 0
                while (index < 16)
                {
                    registerLabels[index].Text = (startAddress + index + 40001).ToString();
                    registerValues[index].Text = "0";
                    ushort currentIndex = (ushort)index;
                    master.WriteSingleRegister(slaveID, Convert.ToUInt16(startAddress + currentIndex), Convert.ToUInt16(0));
                    index++;
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Errore durante la scrittura dei registri Modbus. " + ex.ToString(), "Errore di scrittura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Chiudo la connessione col client
                client.Close();
            }

            // Salvo i valori appena usati come default
            Properties.Settings.Default.LastIPAddress = txtIpAddress.Text;
            Properties.Settings.Default.Port = txtPort.Text;
            Properties.Settings.Default.SlaveID = txtSlaveID.Text;
            Properties.Settings.Default.FirstRegister = txtFirstRegister.Text;
            Properties.Settings.Default.Save();

            // Ripristino il cursore
            Cursor.Current = Cursors.Default;
        }

        // Metodo per convertire un hex in stringa (carattere)
        public static string convertHex(String hexString)
        {
            try
            {
                string ascii = string.Empty;

                for (int i = 0; i < hexString.Length; i += 2)
                {
                    String hs = string.Empty;

                    hs = hexString.Substring(i, 2);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    char character = System.Convert.ToChar(decval);
                    ascii += character;

                }

                return ascii;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return string.Empty;
        }

        private void txtFirstRegister_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSlaveID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}