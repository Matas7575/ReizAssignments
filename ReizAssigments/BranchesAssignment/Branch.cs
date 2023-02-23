namespace BranchesAssigment;

public class Branch
{
    public List<Branch> branches;

    public Branch() {
        branches = new List<Branch>();
    }

    public void AddBranch(Branch branch) {
        branches.Add(branch);
    }
}