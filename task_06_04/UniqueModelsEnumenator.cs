using System.Collections;
using System.Collections.Generic;

namespace task_06_04
{
    class UniqueModelsEnumenator: IEnumerator
    {
        Car[] enumCars;
        int carPosition = -1;
        List<string> unique = new List<string>();

        public UniqueModelsEnumenator(Car[] carArray)
        {
            enumCars = carArray;
        }

        public bool MoveNext()
        {
            bool isContinue;
            do
            {
                isContinue = false;
                carPosition++;
                if (carPosition == enumCars.Length)
                {
                    return (carPosition != enumCars.Length);
                }
                if (!unique.Contains(enumCars[carPosition].model))
                {
                    unique.Add(enumCars[carPosition].model);
                    break;
                }
                else
                {
                    isContinue = true;
                }
            }
            while (!unique.Contains(enumCars[carPosition].model) || isContinue == true);
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