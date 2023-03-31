public class LicensePlate
{

    public static string FormatLicensePlate(string License, int GroupSize)
    {

        string NewLicense = "";
        int currentGroupSize = 0;

        // iterate from last
        for (int i = License.Length - 1; i >= 0; i--)
        {

            // skip '-' in old License string
            if (License[i] == '-')
            {
                continue;
            }

            // if current group size has reached the target group size add '-'
            // add '-' to begining of License string
            // and reset group size to 0
            if (currentGroupSize == GroupSize)
            {
                NewLicense = '-' + NewLicense;
                currentGroupSize = 0;
            }

            // capitalize add character to beginning of license string
            // increase group size by 1
            NewLicense = License[i].ToString().ToUpper() + NewLicense;
            currentGroupSize++;
        }

        return NewLicense;
    }

    public static int TimeToGetNewLicense(string Me, int AgentCount, string OtherPeople)
    {

        // Add all people in array and sort
        // find index of me and convert to 1-based index
        string[] AllPeople = OtherPeople.Split(" ").Append(Me).ToArray();
        Array.Sort(AllPeople);
        float MyPosition = Array.FindIndex(AllPeople, People => People == Me) + 1;

        // find the group in which the person belongs
        int MyGroup = (int)float.Ceiling(MyPosition / AgentCount);

        // multiply by time (20) and return the result
        return MyGroup * 20;
    }

    public static void Main(string[] args) { }

}