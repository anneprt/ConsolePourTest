using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPanier.Entites
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
					throw new Exception("Prix doit être > 0");

				prix = value;

			}
		}

		public void Valider()
		{
			if (Prix <= 0)
				throw new Exception("Prix doit être > 0");

			if (string.IsNullOrWhiteSpace(Nom))
				throw new Exception("Nom est requis");
		}
	}
}
