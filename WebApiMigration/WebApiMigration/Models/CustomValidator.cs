using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiMigration.Models
{
	public class CustomValidator : ValidationAttribute
	{
		MigrationContext db = new MigrationContext();
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			
			if(validationContext.DisplayName == "Nome") 
			{ 
			    if (db.Proprietarios.FirstOrDefault(p => p.Nome == value.ToString()) != null)
			    return new ValidationResult("Usuario já existe em nossa cadastrado no sistema!");
			}
			if (validationContext.DisplayName == "DataDeNascimento") 
			{
				DateTime valueData = Convert.ToDateTime(value);
				if (DateTime.Now.Year < 18 || DateTime.Now.Year - valueData.Year > 150)
				{
					return new ValidationResult("Idade incorreta");
				}
			}
				return ValidationResult.Success;
		}
	}
}