namespace Checkers
{
    public struct Position
    {
        public int Row { get; private set; }
        public int Column { get; private set; }
        public Position(int row, int col)
        {
            this.Row = row;
            this.Column = col;
        }
    }

    public enum Color { White, Black }

    public class Checker
    {
        public string Symbol { get; private set; } = string.Empty;
        public Color PlayerColor { get; private set; }
        public Position Position { get; set; }

        public Checker(Color playerColor, int row, int col)
        {
            this.PlayerColor = playerColor;
            this.Position = new Position(row, col);
            SetSymbol(playerColor);
        }

        private void SetSymbol(Color checkerColor)
        {
            if (checkerColor == Color.Black)
            {
                var black = int.Parse("2591", System.Globalization.NumberStyles.HexNumber);
                this.Symbol = char.ConvertFromUtf32(black);
            }
            else
            {
                var white = int.Parse("2588", System.Globalization.NumberStyles.HexNumber);
                this.Symbol = char.ConvertFromUtf32(white);
            }
        }
    }
}
