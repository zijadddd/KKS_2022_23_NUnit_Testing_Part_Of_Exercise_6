﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3 {
    public class Calculator {
        public int CalculateSum(int[] numbers) {
            int sum = 0; 
            foreach (int number in numbers) {  sum += number; }
            return sum;
        }
    }
}
