using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoggerService loggerService = new DatabaseLoggerService();

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            List<ILoggerService> loggerServices = new List<ILoggerService> { new SmsLoggerService(), new DatabaseLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, loggerServices);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
