﻿using System;

namespace FactoryPatternExercise2
{
	public class SQLDataAccess : IDataAccess
	{
		public SQLDataAccess()
		{
		}

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from MySQL.");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a SQL database.");
        }
    }
}

