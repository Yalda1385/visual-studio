Console.WriteLine("welcome to the Yes/No Decistion Tree!");

static Node root = new Node("Is it raining?");
string answer = AskQuestion(root);
Console.WriteLine($"Decision:{answer}");

{
    Node Yes = new Node("Do you have an umbrella?")
    {
        Yes = new Node("You can go outside."),
        No = new Node("Stay indoors.")
    };
    Node No = new Node("Do you want to go for a walk?")
    {
        Yes = new Node("It is a great day for a walk?")
            No = new Node("Stay at home and relax.")
    };
};

static string AskQuestion(Node node);
{
    object node = null;
    Console.WriteLine(node.Question);
    string response = Console.ReadLine().Trim().ToLower();

    if (response == "yes")
    {
        if (node.Yes != null)
            return AskQuestion(node.Yes);
        else
            return "Yes";
    }
    else if (response == "no")
    {
        if (node.No != null)
            return AskQuestion(node.No);
        else
            return "No";
    }
    else
    {
        Console.WriteLine("Please answer with 'yes'or'no'");
        return AskQuestion(node.No);
    }
}
class Node
{
    public string Question { get; }
    public Node Yes { get; set; }
    public Node No { get; set }

    public Node(string question)
    {
        Question = question;
    }

}
