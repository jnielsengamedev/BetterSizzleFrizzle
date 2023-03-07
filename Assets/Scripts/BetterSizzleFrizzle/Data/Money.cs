namespace BetterSizzleFrizzle.Data
{
	public class Money
	{
		/// <summary>
		/// Cash total.
		/// </summary>
		public long Cash { get; private set; }

		/// <summary>
		/// Add an amount of cash to your Cash total.
		/// </summary>
		/// <param name="cash">An amount of cash you want to add to your Cash total.</param>
		public void AddCash(long cash)
		{
			Cash += cash;
		}

		/// <summary>
		/// Take away an amount of cash from your Cash total.
		/// </summary>
		/// <param name="cash"></param>
		public void RemoveCash(long cash)
		{
			Cash -= cash;
		}

		/// <summary>
		/// Bankrupt your Cash total. Sets your Cash total to 0.
		/// </summary>
		public void Bankrupt()
		{
			Cash = 0;
		}
	}
}