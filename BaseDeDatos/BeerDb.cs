﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    public class BeerDb:Db
    {
        public BeerDb(string server, string db, string user, string password):
            base(server, db, user, password) 
        { 
        }
        public List<Beer> GetAll()
        {
            Connect();
            List<Beer> beers = new List<Beer>();
            string query = "SELECT Id, Names, BrandId FROM BEER";
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                int brandId = reader.GetInt32(2);
                
                beers.Add(new Beer(id, name,brandId));
            }

            Close();
            return beers;
        }
        public Beer Get(int id)
        {
            Connect ();
            Beer beer = null;
            string query = "SELECT Id, Names, BrandId FROM BEER " +
                "WHERE Id = @id";
            SqlCommand command = new SqlCommand (query, _connection);
            command.Parameters.AddWithValue("id", id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetString(1);
                int brandId = reader.GetInt32(2);
                beer = new Beer(id, name, brandId);
            }
            
            Close();    
            return beer;
        }
        public void Add(Beer beer)
        {
            Connect();
            string query = "INSERT INTO Beer(Names, BrandId)" +
                "VALUES(@names, @brandId)";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@names", beer.Name);
            command.Parameters.AddWithValue("@brandId", beer.BrandId);
            command.ExecuteNonQuery();

            Close();


        }
        public void Edit(Beer beer)
        {
            Connect();
            string query = "UPDATE beer SET names=@names, brandId=@brandId " +
                "WHERE id=@id";
            SqlCommand command= new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@names",beer.Name);
            command.Parameters.AddWithValue("@brandId", beer.BrandId);
            command.Parameters.AddWithValue("@id", beer.Id);
            command.ExecuteNonQuery ();
            Close();
        }
        public void Delete(int id)
        {
            Connect ();
            string query = "DELETE FROM beer WHERE id=@id";
            SqlCommand command = new SqlCommand (query, _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery ();
            Close();
        }
    }
}
