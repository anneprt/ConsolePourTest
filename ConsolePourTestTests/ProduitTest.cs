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
		[DataRow("-1")]
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

			Assert.AreEqual("le prix doit être supérieur à 0", exception.Message);
		}


		/*[TestMethod]
		public void ImpossibleDeMettrePrixInfouEgal0()
		{
			var exception=Assert.ThrowsException<Exception>(() =>
			{
				var produit = new Produit
				{
					Nom = "Bouteille Bordeaux",
					Prix = 0
				};

			});

			Assert.AreEqual("le prix ne peut pas être négatif", exception.Message);

		}*/

		[DataTestMethod]
		[DataRow("null")]
		[DataRow("")]
		[DataRow("      ")]
		public void ValiderNom(string nomProduit)
		{
			var exception=Assert.ThrowsException<Exception>(() =>
			{
				var produit = new Produit
				{
					Nom = "",
					Prix = 10
				};

				produit.Valider();

			});
			Assert.AreEqual("le nom est requis", exception.Message);
		}
	}
}
