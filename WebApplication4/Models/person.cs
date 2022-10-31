namespace WebApplication4.Models
{
    public class person
    {


        public string userName;
        public string password;

        public List<string> usernames = new List<string> { "john", "pascal", "daniel" };
        public List<string> password_list = new List<string> { "123", "123", "123" };
        public List<decimal> acc_bal = new List<decimal> { 20000, 40000, 30000 };

        public person(string username, string pword)
        {
            this.userName = username;
            this.password = pword;

        }

      
        public string login2()
        {
            int Index = usernames.IndexOf(userName);
            Console.WriteLine(Index);
            string message;

            if (Index == -1)
            {
                message = "does not exist";
                return message;

            }
            else
            {
                string pwd = password_list[Index];

               

                if (pwd == password)
                {
                    message = $"hello welcome   {userName}";
                    return message;





                }
                else
                {
                    
                    message = "password does not exist";
                    return message;
                }
            }
        }

    }
}
