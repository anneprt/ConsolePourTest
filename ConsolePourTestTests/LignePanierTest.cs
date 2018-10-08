using System;
using GestionPanier;
using GestionPanier.Entites;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GestionPanierTests
{
	[TestClass]
	public class LignePanierTest
	{
		[TestMethod]
		public void ValiderQuantitePositive()
		{
			var lignePanier = new LignePanier
			{
				Produit = new Produit(),
				Quantite = -1

			};

			var exception = Assert.ThrowsException<Exception>(() => lignePanier.Valider());
			Assert.AreEqual("Quantité doit être positive", exception.Message);
		}

		[TestMethod]
		public void ValiderProduitRenseigne()
		{
			var lignePanier = new LignePanier
			{
				Produit = null,
				Quantite = 1

			};

			var exception = Assert.ThrowsException<Exception>(() => lignePanier.Valider());
			Assert.AreEqual("Produit est requis", exception.Message);
		}
	}
}
