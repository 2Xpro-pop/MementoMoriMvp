namespace MementoMoriMvp.Services
{
    public class AccountImitatorService
    {
        private const string director = "director";
        private const string directorPassword = "access5";

        private const string manager = "manager";
        private const string managerPassword = "access4";

        private const string doctor = "doctor";
        private const string doctorPassword = "access3";

        public bool IsDirector { get; private set; } = false;
        public bool IsManager { get; private set; } = false;
        public bool IsDoctor { get; private set; } = false;
        public bool IsSigned { get; private set; } = false;

        public bool SignIn(string login, string password)
        {
            if(doctor == login && doctorPassword == password)
            {
                IsDoctor = true;
                IsSigned = true;
                return true;
            }
            if (manager == login && managerPassword == password)
            {
                IsManager = true;
                IsSigned = true;
                return true;
            }
            if (director == login && directorPassword == password)
            {
                IsDirector = true;
                IsSigned = true;
                return true;
            }
            return false;
        }

        public void Logout() 
        {
            IsDirector = false;
            IsDoctor = false;
            IsManager = false;
            IsSigned = false;
        }
    }
}
