using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    /// <summary>
    /// Problem 15: Lattice paths
    /// https://projecteuler.net/problem=15
    /// 
    /// Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
    /// How many such routes are there through a 20×20 grid?
    /// </summary>
    public class LatticePath
    {
        public long Count(int gridSize)
        {
            var grid = new Grid(gridSize);

            return grid.Go();
        }

        private class Grid
        {
            private readonly IList<Node> _currentNodes;
            private readonly Node _lastNode;

            public Grid(int size)
            {
                _lastNode = new Node(new Point(size, size), 0);
                _currentNodes = new List<Node>
                                {
                                    new Node(coordinate: new Point(0, 0),
                                             pathCount: 1)
                                };
            }

            public long Go()
            {
                while (true)
                {
                    if (_currentNodes.First().HasPathTo(_lastNode))
                    {
                        MoveForwards(_currentNodes.First());

                        continue;
                    }

                    return _currentNodes.Single().PathCount;
                }
            }

            private void MoveForwards(Node node)
            {
                Add(node.MoveDown());
                Add(node.MoveRight());

                _currentNodes.Remove(node);
            }

            private void Add(Node newNode)
            {
                if (!newNode.HasPathTo(_lastNode) && !newNode.Equals(_lastNode))
                    return;

                var matchNode = _currentNodes.FirstOrDefault(node => node.Equals(newNode));

                if (matchNode == null)
                {
                    _currentNodes.Add(newNode);
                    return;
                }

                matchNode.MergePathCount(newNode);
            }
        }

        private class Node
        {
            public Node(Point coordinate, long pathCount)
            {
                Coordinate = coordinate;
                PathCount = pathCount;
            }

            private Point Coordinate { get; }

            public long PathCount { get; private set; }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj))
                    return false;
                if (ReferenceEquals(this, obj))
                    return true;
                var other = obj as Node;
                return other != null && Equals(other);
            }

            public override int GetHashCode()
            {
                return Coordinate?.GetHashCode() ?? 0;
            }

            public override string ToString()
            {
                return $"Coordinate: {{{Coordinate}}}, PathCount: {PathCount}";
            }

            public Node MoveDown()
            {
                return new Node(coordinate: new Point(Coordinate.X, Coordinate.Y + 1),
                                pathCount: PathCount);
            }

            public Node MoveRight()
            {
                return new Node(coordinate: new Point(Coordinate.X + 1, Coordinate.Y),
                                pathCount: PathCount);
            }

            public void MergePathCount(Node other)
            {
                if (Equals(other))
                    PathCount += other.PathCount;
            }

            public bool HasPathTo(Node other)
            {
                return Coordinate.HasPathTo(other.Coordinate);
            }

            protected bool Equals(Node other)
            {
                return Equals(Coordinate, other.Coordinate);
            }
        }

        private class Point
        {
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; }

            public int Y { get; }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj))
                    return false;
                if (ReferenceEquals(this, obj))
                    return true;
                var other = obj as Point;
                return other != null && Equals(other);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    return (X*397) ^ Y;
                }
            }

            public override string ToString()
            {
                return $"X: {X}, Y: {Y}";
            }

            public bool HasPathTo(Point other)
            {
                if (X < other.X && Y <= other.Y)
                    return true;
                if (Y < other.Y && X <= other.X)
                    return true;
                return false;
            }

            protected bool Equals(Point other)
            {
                return X == other.X && Y == other.Y;
            }
        }
    }
}