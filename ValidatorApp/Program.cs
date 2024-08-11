using FluentValidation.Results;
using System.Dynamic;
using ValidatorApp.Models;
using ValidatorApp.Models.Enums;
using ValidatorApp.Models.Validators;

namespace PrimeiroPrograma
{
    class program
    {
        static void Main(string[] args)
        {
            User user = new User();
            UserValidator validator = new UserValidator();

            Console.WriteLine("digite o nome do usuário");
            user.Name = string.Format(Console.ReadLine());

            Console.WriteLine("cadastre a permissão desse usuário: Admin(0) / Normal(1)");
            user.UserPermission = Enum.Parse<UserPermission>(Console.ReadLine());

            ValidationResult result = validator.Validate(user);

            if (result.IsValid)
            {
                Console.WriteLine(user.Name + "\n" + user.UserPermission);
            }
            else
            {
                Console.WriteLine(result.ToString());
            }
        }
    }
}

