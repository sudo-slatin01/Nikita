using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public abstract class AbstractSalaryFactrory
    {
        public abstract Deposit Create();
    }
    public class Monthly_deposit : AbstractSalaryFactrory
    {
        public override Deposit Create()
        {
            return new Universal_Bank();
        }
    }
    public class Quarterly_deposit : AbstractSalaryFactrory
    {
        public override Deposit Create()
        {
            return new Industrialbank();
        }
    }
    public class Deposit_for_a_year : AbstractSalaryFactrory
    {
        public override Deposit Create()
        {
            return new Accordbank();
        }
    }
    public  class Deposit
    {
        public string Name { get; set; }
        public double Your_deposit;
        public  double Monthly_deposit() {
            if (Your_deposit <= 100000 && Your_deposit != 1000)
            {
                return Your_deposit + (Your_deposit * (0.055) / 12);

            }
            else if (Your_deposit <= 1000)
            {
                return Your_deposit + (Your_deposit * (0.065) / 12);

            }
            else if (Your_deposit <= 100000)
            {
                return Your_deposit + (Your_deposit * (0.0175) / 12);

            }
            else
            {
                return Convert.ToDouble (MessageBox.Show("Ваш депозит превышает 100000 гривен!"));
            }
        }
        public double Quarterly_deposit()
        {
            if (Your_deposit <= 100000 && Your_deposit != 1000)
            {
                return Your_deposit + (Your_deposit * (0.055) / 4);

            }
            else if (Your_deposit <= 1000)
            {
                return Your_deposit + (Your_deposit * (0.065) / 4);

            }
            else if (Your_deposit <= 100000)
            {
                return Your_deposit + (Your_deposit * (0.0175) / 4);

            }
            else
            {
                return Convert.ToDouble(false);
            }
        }
        public double Deposit_for_a_year()
        {
            if (Your_deposit <= 100000 && Your_deposit != 1000)
            {
                return Your_deposit + (Your_deposit * (0.055) );

            }
            else if (Your_deposit <= 1000)
            {
                return Your_deposit + (Your_deposit * (0.065));

            }
            else if (Your_deposit <= 100000)
            {
                return Your_deposit + (Your_deposit * (0.0175));

            }
            else
            {
                return Convert.ToDouble(false);
            }
        }
    }
    public class Universal_Bank : Deposit
    {
        public Universal_Bank()
        {
            Name = "Вы обратились в Универсал Банк за депозитом Мега гибкий счет";
        }
    }
    public class Industrialbank : Deposit
    {
        public Industrialbank()
        {
            Name = "Вы обратились в Индустриалбанк за депозитом Доходный";

        }
    }
    public class Accordbank : Deposit
    {
        public Accordbank()
        {
            Name = "Вы обратились в Аккордбанк за депозитом Максимальный доход";

        }
    }
    public class Result
    {
        private Deposit abstractSalary;
        public Result(AbstractSalaryFactrory factory)
        {
            abstractSalary = factory.Create();
        }
        public double Monthly_deposit(double some)
        {
            abstractSalary.Your_deposit = some;
            return abstractSalary.Monthly_deposit();

        }
        public double Quarterly_deposit(double some)
        {
            abstractSalary.Your_deposit = some;
            return abstractSalary.Quarterly_deposit();

        }
        public double Deposit_for_a_year(double some)
        {
            abstractSalary.Your_deposit = some;
            return abstractSalary.Deposit_for_a_year();

        }
    }
}
