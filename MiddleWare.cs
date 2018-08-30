using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class MiddleWare
    {
        private String connectionString = "Server=localhost;Uid=root;Pwd=password;Database=shopperdatabase";
        public int login(String email, String password)
        {
            using (MySqlConnection conn = new MySqlConnection())
            {
                String query;

                query = String.Format("SELECT email, password FROM customer_login WHERE email=\'{0}\'", email);


                conn.ConnectionString = connectionString;
                conn.Open();

                MySqlCommand command = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (String.Equals(password, reader[1].ToString()))
                                return 1;
                            else
                                return 0;
                        }
                    }
                    else
                    {
                        return -1;

                    }

                }
            }
            return -2;
        }
        public int sign_up(String name, String email, String password, String phone)
        {
            using (MySqlConnection conn = new MySqlConnection())
            {
                String query;

                query = String.Format("INSERT INTO customer_profile (name, email, phone_no,password) VALUES (\'{0}\', \'{1}\', \'{2}\',\'{3}\')", name, email, phone, password);


                conn.ConnectionString = connectionString;
                conn.Open();

                MySqlCommand command = new MySqlCommand(query, conn);

                try
                {
                    int rows_affected = command.ExecuteNonQuery();
                    if (rows_affected == 1)
                    {
                        String query2;

                        query2 = String.Format("INSERT INTO customer_login (email, password) VALUES (\'{0}\', \'{1}\')", email, password);

                        MySqlCommand command2 = new MySqlCommand(query2, conn);
                        try
                        {
                            int rows_affected2 = command2.ExecuteNonQuery();
                            if (rows_affected2 == 1)
                                return 1;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("User details inserted, but some error occured !");
                            return -1;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("User details could not be inserted !");
                    return 0;
                }
            }
            return -1;                                    // Error in connection
        }
        public String get_name(String email)
        {
            using (MySqlConnection conn = new MySqlConnection())
            {
                String query;

                query = String.Format("SELECT name FROM customer_profile WHERE email=\'{0}\'", email);


                conn.ConnectionString = connectionString;
                conn.Open();

                MySqlCommand command = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                        while (reader.Read())
                            return reader[0].ToString();
                }
            }
            return "";                          // Error in connection
        }

        public void add1(String prod, int price,int quantity)
        {
            using (MySqlConnection conn = new MySqlConnection())
            {
                String query;


                query = String.Format("INSERT INTO cart (product, price,quantity) VALUES (\'{0}\', \'{1}\',\'{2}\')", prod, price,quantity);


                conn.ConnectionString = connectionString;
                conn.Open();

                MySqlCommand command = new MySqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
        }

        public int click_1(String product1)
        {
            using (MySqlConnection conn = new MySqlConnection())
            {
                String query, query1;
                query = String.Format("SELECT click FROM clicks WHERE product=\'{0}\'", product1);
                String temp = "";
                int count = 0;


                conn.ConnectionString = connectionString;
                conn.Open();

                MySqlCommand command = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                        while (reader.Read())
                            temp = reader[0].ToString();
                    count = int.Parse(temp);
                }
                count += 1;
                query1 = String.Format("UPDATE clicks SET click=\'{0}\' where product=\'{1}\'", count, product1);
                MySqlCommand command1 = new MySqlCommand(query1, conn);
                command1.ExecuteNonQuery();

                return 1;
            }
        }
        public void empty_cart()
        {
            using (MySqlConnection conn = new MySqlConnection())
            {
                String query, query1;
                query = String.Format("truncate cart");
                conn.ConnectionString = connectionString;
                conn.Open();

                MySqlCommand command = new MySqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
        }

        public String display_cart()
        {
            using (MySqlConnection conn = new MySqlConnection())
            {
                String query = "SELECT product, price FROM cart";
                String result = "<div class=\"w3-container w3-margin\">";
                int total=0;
                conn.ConnectionString = connectionString;
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            String temp = "<div class=\"w3-card-4\" style=\"width:50%\">";
                            temp += "<div class=\"w3-container w3-center\">" +
                                        "<h3> {0} </h3>" +
                                        "<div class=\"w3-section\">" +
                                            "<h5> Price: {1} </h5>" +
                                        "</div>" +
                                    "</div>" +
                                "</div>" +
                                "<br />";
                            result += String.Format(temp, reader[0], reader[1]);
                            total = total + int.Parse(reader[1].ToString());
                        }
                        result += String.Format("<div style=\"font-size:200%\">The total bill is <b> Rs {0} </b></div>", total);

                    }
                    return result + "</div>";
                }




            }
        }
        public String most_clicks()
        {
            using (MySqlConnection conn = new MySqlConnection())
            {
                String query = "SELECT product,click from clicks order by click desc";
                String result = "<div class=\"w3-container w3-margin\">";
                conn.ConnectionString = connectionString;
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            String temp = "<div class=\"w3-card-4\" style=\"width:50%\">";
                            temp += "<div class=\"w3-container w3-center\">" +
                                        "<h3> {0} </h3>" +
                                        "<div class=\"w3-section\">" +
                                            "<h5> Number of times it was viewed: {1} </h5>" +
                                        "</div>" +
                                    "</div>" +
                                "</div>" +
                                "<br />";
                            result += String.Format(temp, reader[0], reader[1]);
                        }

                    }
                    return result + "</div>";
                }
            }
        }
    }
}

