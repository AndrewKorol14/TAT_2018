using System.Collections;

namespace task_06_04
{
    class CompanyEnumerator: IEnumerator
    {
        Car[] enumCars;
        int carPosition = -1;

        public CompanyEnumerator(Car[] carArray)
        {
            enumCars = carArray;
        }

        public bool MoveNext()
        {
            carPosition++;
            return (carPosition < enumCars.Length);
        }

        public void Reset()
        {
            carPosition = -1;
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public string Current
        {
            get { return enumCars[carPosition].company; }
        }
    }
}