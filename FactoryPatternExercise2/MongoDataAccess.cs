﻿using System;

namespace FactoryPatternExercise2
{
	public class MongoDataAccess : IDataAccess
	{
		public MongoDataAccess()
		{
		}

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from MongoDB.");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a Mongo database.");
        }
    }
}

