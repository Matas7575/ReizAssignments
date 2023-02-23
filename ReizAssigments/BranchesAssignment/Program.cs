// See https://aka.ms/new-console-template for more information

using BranchesAssigment;

// create a root branch
Branch rootBranch = new Branch();

// create some child branches
Branch childBranch1 = new Branch();
Branch childBranch2 = new Branch();
Branch childBranch3 = new Branch();

// add the child branches to the root branch
rootBranch.AddBranch(childBranch1);
rootBranch.AddBranch(childBranch2);
rootBranch.AddBranch(childBranch3);

// create some grandchild branches
Branch grandchildBranch1 = new Branch();
Branch grandchildBranch2 = new Branch();
Branch grandchildBranch3 = new Branch();

// add the grandchild branches to the first child branch
childBranch1.AddBranch(grandchildBranch1);
childBranch1.AddBranch(grandchildBranch2);
childBranch1.AddBranch(grandchildBranch3);

// create some great-grandchild branches
Branch greatGrandchildBranch1 = new Branch();
Branch greatGrandchildBranch2 = new Branch();

// add the great-grandchild branches to the first grandchild branch
grandchildBranch1.AddBranch(greatGrandchildBranch1);
grandchildBranch1.AddBranch(greatGrandchildBranch2);

// print out the structure of the branches
PrintBranch(rootBranch);

/*
 * this method takes a Branch object and a depth parameter indicating the current
 * depth of the object in the hierarchy. The method uses a loop to iterate over the branches in
 * the object's list of branches, and recursively calls itself with each child branch and an
 * incremented depth value. The method also prints out a series of dashes to indicate the
 * depth of each branch in the hierarchy.
 */
static void PrintBranch(Branch branch, int depth = 0)
{
    Console.WriteLine(new String('-', depth) + "Branch");

    foreach (Branch childBranch in branch.branches)
    {
        PrintBranch(childBranch, depth + 1);
    }
}