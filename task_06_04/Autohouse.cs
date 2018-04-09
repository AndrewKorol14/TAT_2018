using System.Collections;

namespace task_06_04
{
    class Autohouse: IEnumerable
    {
        Car[] cars;
        string enumerator;

        public string Enumerator
        {
            set
            {
                enumerator = value;
            }
        }

        public Autohouse(Car[] carsList)
        {
            cars = new Car[carsList.Length];
            for(int i = 0; i < carsList.Length; i++)
            {
                cars[i] = carsList[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            if(enumerator == "1")
            {
                return new UniqueModelsEnumenator(cars);
            }
            else if (enumerator == "2")
            {
                return new CompanyEnumerator(cars);
            }
            else
            {
                return new CarEnumerator(cars);
            }            
        }
    }
}