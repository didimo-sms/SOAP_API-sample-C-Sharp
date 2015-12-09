using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SOAP_API
{
    public partial class SoapClient
    {
        sms.didimo.es.wcfServiceClient api;
        String userName;
        String password;

        public SoapClient()
        {
            // Initialize client
            this.api = new sms.didimo.es.wcfServiceClient();

            // User Data
            this.userName = "email@domain.com";
            this.password = "password";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public sms.didimo.es.PingResult Ping()
        {
            // Request Data
            sms.didimo.es.PingRequest request = new sms.didimo.es.PingRequest { UserName = this.userName, Password = this.password };

            // Execute
            return this.api.Ping(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public sms.didimo.es.GetMessageIdResult GetMessageId()
        {
            // Request Data
            sms.didimo.es.GetMessageIdRequest request = new sms.didimo.es.GetMessageIdRequest { UserName = this.userName, Password = this.password };

            // Execute
            return this.api.GetMessageId(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public sms.didimo.es.CreateSendResult CreateSend()
        {
            // Schedule Data
            String name = String.Format("Test SOAP API - C# Client - {0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")); //Optional
            String scheduleDate = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"); //Optional
            String sender = "didimo"; //Optional
            Collection<sms.didimo.es.MessageSend> messages = new Collection<sms.didimo.es.MessageSend>(); // Required

            // Messages Data
            String id; //Optional
            String mobile; //Required
            String text; //Required
            Boolean isUnicode; //Optional - Values: 'true' or 'false'. Default value: 'false'

            // SMS 1 - GSM7
            id = Guid.NewGuid().ToString();
            mobile = "+34653695688";
            text = String.Format("Test SOAP API sms.didimo.es, by C# client {0} - {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), id);
            isUnicode = false;

            messages.Add(new sms.didimo.es.MessageSend
            {
                Id = id,
                IsUnicode = isUnicode.ToString(),
                Mobile = mobile,
                Text = text
            });

            // SMS 2 - Unicode
            id = Guid.NewGuid().ToString();
            mobile = "+34653695842";
            text = String.Format("測試 SOAP API sms.didimo.es ，由C#客戶端 {0} - {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), id);
            isUnicode = true;

            messages.Add(new sms.didimo.es.MessageSend
            {
                Id = id,
                IsUnicode = isUnicode.ToString(),
                Mobile = mobile,
                Text = text
            });

            // Request Data
            sms.didimo.es.CreateSendRequest request = new sms.didimo.es.CreateSendRequest { 
                UserName = this.userName,
                Password = this.password,
                Messages = messages.ToArray(),
                Name = name,
                ScheduleDate = scheduleDate,
                Sender = sender
            };

            // Execute
            return this.api.CreateSend(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public sms.didimo.es.CreateMessageResult CreateMessage()
        {
            // SMS Data
            String name = String.Format("Test Web API - C# Client - {0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")); //Optional
            String scheduleDate = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"); //Optional
            String sender = "didimo"; //Optional
            String id = Guid.NewGuid().ToString(); //Optional
            String mobile = "+34653695688"; //Required
            String text = String.Format("Test SOAP API sms.didimo.es, by C# client {0} - {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), id); //Required
            Boolean isUnicode = false; //Optional - Values: 'true' or 'false'. Default value: 'false'

            // Request Data
            sms.didimo.es.CreateMessageRequest request = new sms.didimo.es.CreateMessageRequest { 
                UserName = this.userName,
                Password = this.password,
                Id = id,
                IsUnicode = isUnicode.ToString(),
                Mobile = mobile,
                Name = name,
                ScheduleDate = scheduleDate,
                Sender = sender,
                Text = text
            };

            // Execute
            return this.api.CreateMessage(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public sms.didimo.es.GetMessageStatusResult GetMessageStatus()
        {
            String id = "f82da5e5-0336-46a9-8b2d-3709054ac339"; //Required

            // Request Data
            sms.didimo.es.GetMessageStatusRequest request = new sms.didimo.es.GetMessageStatusRequest { 
                UserName = this.userName,
                Password = this.password,
                Id = id,
            };

            // Execute
            return this.api.GetMessageStatus(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public sms.didimo.es.GetCreditsResult GetCredits()
        { 
            // Request Data
            sms.didimo.es.GetCreditsRequest request = new sms.didimo.es.GetCreditsRequest { 
                UserName = this.userName,
                Password = this.password
            };

            // Execute
            return this.api.GetCredits(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public sms.didimo.es.CreateSendResult CreateCertifiedSend()
        {
            // Schedule Data
            String name = String.Format("Test SOAP API SMS Certified - C# Client - {0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")); //Optional
            String scheduleDate = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"); //Optional
            String sender = "didimo"; //Optional
            Collection<sms.didimo.es.MessageSend> messages = new Collection<sms.didimo.es.MessageSend>(); // Required

            // Messages Data
            String id; //Optional
            String mobile; //Required
            String text; //Required
            Boolean isUnicode; //Optional - Values: 'true' or 'false'. Default value: 'false'

            // SMS 1 - GSM7
            id = Guid.NewGuid().ToString();
            mobile = "+34653695688";
            text = String.Format("Test SOAP API SMS Certified sms.didimo.es, by C# client {0} - {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), id);
            isUnicode = false;

            messages.Add(new sms.didimo.es.MessageSend
            {
                Id = id,
                IsUnicode = isUnicode.ToString(),
                Mobile = mobile,
                Text = text
            });

            // SMS 2 - Unicode
            id = Guid.NewGuid().ToString();
            mobile = "+34653695842";
            text = String.Format("測試 SOAP API SMS Certified sms.didimo.es ，由C#客戶端 {0} - {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), id);
            isUnicode = true;

            messages.Add(new sms.didimo.es.MessageSend
            {
                Id = id,
                IsUnicode = isUnicode.ToString(),
                Mobile = mobile,
                Text = text
            });

            // Request Data
            sms.didimo.es.CreateSendRequest request = new sms.didimo.es.CreateSendRequest
            {
                UserName = this.userName,
                Password = this.password,
                Messages = messages.ToArray(),
                Name = name,
                ScheduleDate = scheduleDate,
                Sender = sender
            };

            // Execute
            return this.api.CreateCertifiedSend(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public sms.didimo.es.CreateMessageResult CreateCertifiedMessage()
        {
            // SMS Data
            String name = String.Format("Test Web API SMS Certified - C# Client - {0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")); //Optional
            String scheduleDate = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"); //Optional
            String sender = "didimo"; //Optional
            String id = Guid.NewGuid().ToString(); //Optional
            //String mobile = "+34653695688"; //Required
            String mobile = "+34639927746"; //Required
            String text = String.Format("Test SOAP API SMS Certified sms.didimo.es, by C# client {0} - {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), id); //Required
            Boolean isUnicode = false; //Optional - Values: 'true' or 'false'. Default value: 'false'

            // Request Data
            sms.didimo.es.CreateMessageRequest request = new sms.didimo.es.CreateMessageRequest
            {
                UserName = this.userName,
                Password = this.password,
                Id = id,
                IsUnicode = isUnicode.ToString(),
                Mobile = mobile,
                Name = name,
                ScheduleDate = scheduleDate,
                Sender = sender,
                Text = text
            };

            // Execute
            return this.api.CreateCertifiedMessage(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public String GetCertifyFile()
        {
            String result = String.Empty;

            String id = "85c9f279-4245-4aaa-b394-af826b021d0c";

            // Request Data
            sms.didimo.es.GetCertifyFileRequest request = new sms.didimo.es.GetCertifyFileRequest { 
                UserName = this.userName,
                Password = this.password,
                Id = id
            };

            // Execute 
            System.IO.Stream certifyStream = this.api.GetCertifyFile(request);

            String fileName = String.Format("message_{0}.pdf", id);
            String fileDirectory = @"C:\SMSCertifies\sms.didimo\";

            using (System.IO.FileStream fs = new System.IO.FileStream(System.IO.Path.Combine(fileDirectory, fileName), System.IO.FileMode.OpenOrCreate))
            {
                certifyStream.CopyTo(fs);
            }

            result = String.Format("File saved on {0}", System.IO.Path.Combine(fileDirectory, fileName));

            return result;
        }
    }   
}
