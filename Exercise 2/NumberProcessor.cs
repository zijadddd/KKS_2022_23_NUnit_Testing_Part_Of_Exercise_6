using System.Runtime.ExceptionServices;

namespace Exercise_2 {
    public class NumberProcessor {
        public float GetAverage(int[] numbers) {
            if (numbers.Length == 0) throw new ArgumentException("Array is empty.");
            int averageNum = 0;
            for(int i = 0; i < numbers.Length; i++) averageNum += numbers[i];
            return averageNum/numbers.Length;
        }

        public bool IsPrime(int n) {
            if (n <= 1) return false;
            for (int i = 2; i <= n/2; i++) if (n%i == 0) return false; 
            return true;
        }

        public int GetLargest(int[] numbers) {
            if (numbers.Length == 0) throw new ArgumentException("Array is empty");
            int indexOfMax = 0;
            for (int i = 1; i < numbers.Length; i++) if (numbers[indexOfMax] < numbers[i]) indexOfMax = i;
            return numbers[indexOfMax];
        }
    }
}
