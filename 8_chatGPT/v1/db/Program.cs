using System;
using MySql.Data.MySqlClient;


namespace FormularzKonsolowy
{
    class Program
    {
        static string WprowadzMiasto()
        {
            string miasto;
            do
            {
                Console.Write("Miasto: ");
                miasto = Console.ReadLine();
            } while (!WalidujMiasto(miasto));

            return miasto;
        }

        static bool WalidujMiasto(string miasto)
        {
            // Sprawdź, czy wprowadzone miasto znajduje się na liście miast w bazie danych lub posiada inną walidację według własnych potrzeb
            string connectionString = "server=localhost;user=root;database=MojaBazaDanych;password=;";
            string query = "SELECT COUNT(*) FROM Miasta WHERE Nazwa = @NazwaMiasta";

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


        static void ZapiszDaneDoBazy(string imie, string nazwisko, DateTime dataUrodzenia, string email, string nazwaMiasta)
        {
            string connectionString = "server=localhost;user=root;database=MojaBazaDanych;password=;";
            string query = "INSERT INTO Miasta (Nazwa) VALUES (@NazwaMiasta);" +
                           "INSERT INTO DaneOsobowe (Imie, Nazwisko, DataUrodzenia, Email, MiastoID) " +
                           "VALUES (@Imie, @Nazwisko, @DataUrodzenia, @Email, LAST_INSERT_ID());";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Imie", imie);
                    command.Parameters.AddWithValue("@Nazwisko", nazwisko);
                    command.Parameters.AddWithValue("@DataUrodzenia", dataUrodzenia);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@NazwaMiasta", nazwaMiasta);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }




        static void Main(string[] args)
        {
            Console.WriteLine("Witaj! Proszę uzupełnij formularz.");

            string imie = WprowadzImie();
            string nazwisko = WprowadzNazwisko();
            DateTime dataUrodzenia = WprowadzDateUrodzenia();
            string email = WprowadzEmail();
            string miasto = WprowadzMiasto();

            Console.WriteLine();
            Console.WriteLine("Dziękuję za wypełnienie formularza!");
            Console.WriteLine("Przechwycone dane:");
            Console.WriteLine("Imię: " + imie);
            Console.WriteLine("Nazwisko: " + nazwisko);
            Console.WriteLine("Data urodzenia: " + dataUrodzenia.ToShortDateString());
            Console.WriteLine("Adres email: " + email);
            Console.WriteLine("Miasto: " + miasto);

            // Zapisz dane do bazy danych
            ZapiszDaneDoBazy(imie, nazwisko, dataUrodzenia, email, miasto);

            Console.ReadLine();
        }


        static string WprowadzImie()
        {
            string imie;
            do
            {
                Console.Write("Imię: ");
                imie = Console.ReadLine();
            } while (string.IsNullOrEmpty(imie));

            return imie;
        }

        static string WprowadzNazwisko()
        {
            string nazwisko;
            do
            {
                Console.Write("Nazwisko: ");
                nazwisko = Console.ReadLine();
            } while (string.IsNullOrEmpty(nazwisko));

            return nazwisko;
        }

        static DateTime WprowadzDateUrodzenia()
        {
            DateTime dataUrodzenia;
            string dataUrodzeniaStr;
            bool isValidDate = false;

            do
            {
                Console.Write("Data urodzenia (RRRR-MM-DD): ");
                dataUrodzeniaStr = Console.ReadLine();

                isValidDate = DateTime.TryParse(dataUrodzeniaStr, out dataUrodzenia);

                if (!isValidDate)
                {
                    Console.WriteLine("Nieprawidłowy format daty. Podaj poprawną datę urodzenia.");
                }
            } while (!isValidDate);

            return dataUrodzenia;
        }

        static string WprowadzEmail()
        {
            string email;
            do
            {
                Console.Write("Adres email: ");
                email = Console.ReadLine();
            } while (!WalidujEmail(email));

            return email;
        }

        static bool WalidujEmail(string email)
        {
            // Prosta walidacja adresu email, można zastosować bardziej zaawansowane sprawdzanie
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                Console.WriteLine("Nieprawidłowy adres email. Podaj poprawny adres email.");
                return false;
            }

            return true;
        }
    }
}
