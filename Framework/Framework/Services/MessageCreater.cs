using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Model;

namespace Framework.Services
{
    class MessageCreater
    {
        public static Message WithAllProperties()
        {
            return new Message(TestDataReader.GetData("Topic"), TestDataReader.GetData("Email"), TestDataReader.GetData("PNumber"), TestDataReader.GetData("MessageText")); // fields "Тема", "E-mail","Номер","Сообщение"
        }
        public static Message WithoutAllProperties()
        {
            return new Message("", "", " ", ""); // fields "Тема", "E-mail","Номер","Сообщение"
        }
    }
}
