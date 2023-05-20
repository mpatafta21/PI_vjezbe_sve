﻿using DBLayer;
using PI_vjezbe_sve.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_vjezbe_sve.Repositories
{
    public class StudentRepository
    {
        public static Student GetStudent(int id)
        {
            Student student = null;
            string sql = $"SELECT * FROM Students WHERE Id = {id}";
            DBLayer.DB.OpenConnection();
            var reader = DBLayer.DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                student = CreateObject(reader);
                reader.Close();
            }
            DBLayer.DB.CloseConnection();
            return student;
        }
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            string sql = "SELECT * FROM Students";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Student student = CreateObject(reader);
                students.Add(student);
            }
            reader.Close();
            DB.CloseConnection();
            return students;
        }
        private static Student CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            int.TryParse(reader["Grade"].ToString(), out int grade);
            var student = new Student
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Grade = grade
            };
            return student;
        }


    }
}