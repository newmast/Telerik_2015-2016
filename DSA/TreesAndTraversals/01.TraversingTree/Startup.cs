namespace TraversingTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
/*
7
2 4
3 2
5 0
3 5
5 6
5 1
*/
        static IDictionary<int, TreeNode<int>> Nodes = new Dictionary<int, TreeNode<int>>();
        static List<LinkedList<int>> AllPaths = new List<LinkedList<int>>();

        static void Main()
        {
            var nodeCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < nodeCount - 1; i++)
            {
                var currentPair = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => int.Parse(n))
                    .ToList();

                var parent = currentPair[0];
                var child = currentPair[1];

                if (!Nodes.ContainsKey(parent))
                {
                    Nodes.Add(parent, new TreeNode<int>(parent));
                }

                if (!Nodes.ContainsKey(child))
                {
                    var childNode = new TreeNode<int>(child);
                    childNode.HasParent = true;
                    Nodes.Add(child, childNode);
                }
                else
                {
                    Nodes[child].HasParent = true;
                }
                
                Nodes[parent].Children.Add(Nodes[child]);
            }

            Console.WriteLine("Root element: " + FindRoot().Value);

            var leafs = FindAllLeafs();
            foreach (var leaf in leafs)
            {
                Console.WriteLine("Leaf: " + leaf.Value);
            }

            var middleNodes = FindMiddleNodes();
            foreach (var middleNode in middleNodes)
            {
                Console.WriteLine("Middle node: " + middleNode.Value);
            }

            var longestPath = GetLongestPath();

            Console.WriteLine("Longest path: " + string.Join(" -> ", longestPath));
        }

        public static TreeNode<int> FindRoot()
        {
            return Nodes.First(n => !n.Value.HasParent).Value;
        }

        public static IList<TreeNode<int>> FindAllLeafs()
        {
            return Nodes.Values.Where(n => n.Children.Count == 0).ToList();
        }

        public static IList<TreeNode<int>> FindMiddleNodes()
        {
            return Nodes.Values.Where(n => n.Children.Count > 0 && n.HasParent).ToList();
        }

        public static IList<int> GetLongestPath()
        {
            DFS(Nodes[FindRoot().Value], new LinkedList<int>());

            var longestPath = AllPaths
                .OrderByDescending(x => x.Count)
                .Take(2)
                .ToList();

            var maxLength = longestPath.FirstOrDefault().Count;

            longestPath = longestPath.FindAll(x => x.Count == maxLength);

            longestPath[0].RemoveFirst();
            var pathNodeToRoot = longestPath[0].ToList();
            pathNodeToRoot.Reverse();

            var pathRootToNode = longestPath[1].ToList();

            var resultList = new List<int>(pathNodeToRoot);
            resultList.AddRange(pathRootToNode);

            return resultList;
        }

        public static void DFS(TreeNode<int> node, LinkedList<int> path)
        {
            path.AddLast(node.Value);
            if (node.Children.Count == 0)
            {
                AllPaths.Add(path);
                return;
            }

            foreach (var child in node.Children)
            {
                DFS(child, new LinkedList<int>(path));
            }
        }
    }
}
