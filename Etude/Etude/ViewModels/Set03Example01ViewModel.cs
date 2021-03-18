using System;
using System.Security.Cryptography;
using System.Windows.Input;
using Xamarin.Forms;

namespace Etude.ViewModels
{
    public class Set03Example01ViewModel : BaseViewModel
    {
        public string Result
        {
            get => _result;
            set => SetProperty(ref _result, value);
        }

        #region Backing Property Fields
        private string _result = string.Empty;
        #endregion

        #region Delegate Commands
        public ICommand GenerateSaltCommand { get; }
        public ICommand GenerateRealRandomNumberCommand { get; }
        public ICommand GenerateRandomPasswordCommand { get; }
        #endregion

        public Set03Example01ViewModel()
        {
            GenerateSaltCommand = new Command(ExecuteGenerateSaltCommand);
            GenerateRealRandomNumberCommand = new Command(ExecuteGenerateRealRandomNumberCommand);
            GenerateRandomPasswordCommand = new Command(ExecuteGenerateRandomPasswordCommand);
        }

        private void ExecuteGenerateSaltCommand()
        {
            Result = CreateSalt(20);
        }

        private void ExecuteGenerateRealRandomNumberCommand()
        {
            Result = Math.Abs(CreateRandom()).ToString();
        }

        private void ExecuteGenerateRandomPasswordCommand()
        {
            Result = CreateRandomPassword(15);
        }

        // Generate o real random string
        private string CreateSalt(int size)
        {
            var rng = RandomNumberGenerator.Create();
            var buff = new byte[size];

            rng.GetBytes(buff);

            return Convert.ToBase64String(buff);
        }

        // Generate o real random number
        public int CreateRandom()
        {
            var rng = RandomNumberGenerator.Create();
            var buff = new byte[4];

            rng.GetBytes(buff);

            return BitConverter.ToInt32(buff, 0);
        }

        // Create a random password
        private string CreateRandomPassword(int passwordLength)
        {
            var allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789!@$?_-";
            var chars = new char[passwordLength];
            var rd = new Random();

            for (int i = 0; i < passwordLength; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new string(chars);
        }
    }
}
