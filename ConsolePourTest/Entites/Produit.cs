using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePourTest.Entites
{
	public class Produit
	{
		private decimal prix;
		public int Id { get; set; }

		public string Nom { get; set; }

		public decimal Prix
		{
			get { return this.prix; }

			set
			{
				if (value <= 0)
					throw new Exception("Le prix ne peut pas être négatif");

				prix = value;

			}
		}

		public void Valider()
		{
			if (Prix <= 0)
				throw new Exception("Le prix ne peut pas être négatif");

			if (string.IsNullOrEmpty(Nom))
				throw new Exception("Le nom est requis");
		}
	}
}
