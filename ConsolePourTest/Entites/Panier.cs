using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPanier.Entites
{
	public class Panier
	{
		public Panier()
		{
			Lignes = new List<LignePanier>();
		}

		public List<LignePanier> Lignes { get; set; }

		public decimal FraisPort{ get; set; } = 10;

		public decimal GetTotal()
		{
			if (!Lignes.Any())
			{
				return 0;
			}
			var totalLignes = Lignes.Sum(x => x.Produit.Prix * x.Quantite);
			var fraisPort = totalLignes > 100 ? 0 : 10;
			return totalLignes + FraisPort;
		}

		public void Valider()
		{
			foreach (var ligne in Lignes)
			{
				ligne.Valider();
			}
		}
	}
}
