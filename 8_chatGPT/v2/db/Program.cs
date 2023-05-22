using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace FormularzKonsolowy
{
    class Program
    {
        static string connectionString = "server=localhost;user=root;database=MojaBazaDanych;password=;";

        static string WprowadzMiasto()
        {
            string query = "SELECT Nazwa FROM Miasta;";
            List<string> listaMiast = new List<string>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nazwaMiasta = reader.GetString("Nazwa");
                            listaMiast.Add(nazwaMiasta);
                        }
                    }
                }
            }

            Console.WriteLine("Dostępne miasta:");
            for (int i = 0; i < listaMiast.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {listaMiast[i]}");
            }

            int wybraneMiastoIndex = -1;
            while (wybraneMiastoIndex < 0 || wybraneMiastoIndex >= listaMiast.Count)
            {
                Console.Write("Wybierz numer miasta: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out wybraneMiastoIndex))
                {
                    wybraneMiastoIndex--; // Zmniejszamy o 1, ponieważ wyświetlaliśmy indeksowanie od 1 dla użytkownika
                }
                else
                {
                    wybraneMiastoIndex = -1;
                    Console.WriteLine("Nieprawidłowy numer miasta. Spróbuj ponownie.");
                }
            }

            return listaMiast[wybraneMiastoIndex];
        }


        static bool WalidujMiasto(string miasto)
        {
            string query = "SELECT COUNT(*) FROM Miasta WHERE Nazwa = @NazwaMiasta;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NazwaMiasta", miasto);

                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count == 0)
                    {
                        Console.WriteLine("Podane miasto nie jest dostępne. Wybierz miasto z listy.");
                        return false;
                    }
                }
            }

            return true;
        }

        static int PobierzMiastoID(string nazwaMiasta)
        {
            string query = "SELECT ID FROM Miasta WHERE Nazwa = @NazwaMiasta;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NazwaMiasta", nazwaMiasta);

                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        Console.WriteLine("Podane miasto nie istnieje. Sprawdź poprawność wprowadzonych danych.");
                        return -1; // Wartość -1 może oznaczać błąd lub brak zgodności miasta w bazie danych
                    }
                }
            }
        }

        static void ZapiszDaneDoBazy(string imie, string nazwisko, int wiek, string miasto)
        {
            //Console.WriteLine("Dodawanie danych\r\ndo bazy...\");
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Sprawdź, czy miasto już istnieje w tabeli Miasta
                int miastoID = -1;
                string query = "SELECT ID FROM Miasta WHERE Nazwa = @miasto";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@miasto", miasto);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            miastoID = reader.GetInt32("ID");
                        }
                    }
                }

                // Jeśli miasto nie istnieje, dodaj je do tabeli Miasta
                if (miastoID == -1)
                {
                    query = "INSERT INTO Miasta (Nazwa) VALUES (@miasto)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@miasto", miasto);
                        command.ExecuteNonQuery();
                    }

                    // Pobierz ID dodanego miasta
                    query = "SELECT LAST_INSERT_ID()";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        miastoID = Convert.ToInt32(command.ExecuteScalar());
                    }
                }

                // Dodaj dane osobowe do tabeli DaneOsobowe
                query = "INSERT INTO DaneOsobowe (Imie, Nazwisko, Wiek, MiastoID) VALUES (@imie, @nazwisko, @wiek, @miastoID)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@imie", imie);
                    command.Parameters.AddWithValue("@nazwisko", nazwisko);
                    command.Parameters.AddWithValue("@wiek", wiek);
                    command.Parameters.AddWithValue("@miastoID", miastoID);
                    command.ExecuteNonQuery();
                }

                Console.WriteLine("Dane dodane do bazy!");

                connection.Close();
            }
        }

        static void UtworzTabeleMiasta()
        {
            string query = "CREATE TABLE IF NOT EXISTS Miasta (ID INT AUTO_INCREMENT PRIMARY KEY, Nazwa VARCHAR(100) NOT NULL);";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        static void Main(string[] args)
        {
            UtworzTabeleMiasta();

            Console.WriteLine("Wprowadź dane osobowe:");
            Console.Write("Imię: ");
            string imie = Console.ReadLine();

            Console.Write("Nazwisko: ");
            string nazwisko = Console.ReadLine();

            Console.Write("Wiek: ");
            int wiek = int.Parse(Console.ReadLine());

            string miasto = WprowadzMiasto();

            ZapiszDaneDoBazy(imie, nazwisko, wiek, miasto);

            Console.WriteLine("Dane zapisane do bazy!");

            Console.ReadLine();
        }
    }
}
