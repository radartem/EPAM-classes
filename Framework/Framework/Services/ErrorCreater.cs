using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Services
{
    class ErrorCreater
    {
        static readonly string invalidEmail = "Неправильный E-mail";
        static readonly string captchaError = "Подтвердите что вы не робот";
        static readonly string emptyEmail = "Поле 'E-mail' должно быть заполнено!";
        static readonly string emptyTopic = "Поле 'Тема' должно быть заполнено!";
        static readonly string emptyMessage = "Поле 'Ваше сообщение' должно быть заполнено!";
        static readonly string startDateLeaseEndDate = "Дата начала аренды позже даты окончания.";
        static readonly string incorrectLoginOrPassword = "Неверный логин или пароль.";
        static readonly string similarStartDateAndEndDate = "Дата начала аренды не может совпадать с датой окончания.";
        static readonly string userWithZeroExp = "Стаж не указан";
        public static string MessageWithInvalidEMail()
        {
            return invalidEmail+"\r\n" + captchaError;
        }
        public static string CorrectLoginAndPassword()
        {
            return "";
        }

        public static string IncorrectLoginOrPassword()
        {
            return incorrectLoginOrPassword;
        }

        public static string MessageWithEmptyFields()
        {
            return emptyEmail + "\r\n" + emptyTopic + "\r\n" + emptyMessage + "\r\n" + captchaError;
        }

        public static string StartDateLeaseEndDate()
        {
            return "×\r\n"+ startDateLeaseEndDate;
        }
        public static string UserWithZeroExp()
        {
            return "×\r\n" + userWithZeroExp;
        }

        public static string SimilarStartDateAndEndDate()
        {
            return "×\r\n" + similarStartDateAndEndDate;
        }
    }
}
