using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace socketUDP
{
    public partial class Form1 : Form
    {
        private Socket udpSocket;
        private IPEndPoint ipEndPointLocal;
        private IPEndPoint ipEndPointDest;
        private EndPoint ipEndPointFrom;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Communication par socket UDP";
        }

        private void creatstoket_Click(object sender, EventArgs e)
        {
            try
            {
                udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                IPAddress ipLocal = IPAddress.Parse(textBox1.Text); // IP réception
                int portLocal = int.Parse(textBox2.Text);       // Port réception
                ipEndPointLocal = new IPEndPoint(ipLocal, portLocal);

                udpSocket.Bind(ipEndPointLocal);

                MessageBox.Show("Socket UDP créé et lié avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la création du socket : " + ex.Message);
            }
        }

        private void envoyer_Click(object sender, EventArgs e)
        {
            try
            {
                string message = envoi.Text;
                byte[] msg = Encoding.ASCII.GetBytes(message);

                IPAddress ipDest = IPAddress.Parse(textBox4.Text); // IP destination
                int portDest = int.Parse(textBox3.Text);           // Port destination
                ipEndPointDest = new IPEndPoint(ipDest, portDest);

                udpSocket.SendTo(msg, ipEndPointDest);

                MessageBox.Show("Message envoyé !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'envoi : " + ex.Message);
            }
        }

        private void Recevoir_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer = new byte[1024];
                ipEndPointFrom = new IPEndPoint(IPAddress.Any, 0);

                int received = udpSocket.ReceiveFrom(buffer, ref ipEndPointFrom);
                string receivedMessage = Encoding.ASCII.GetString(buffer, 0, received);

                Recp.Text += "Reçu : " + receivedMessage + Environment.NewLine;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la réception : " + ex.Message);
            }
        }

        private void CLS_Click(object sender, EventArgs e)
        {
            if (udpSocket != null)
            {
                udpSocket.Close();
                MessageBox.Show("Socket fermé.");
            }
        }

        private void fermerclose_Click(object sender, EventArgs e)
        {
            if (udpSocket != null)
            {
                udpSocket.Close();
            }
            Close();
        }

        // Événements inutilisés
        private void Form1_Load(object sender, EventArgs e) { }
        private void Form1_Load_1(object sender, EventArgs e) { }
        private void label4_Click_1(object sender, EventArgs e) { }
        private void label5_Click_1(object sender, EventArgs e) { }
        private void label6_Click_1(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void envoi_TextChanged(object sender, EventArgs e) { }
        private void Recp_TextChanged(object sender, EventArgs e) { }
    }
}
