private void button1_Click(object sender, EventArgs.e)
{
    int port = (int) numericUpDown1.Value;
    IPEndPoint remoteIP = new IPEndPoint(IPAddress.Any, 0);

    try
    {
        UdpClient sever = new UdpClient(port);

        Byte[] reading = sever.Receive(ref remoteIP);
        string data = Encoding.ASCII.GetBytes(textBox2.Text);

        listBox1.Items.Add(data);

        server.Close();        
    }
    catch(Exception.ex)
    {
        MessageBox.Show(ex.Message, "Error!");
    }
}