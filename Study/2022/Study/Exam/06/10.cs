﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.29
 * 내용 : 피보나치 연습문제
 */

namespace Exam._06
{
    internal class _06_10
    {
        class User
        {
            private string uid;
            private string name;
            private string hp;
            private int age;

            public string Uid { get => uid; set => uid = value; }
            public string Name { get => name; set => name = value; }
            public string Hp { get => hp; set => hp = value; }
            public int Age { get => age; set => age = value; }
        }

        class DataManager
        {
            // const 때문에 static이 초기값 선언 되어서 클래스 변수가 된다.
            private const string SERVER = "127.0.0.1";
            private const string PORT = "3306";
            private const string USERNAME = "root";
            private const string PASSWORD = "1234";
            private const string DATABASE = "userdb";
            private const string TABLE = "user2";

            private static DataManager instance = new DataManager();

            public static DataManager Instance { get => instance; }
            
            private DataManager() { }

            public MySqlConnection Connect()
            {
                string strConn = $"server={SERVER};" 
                                + $"port={PORT};"
                                + $"username={USERNAME};"
                                + $"password={PASSWORD};"
                                + $"database={DATABASE};";

                MySqlConnection conn = new MySqlConnection(strConn);
                return conn;
            }

            public int InsertUser()
            {
                Console.Write("아이디 : ");
                string uid = Console.ReadLine();

                Console.Write("이름 : ");
                string name = Console.ReadLine();

                Console.Write("휴대폰 : ");
                string hp = Console.ReadLine();

                Console.Write("나이 : ");
                int age = int.Parse(Console.ReadLine());

                MySqlConnection conn = null;
                int count = 0;

                try
                {
                    conn = Connect();
                    conn.Open();

                    MySqlCommand cmd = conn.CreateCommand();

                    cmd.CommandText = $"INSERT INTO `{TABLE}` " +
                                       $"VALUES ('{uid}', '{name}', '{hp}', '{age}')";

                    count = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    conn.Close();
                }
                return count;
            }

            public User SelectUser()
            {
                Console.Write("이름 검색 : ");
                string name = Console.ReadLine();

                User user = null;
                MySqlConnection conn = null;

                try
                {
                    conn = Connect();
                    conn.Open();

                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = $"SELECT * FROM `{TABLE}` WHERE `name`='{name}'";
                    
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        user = new User();
                        user.Uid = reader[0].ToString();
                        user.Name = reader[1].ToString();
                        user.Hp = reader[2].ToString();
                        user.Age = int.Parse(reader[3].ToString());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    conn.Close();
                }

                return user;
            }

            public List<User> SelectUserAll()
            {
                List<User> users = new List<User>();
                MySqlConnection conn = null;

                try
                {
                    conn = Connect();
                    conn.Open();

                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = $"SELECT * FROM `{TABLE}`";
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        User user = new User();
                        user.Uid = reader[0].ToString();
                        user.Name = reader[1].ToString();
                        user.Hp = reader[2].ToString();
                        user.Age = int.Parse(reader[3].ToString());

                        users.Add(user);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    conn.Close();
                }

                return users;
            }

            public int DeleteUser()
            {
                Console.Write("이름 삭제 : ");
                string name = Console.ReadLine();

                MySqlConnection conn = null;
                int count = 0;

                try
                {
                    conn = Connect();
                    conn.Open();

                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = $"DELETE FROM `{TABLE}` WHERE `name`='{name}'";
                    count = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    conn.Close();
                }

                return count;
            }
        }
        static void Main10(string[] args)
        {
            Console.WriteLine("***************************");
            Console.WriteLine("데이터 매니저 프로그램 v2.0");
            Console.WriteLine("***************************");

            DataManager dm = DataManager.Instance;

            while (true)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("종료 : 0, 입력 : 1, 전체조회 : 2, 이름 조회 : 3, 삭제 : 4");
                Console.Write("선택 : ");

                int answer = int.Parse(Console.ReadLine());

                if (answer == 0)
                {
                    break;
                }
                else if (answer == 1)
                {
                    int count = dm.InsertUser();

                    if (count > 0)
                    {
                        Console.WriteLine("입력 완료!");
                    }
                }
                else if (answer == 2)
                {
                    List<User> users = dm.SelectUserAll();

                    Console.WriteLine("-----------------------전체 결과-----------------------");

                    foreach (User user in users)
                    {
                        Console.WriteLine($"{user.Uid}, {user.Name}, {user.Hp}, {user.Age}");
                    }
                }
                else if (answer == 3)
                {
                    User user = dm.SelectUser();

                    if (user != null)
                    {
                        Console.WriteLine("-----------------------검색 결과-----------------------");

                        Console.WriteLine($"{user.Uid}, {user.Name}, {user.Hp}, {user.Age}");
                    }
                    else
                    {
                        Console.WriteLine("존재하지 않는 이름입니다.");
                    }
                }
                else if (answer == 4)
                {
                    int count = dm.DeleteUser();
                    if (count > 0)
                    {
                        Console.WriteLine($"{count}건 삭제 완료!");
                    }
                    else
                    {
                        Console.WriteLine($"존재하지 않는 이름입니다.");
                    }
                }
            }
            Console.WriteLine("프로그램 종료...");


        }

    }
}
