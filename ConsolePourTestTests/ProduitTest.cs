using System;
using GestionPanier.Entites;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GestionPanierTests
{
	[TestClass]
	public class ProduitTest
	{
		[DataTestMethod]
		[DataRow("0")]
		[DataRow("-10")]
		public void ValiderPrix(string rawPrix)
		{
			var prix = decimal.Parse(rawPrix);
			var exception = Assert.ThrowsException<Exception>(() =>
			{
				var produit = new Produit
				{
					Nom = "Bouteille Bordeaux",
					Prix = prix
				};

			});

			Assert.AreEqual("Prix doit être > 0", exception.Message);
		}


		
		[DataTestMethod]
		[DataRow(null)]
		[DataRow("")]
		[DataRow(" ")]
		public void ValiderNom(string nomProduit)
		{
			var exception=Assert.ThrowsException<Exception>(() =>
			{
				var produit = new Produit
				{
					Nom = nomProduit,
					Prix = 10
				};

				produit.Valider();

			});
			Assert.AreEqual("Nom est requis", exception.Message);
		}
	}
}
