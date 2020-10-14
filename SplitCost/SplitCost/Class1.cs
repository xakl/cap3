using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitCost
{
    public class Calc
    {
        double addTax;
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Calc()
        {

        }
        /// <summary>
        /// 一人あたりの金額を計算するクラス
        /// </summary>
        /// <param name="money">入力された金額</param>
        /// <param name="person">入力された人数</param>
        /// <returns></returns>
        public double OnePersonMoney(double money,int person) 
        {
            const double tax = 0.08;

            addTax = money * (1 + tax);
            double onePesonAddTax = addTax / person;

            return onePesonAddTax;
        }
        /// <summary>
        /// 余りを計算するクラス
        /// </summary>
        /// <param name="person">入力された人数</param>
        /// <returns></returns>
        public double Remainder(int person)
        {
            double remainder = addTax % person;
            return remainder;
        }

    }
}
