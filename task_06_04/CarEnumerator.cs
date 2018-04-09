using System.Collections;

namespace task_06_04
{
    class CarEnumerator: IEnumerator
    {
        Car[] enumCars;
        int carPosition = -1;

        public CarEnumerator(Car[] carArray)
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

        public Car Current
        {
            get { return enumCars[carPosition]; }
        }
    }
}