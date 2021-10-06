using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
    public new static void UpdatePosition(string pressedKey, out int X, out int Y)
    {
        switch (pressedKey)
        {
          case "LeftArrow":
        	X = -1;
        	Y = 0;
        	break;         
      	case "RightArrow":
        	X = 1;
        	Y = 0;
        	break;
        case "UpArrow":
        	X = 0;
        	Y = -1;
        	break;        
      	case "DownArrow": 
        	X = 0;
        	Y = 1;
        	break;
      	default:
        	X = 0;
        	Y = 1;
        	break;

      }
    }

    public new static char UpdateCursor(string pressedKey)
    {
      switch (pressedKey)
      {
          case "DownArrow":
            return 'v';
          break;

          case "UpArrow":
            return '^';
          break;

          case "RightArrow":
            return '>';
          break;

          case "LeftArrow":
            return '<';
          break;
      }
      return '>';
    }

    public new static int keepInbounds(int Coordinate, int MaxValue)
    {
          	return Coordinate < 0 ? 0 : Coordinate >= MaxValue ? MaxValue - 1 : Coordinate;
      
    }

    public new static bool DidScore(int charX, int charY, int fruitX, int fruitY){
      return charX==fruitX && charY==fruitY;
    }

  }
}