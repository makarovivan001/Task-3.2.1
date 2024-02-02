using System;
namespace HomeWork_Makarov_Ivan_number_3._1
{
	public abstract class BaseArray
	{
		protected BaseArray(bool personGet)
		{
			Create(personGet);
		}

		protected abstract void GetfromPerson();
		protected abstract void GetfromRandom();
        public abstract void Print();
		public abstract void Create(bool personGet);
        public abstract decimal GetAverage();
    }
}

