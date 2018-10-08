using System;
using ConsolePourTest.Entites;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsolePourTestTests
{
	[TestClass]
	public class ProduitTest
	{
		[TestMethod]
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

		}

		[TestMethod]
		public void ImpossibleDeMettreNomVide()
		{
			Assert.ThrowsException<Exception>(() =>
			{
				var produit = new Produit
				{
					Nom = "",
					Prix = 10
				};

				produit.Valider();

			});

		}
	}
}
