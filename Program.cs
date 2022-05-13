using System;

namespace practree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
public class TreeNode // Класс «Узел бинарного дерева»
{
    private char info; // информационное поле
    private TreeNode left; // ссылка на левое поддерево
    private TreeNode right; // ссылка на правое поддерево
    public char Info
    {
        get { return info; }
        set { info = value; }
    } // свойства
    public TreeNode Left
    {
        get { return left; }
        set { left = value; }
    }
    public TreeNode Right
    {
        get { return right; }
        set { right = value; }
    }
    public TreeNode() { } // конструкторы
    public TreeNode(char info)
    {
        Info = info;
    }
    public TreeNode(char info, TreeNode left, TreeNode right)
    {
        Info = info; Left = left; Right = right;
    }
}

public class BinaryTree // Класс «Бинарное дерево произвольного вида»
{
    private TreeNode root; // ссылка на корень дерева
    public TreeNode Root // свойство, открывающее доступ к корню дерева
    {
        get { return root; }
        set { root = value; }
    }
    public BinaryTree() // создание пустого дерева
    {
        root = null;
    }
    public void LKP(TreeNode root)
    {
        if (root !=null)
        {
            LKP(root.Left);
            Console.Write(root.Info);
            LKP(root.Right);
        }
    }
    public int CountNode(TreeNode root)
    {
        int n;
        if (root != null) n = 1 + CountNode(root.Left) + CountNode(root.Right);
        else n = 0;
        return n;
    }
    public TreeNode BalancedTree(int N)
    {
        TreeNode root;
        if (N != 0)
        {
            char c;
            char.TryParse(Console.ReadLine(), out c);
            root = new TreeNode(c);
            root.Left = BalancedTree(N / 2);
            root.Right = BalancedTree(N - N / 2 - 1);
        }
        else root = null;
        return root;
    }
}
