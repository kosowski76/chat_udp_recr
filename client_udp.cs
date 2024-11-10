private void button1_Click(object sender, EventArgs e)
{
    string host = textBox1.Text;
    int port = (int) numericUpDown1.Value;

    try
    {
        UdpClient client = new UdpClient(host, port);

        Byte[] data = Encoding.ASCII.GetBytes(textBox2.Text);
        client.Send(data, data.Length);

        listBox1.Items.Add("Sending a message to the host. " + host + ":" + port);

        client.Close();
    }
    catch(Exception ex)
    {
        listBox1.Items.Add("Error! failed to send message.");
        MessageBox.Show.ToString(). "Error!"
    }


}