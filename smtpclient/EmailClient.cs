using System;

namespace smtpclient
{
    public class EmailClient
    {
        private string server = "";
        private int port = 0;



        public int Send(string fromAddress, string [] toAddresses, string [] ccAddresses, string [] bccAddresses, string subject, string body, string [] attachments, string [] attachmentNames)
        {
            int success = 1;
            return success;
        }

        public void SetPort(int port)
        {
            this.port = port;
        }

        public void SetServer(string server)
        {
            this.server = server;
        }
    }
}
