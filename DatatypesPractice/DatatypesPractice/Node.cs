namespace DatatypesPractice
{
    public class Node
    {
        public int Data;
        public Node Left;
        public Node Right;

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
    public class BinaryTree
    {
        public Node Root;

        public BinaryTree()
        {
            Root = null;
        }

        // Function to insert a new node
        public void Insert(int data)
        {
            Root = InsertRecursive(Root, data);
        }

        private Node InsertRecursive(Node root, int data)
        {
            if (root == null)
            {
                root = new Node(data);
            }
            else if (data < root.Data)
            {
                root.Left = InsertRecursive(root.Left, data);
            }
            else
            {
                root.Right = InsertRecursive(root.Right, data);
            }
            return root;
        }

        // Function to perform inorder traversal
        public void InorderTraversal(Node root)
        {
            if (root != null)
            {
                InorderTraversal(root.Left);
                Console.Write(root.Data + " ");
                InorderTraversal(root.Right);
            }
        }

        // Function to perform preorder traversal
        public void PreorderTraversal(Node root)
        {
            if (root != null)
            {
                Console.Write(root.Data + " ");
                PreorderTraversal(root.Left);
                PreorderTraversal(root.Right);
            }
        }

        // Function to perform postorder traversal
        public void PostorderTraversal(Node root)
        {
            if (root != null)
            {
                PostorderTraversal(root.Left);
                PostorderTraversal(root.Right);
                Console.Write(root.Data + " ");
            }
        }
    }

}
