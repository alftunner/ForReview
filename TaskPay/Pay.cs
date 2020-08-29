using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace TaskPay
{
    class Pay
    {
        public double payForDay { set; get; } //Оплата за день
        public int dayCount { set; get; } // количество дней
        public double fineForDay { set; get; } // штраф за просрочку 1 дня
        public int dayFine { set; get; } // количество дней с просрочкой
        public double payWithoutFine { set; get; } // Итого без штрафов
        public double fine { set; get; } // Общая сумма штрафа
        public double totalPay { set; get; } // итого к оплате
        public static bool flag = false;

        public Pay()
        {
            
        }

        public Pay(double payForDay, int dayCount, double fineForDay, int dayFine)
        {
            this.payForDay = payForDay;
            this.dayCount = dayCount;
            this.fineForDay = fineForDay;
            this.dayFine = dayFine;
            payWithoutFine = this.payForDay * this.dayCount;
            fine = this.fineForDay * this.dayFine;
            totalPay = payWithoutFine + fine;
        }
        
    }
}
