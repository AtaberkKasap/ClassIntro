using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // Method Injection
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerService)
        {
            // Başvuran bilgilerini değerlendirme
            //
            krediManager.Hesapla();
            foreach (var logger in loggerService)
            {
                logger.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
