using Dinocade8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cellz;
using CellCollectionz;
using Terominoz;
using TetrominoStylz;
using GameStates;
using TetrominoOrientationz;
namespace Griders
{
	public class Grid
	{
		public int Width { get; } = 10;
		public int Height { get; } = 20;
		public CellCollection Cells { get; set; } = new CellCollection();
		public GameState State { get; set; } = GameState.NotStarted;

		public bool IsStarted
		{
			get
			{
				return State == GameState.Playing
					|| State == GameState.GameOver;
			}
		}
	}
}
